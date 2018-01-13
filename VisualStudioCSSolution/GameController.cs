//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class GameController : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GameController(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GameController obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GameController() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bcPINVOKE.delete_GameController(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GameController() : this(bcPINVOKE.new_GameController(), true) {
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void next_turn() {
    bcPINVOKE.GameController_next_turn(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint round() {
    uint ret = bcPINVOKE.GameController_round(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Planet planet() {
    Planet ret = (Planet)bcPINVOKE.GameController_planet(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Team team() {
    Team ret = (Team)bcPINVOKE.GameController_team(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlanetMap starting_map(Planet planet) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_starting_map(swigCPtr, (int)planet);
    PlanetMap ret = (cPtr == global::System.IntPtr.Zero) ? null : new PlanetMap(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint karbonite() {
    uint ret = bcPINVOKE.GameController_karbonite(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Unit unit(ushort id) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_unit(swigCPtr, id);
    Unit ret = (cPtr == global::System.IntPtr.Zero) ? null : new Unit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecUnit units() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_units(swigCPtr);
    VecUnit ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecUnit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecUnit my_units() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_my_units(swigCPtr);
    VecUnit ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecUnit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecUnit units_in_space() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_units_in_space(swigCPtr);
    VecUnit ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecUnit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint karbonite_at(MapLocation location) {
    uint ret = bcPINVOKE.GameController_karbonite_at(swigCPtr, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecMapLocation all_locations_within(MapLocation location, uint radius_squared) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_all_locations_within(swigCPtr, MapLocation.getCPtr(location), radius_squared);
    VecMapLocation ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecMapLocation(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte can_sense_location(MapLocation location) {
    byte ret = bcPINVOKE.GameController_can_sense_location(swigCPtr, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte can_sense_unit(ushort id) {
    byte ret = bcPINVOKE.GameController_can_sense_unit(swigCPtr, id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecUnit sense_nearby_units(MapLocation location, uint radius) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_sense_nearby_units(swigCPtr, MapLocation.getCPtr(location), radius);
    VecUnit ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecUnit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecUnit sense_nearby_units_by_team(MapLocation location, uint radius, Team team) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_sense_nearby_units_by_team(swigCPtr, MapLocation.getCPtr(location), radius, (int)team);
    VecUnit ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecUnit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecUnit sense_nearby_units_by_type(MapLocation location, uint radius, UnitType unit_type) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_sense_nearby_units_by_type(swigCPtr, MapLocation.getCPtr(location), radius, (int)unit_type);
    VecUnit ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecUnit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte has_unit_at_location(MapLocation location) {
    byte ret = bcPINVOKE.GameController_has_unit_at_location(swigCPtr, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Unit sense_unit_at_location(MapLocation location) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_sense_unit_at_location(swigCPtr, MapLocation.getCPtr(location));
    Unit ret = (cPtr == global::System.IntPtr.Zero) ? null : new Unit(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AsteroidPattern asteroid_pattern() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_asteroid_pattern(swigCPtr);
    AsteroidPattern ret = (cPtr == global::System.IntPtr.Zero) ? null : new AsteroidPattern(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OrbitPattern orbit_pattern() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_orbit_pattern(swigCPtr);
    OrbitPattern ret = (cPtr == global::System.IntPtr.Zero) ? null : new OrbitPattern(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint current_duration_of_flight() {
    uint ret = bcPINVOKE.GameController_current_duration_of_flight(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Veci32 get_team_array(Planet planet) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_get_team_array(swigCPtr, (int)planet);
    Veci32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Veci32(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void write_team_array(uint index, int value) {
    bcPINVOKE.GameController_write_team_array(swigCPtr, index, value);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void disintegrate_unit(ushort unit_id) {
    bcPINVOKE.GameController_disintegrate_unit(swigCPtr, unit_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte is_occupiable(MapLocation location) {
    byte ret = bcPINVOKE.GameController_is_occupiable(swigCPtr, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte can_move(ushort robot_id, Direction direction) {
    byte ret = bcPINVOKE.GameController_can_move(swigCPtr, robot_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_move_ready(ushort robot_id) {
    byte ret = bcPINVOKE.GameController_is_move_ready(swigCPtr, robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void move_robot(ushort robot_id, Direction direction) {
    bcPINVOKE.GameController_move_robot(swigCPtr, robot_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_attack(ushort robot_id, ushort target_unit_id) {
    byte ret = bcPINVOKE.GameController_can_attack(swigCPtr, robot_id, target_unit_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_attack_ready(ushort robot_id) {
    byte ret = bcPINVOKE.GameController_is_attack_ready(swigCPtr, robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void attack(ushort robot_id, ushort target_unit_id) {
    bcPINVOKE.GameController_attack(swigCPtr, robot_id, target_unit_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResearchInfo research_info() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_research_info(swigCPtr);
    ResearchInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResearchInfo(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte reset_research() {
    byte ret = bcPINVOKE.GameController_reset_research(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte queue_research(UnitType branch) {
    byte ret = bcPINVOKE.GameController_queue_research(swigCPtr, (int)branch);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte can_harvest(ushort worker_id, Direction direction) {
    byte ret = bcPINVOKE.GameController_can_harvest(swigCPtr, worker_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void harvest(ushort worker_id, Direction direction) {
    bcPINVOKE.GameController_harvest(swigCPtr, worker_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_blueprint(ushort worker_id, UnitType unit_type, Direction direction) {
    byte ret = bcPINVOKE.GameController_can_blueprint(swigCPtr, worker_id, (int)unit_type, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void blueprint(ushort worker_id, UnitType structure_type, Direction direction) {
    bcPINVOKE.GameController_blueprint(swigCPtr, worker_id, (int)structure_type, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_build(ushort worker_id, ushort blueprint_id) {
    byte ret = bcPINVOKE.GameController_can_build(swigCPtr, worker_id, blueprint_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void build(ushort worker_id, ushort blueprint_id) {
    bcPINVOKE.GameController_build(swigCPtr, worker_id, blueprint_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_repair(ushort worker_id, ushort structure_id) {
    byte ret = bcPINVOKE.GameController_can_repair(swigCPtr, worker_id, structure_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void repair(ushort worker_id, ushort structure_id) {
    bcPINVOKE.GameController_repair(swigCPtr, worker_id, structure_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_replicate(ushort worker_id, Direction direction) {
    byte ret = bcPINVOKE.GameController_can_replicate(swigCPtr, worker_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void replicate(ushort worker_id, Direction direction) {
    bcPINVOKE.GameController_replicate(swigCPtr, worker_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_javelin(ushort knight_id, ushort target_unit_id) {
    byte ret = bcPINVOKE.GameController_can_javelin(swigCPtr, knight_id, target_unit_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_javelin_ready(ushort knight_id) {
    byte ret = bcPINVOKE.GameController_is_javelin_ready(swigCPtr, knight_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void javelin(ushort knight_id, ushort target_unit_id) {
    bcPINVOKE.GameController_javelin(swigCPtr, knight_id, target_unit_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_begin_snipe(ushort ranger_id, MapLocation location) {
    byte ret = bcPINVOKE.GameController_can_begin_snipe(swigCPtr, ranger_id, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_begin_snipe_ready(ushort ranger_id) {
    byte ret = bcPINVOKE.GameController_is_begin_snipe_ready(swigCPtr, ranger_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void begin_snipe(ushort ranger_id, MapLocation location) {
    bcPINVOKE.GameController_begin_snipe(swigCPtr, ranger_id, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_blink(ushort mage_id, MapLocation location) {
    byte ret = bcPINVOKE.GameController_can_blink(swigCPtr, mage_id, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_blink_ready(ushort mage_id) {
    byte ret = bcPINVOKE.GameController_is_blink_ready(swigCPtr, mage_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void blink(ushort mage_id, MapLocation location) {
    bcPINVOKE.GameController_blink(swigCPtr, mage_id, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_heal(ushort healer_id, ushort target_robot_id) {
    byte ret = bcPINVOKE.GameController_can_heal(swigCPtr, healer_id, target_robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_heal_ready(ushort healer_id) {
    byte ret = bcPINVOKE.GameController_is_heal_ready(swigCPtr, healer_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void heal(ushort healer_id, ushort target_robot_id) {
    bcPINVOKE.GameController_heal(swigCPtr, healer_id, target_robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_overcharge(ushort healer_id, ushort target_robot_id) {
    byte ret = bcPINVOKE.GameController_can_overcharge(swigCPtr, healer_id, target_robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_overcharge_ready(ushort healer_id) {
    byte ret = bcPINVOKE.GameController_is_overcharge_ready(swigCPtr, healer_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void overcharge(ushort healer_id, ushort target_robot_id) {
    bcPINVOKE.GameController_overcharge(swigCPtr, healer_id, target_robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_load(ushort structure_id, ushort robot_id) {
    byte ret = bcPINVOKE.GameController_can_load(swigCPtr, structure_id, robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void load(ushort structure_id, ushort robot_id) {
    bcPINVOKE.GameController_load(swigCPtr, structure_id, robot_id);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_unload(ushort structure_id, Direction direction) {
    byte ret = bcPINVOKE.GameController_can_unload(swigCPtr, structure_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unload(ushort structure_id, Direction direction) {
    bcPINVOKE.GameController_unload(swigCPtr, structure_id, (int)direction);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte can_produce_robot(ushort factory_id, UnitType robot_type) {
    byte ret = bcPINVOKE.GameController_can_produce_robot(swigCPtr, factory_id, (int)robot_type);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void produce_robot(ushort factory_id, UnitType robot_type) {
    bcPINVOKE.GameController_produce_robot(swigCPtr, factory_id, (int)robot_type);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RocketLandingInfo rocket_landings() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_rocket_landings(swigCPtr);
    RocketLandingInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new RocketLandingInfo(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte can_launch_rocket(ushort rocket_id, MapLocation destination) {
    byte ret = bcPINVOKE.GameController_can_launch_rocket(swigCPtr, rocket_id, MapLocation.getCPtr(destination));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void launch_rocket(ushort rocket_id, MapLocation location) {
    bcPINVOKE.GameController_launch_rocket(swigCPtr, rocket_id, MapLocation.getCPtr(location));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public StartGameMessage start_game(Player player) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_start_game(swigCPtr, Player.getCPtr(player));
    StartGameMessage ret = (cPtr == global::System.IntPtr.Zero) ? null : new StartGameMessage(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TurnApplication apply_turn(TurnMessage turn) {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_apply_turn(swigCPtr, TurnMessage.getCPtr(turn));
    TurnApplication ret = (cPtr == global::System.IntPtr.Zero) ? null : new TurnApplication(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InitialTurnApplication initial_start_turn_message() {
    global::System.IntPtr cPtr = bcPINVOKE.GameController_initial_start_turn_message(swigCPtr);
    InitialTurnApplication ret = (cPtr == global::System.IntPtr.Zero) ? null : new InitialTurnApplication(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte is_over() {
    byte ret = bcPINVOKE.GameController_is_over(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Team winning_team() {
    Team ret = (Team)bcPINVOKE.GameController_winning_team(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string manager_viewer_message() {
    string ret = bcPINVOKE.GameController_manager_viewer_message(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void print_game_ansi() {
    bcPINVOKE.GameController_print_game_ansi(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint manager_karbonite(Team team) {
    uint ret = bcPINVOKE.GameController_manager_karbonite(swigCPtr, (int)team);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
