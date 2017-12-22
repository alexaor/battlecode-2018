//! The core battlecode engine.

use fnv::FnvHashMap;

use super::constants::*;
use super::schema::Delta;
use super::location::*;
use super::unit;
use super::research;
use super::error::GameError;

/// There are two teams in Battlecode: Red and Blue.
#[derive(Debug, Clone, Copy, Serialize, Deserialize, Hash, PartialEq, Eq)]
pub enum Team {
    Red,
    Blue,
}

/// The map for one of the planets in the Battlecode world. This information
/// defines the terrain and dimensions of the planet.
#[derive(Debug, Clone, Serialize, Deserialize, PartialEq)]
pub struct Map {
    /// The height of this map, in squares. Must be in the range
    /// [constants::MAP_MIN_HEIGHT, constants::MAP_MAX_HEIGHT], inclusive.
    height: usize,

    /// The width of this map, in squares. Must be in the range
    /// [constants::MAP_MIN_WIDTH, constants::MAP_MAX_WIDTH], inclusive.
    width: usize,

    /// The coordinates of the bottom-left corner. Essentially, the
    /// minimum x and y coordinates for this map. Each lies within
    /// [constants::MAP_MIN_COORDINATE, constants::MAP_MAX_COORDINATE],
    /// inclusive.
    origin: MapLocation,

    /// Whether the specified square contains passable terrain. Is only
    /// false when the square contains impassable terrain (distinct from
    /// containing a building, for instance).
    ///
    /// Stored as a two-dimensional array, where the first index 
    /// represents a square's y-coordinate, and the second index its 
    /// x-coordinate. These coordinates are *relative to the origin*.
    is_passable_terrain: Vec<Vec<bool>>,
}

impl Map {
    pub fn new() -> Map {
        Map {
            height: MAP_MIN_HEIGHT,
            width: MAP_MIN_WIDTH,
            origin: MapLocation::new(Planet::Earth, 0, 0),
            is_passable_terrain: vec![vec![true; MAP_MIN_WIDTH]; MAP_MIN_HEIGHT],
        }
    }
}

/// The state for one of the planets in a game.
///
/// Stores neutral map info (map dimension, terrain, and karbonite deposits)
/// and non-neutral unit info (robots, factories, rockets). This information
/// is generally readable by both teams, and is ephemeral.
#[derive(Debug, Clone, Serialize, Deserialize, PartialEq)]
pub struct PlanetInfo {
    /// The map of the game.
    map: Map,

    /// The amount of Karbonite deposited on the specified square.
    ///
    /// Stored as a two-dimensional array, where the first index 
    /// represents a square's y-coordinate, and the second index its 
    /// x-coordinate. These coordinates are *relative to the origin*.
    karbonite: Vec<Vec<u32>>,
}

impl PlanetInfo {
    pub fn new() -> PlanetInfo {
        PlanetInfo {
            map: Map::new(),
            karbonite: vec![vec![0; MAP_MAX_WIDTH]; MAP_MAX_HEIGHT],
        }
    }
}

/// A team-shared communication array.
pub type TeamArray = Vec<u8>;

/// A history of communication arrays. Read from the back of the queue on the
/// current planet, and the front of the queue on the other planet.
pub type TeamArrayHistory = Vec<TeamArray>;

/// Persistent info specific to a single team. Teams are only able to access
/// the team info of their own team.
#[derive(Debug, Serialize, Deserialize, Clone)]
pub struct TeamInfo {
    /// Communication array histories for each planet.
    team_arrays: FnvHashMap<Planet, TeamArrayHistory>,

    /// The current status of the team's research. The values defines the level
    /// of the research, where 0 represents no progress.
    research_status: FnvHashMap<research::Branch, u32>,

    /// Research branches queued to be researched, including the current branch.
    research_queue: Vec<research::Branch>,

    /// The number of rounds to go until the first branch in the research
    /// queue is finished. 0 if the research queue is empty.
    research_rounds_left: u32,
}

impl TeamInfo {
    pub fn new() -> TeamInfo {
        TeamInfo {
            team_arrays: FnvHashMap::default(),
            research_status: FnvHashMap::default(),
            research_queue: Vec::new(),
            research_rounds_left: 0,
        }
    }
}

/// A player represents a program controlling some group of units.
#[derive(Debug, Serialize, Deserialize, Clone, Copy)]
pub struct Player {
    /// The team of this player.
    pub team: Team,

    /// The planet for this player. Each team disjointly controls the robots on each planet.
    pub planet: Planet,
}

/// The full world of the Battlecode game.
#[derive(Debug, Serialize, Deserialize, Clone)]
pub struct GameWorld {
    /// The current round, starting at 1.
    pub round: u32,

    /// The player whose turn it is.
    pub player_to_move: Player,

    /// All the units on the map.
    units: FnvHashMap<unit::UnitID, unit::Unit>,

    /// All the units on the map, by location.
    units_by_loc: FnvHashMap<MapLocation, unit::UnitID>,

    pub planet_states: FnvHashMap<Planet, PlanetInfo>,
    pub team_states: FnvHashMap<Team, TeamInfo>,
}

impl GameWorld {
    pub fn new() -> GameWorld {
        let mut planet_states = FnvHashMap::default();
        planet_states.insert(Planet::Earth, PlanetInfo::new());
        GameWorld {
            round: 1,
            player_to_move: Player { team: Team::Red, planet: Planet::Earth },
            units: FnvHashMap::default(),
            units_by_loc: FnvHashMap::default(),
            planet_states: planet_states,
            team_states: FnvHashMap::default(),
        }
    }

    fn get_planet_info(&self, planet: Planet) -> &PlanetInfo {
        if let Some(planet_info) = self.planet_states.get(&planet) {
            planet_info
        } else {
            panic!("Internal engine error");
        }
    }
    
    fn get_planet_info_mut(&mut self, planet: Planet) -> &mut PlanetInfo {
        if let Some(planet_info) = self.planet_states.get_mut(&planet) {
            planet_info
        } else {
            panic!("Internal engine error");
        }
    }

    fn get_unit(&self, id: unit::UnitID) -> Option<&unit::Unit> {
        self.units.get(&id)
    }

    fn get_unit_mut(&mut self, id: unit::UnitID) -> Option<&mut unit::Unit> {
        self.units.get_mut(&id)
    }

    /// Places a unit onto the map at the given location. Assumes the given square is occupiable.
    pub fn place_unit(&mut self, id: unit::UnitID, location: MapLocation) -> Result<(), GameError> {
        if self.is_occupiable(location) {
            if let Some(unit) = self.get_unit_mut(id) {
                unit.location = location;
            } else {
                return Err(GameError::InternalEngineError);
            }
            self.units_by_loc.insert(location, id);
            Ok(())
        } else {
            Err(GameError::InternalEngineError)
        }
    }

    /// Removes a unit from the map. Assumes the unit is on the map.
    pub fn remove_unit(&mut self, id: unit::UnitID) -> Result<(), GameError> {
        let location = if let Some(unit) = self.get_unit_mut(id) {
            // TODO: unit locations should probably be an Option
            // to better handle unplaced units.
            let location = unit.location;
            unit.location = MapLocation::new(Planet::Earth, -1, -1);
            location
        } else {
            return Err(GameError::InternalEngineError);
        };
        self.units_by_loc.remove(&location);
        Ok(())
    }

    /// Inserts a given unit into the GameWorld, so that it can be referenced by ID.
    pub fn register_unit(&mut self, unit: unit::Unit) {
        self.units.insert(unit.id, unit);
    }

    /// Deletes a unit. Unit should be removed from map first.
    pub fn delete_unit(&mut self, id: unit::UnitID) {
        self.units.remove(&id);
    }

    /// Returns whether the square is clear for a new unit to occupy, either by movement or by construction.
    pub fn is_occupiable(&self, location: MapLocation) -> bool {
        let planet_info = &self.planet_states[&location.planet];
        return planet_info.map.is_passable_terrain[location.y as usize][location.x as usize] &&
            !self.units_by_loc.contains_key(&location);
    }

    /// Tests whether the given unit can move.
    pub fn can_move(&self, id: unit::UnitID, direction: Direction) -> bool {
        if let Some(unit) = self.get_unit(id) {
            unit.is_move_ready() && self.is_occupiable(unit.location.add(direction))
        } else {
            panic!("Internal Engine Error");
        }
    }

    // Given that moving an unit comprises many edits to the GameWorld, it makes sense to define this here.
    pub fn move_unit(&mut self, id: unit::UnitID, direction: Direction) -> Result<(), GameError> {
        let dest = if let Some(unit) = self.get_unit(id) {
            unit.location.add(direction)
        } else {
            return Err(GameError::NoSuchUnit);
        };
        if self.can_move(id, direction) {
            self.remove_unit(id);
            self.place_unit(id, dest);
            Ok(())
        } else {
            Err(GameError::InvalidAction)
        }
    }

    fn apply(&mut self, delta: Delta) -> Result<(), GameError> {
        match delta {
            Delta::Move{id, direction} => self.move_unit(id, direction),
            _ => Ok(()),
        }
    }
}

#[cfg(test)]
mod tests {
    use super::GameWorld;

    #[test]
    fn it_works() {}

    #[test]
    fn test_is_occupiable() {
        let mut world = GameWorld::new();
    }
}
