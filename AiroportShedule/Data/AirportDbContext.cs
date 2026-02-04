using AiroportShedule.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AiroportShedule.Data
{
    public class AirportDbContext : IDisposable
    {
        private readonly string _connectionString = "server=127.0.0.1;uid=root;pwd=admin;database=airoportdb";
        private MySqlConnection _connection;
        private bool _disposed = false;

        public AirportDbContext()
        {
           
        }

        private void EnsureConnection()
        {
            if (_connection == null || _connection.State != ConnectionState.Open)
            {
                _connection = new MySqlConnection(_connectionString);
                _connection.Open();
            }
        }

        public User AuthenticateUser(string login, string password)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    c.ID,
                    c.Login,
                    c.Full_Name,
                    c.Role_ID
                FROM crew c
                WHERE c.Login = @Login AND c.Password = @Password
                LIMIT 1";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32("ID"),
                    Login = reader.GetString("Login"),
                    FullName = reader.GetString("Full_Name"),
                    Role = MapRoleIdToEnum(reader.GetInt32("Role_ID"))
                };
            }
            reader.Close();

            query = @"
                SELECT 
                    sp.ID,
                    sp.Full_Name,
                    sp.Role_ID
                FROM service_personnel sp
                INNER JOIN roles r ON sp.Role_ID = r.ID
                WHERE r.Name = @Login
                LIMIT 1";

            cmd.Parameters.Clear();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Login", login);

            using var reader2 = cmd.ExecuteReader();
            if (reader2.Read())
            {

                return new User
                {
                    Id = reader2.GetInt32("ID"),
                    Login = login,
                    FullName = reader2.GetString("Full_Name"),
                    Role = MapRoleIdToEnum(reader.GetInt32("Role_ID"))
                };
            }

            return null;
        }

        public User GetUserById(int userId)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    c.ID,
                    c.Login,
                    c.Full_Name,
                    c.Role_ID
                FROM crew c
                WHERE c.ID = @UserID
                LIMIT 1";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@UserID", userId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32("ID"),
                    Login = reader.GetString("Login"),
                    FullName = reader.GetString("Full_Name"),
                    Role = MapRoleIdToEnum(reader.GetInt32("Role_ID"))
                };
            }

            return null;
        }

        public List<FlightScheduleItem> GetFlightSchedule()
        {
            EnsureConnection();

            var schedule = new List<FlightScheduleItem>();
            var query = @"
                SELECT 
                    rs.ID AS ScheduleID,
                    rs.Time_Interval,
                    rs.Landing_Time,
                    rs.Takeoff_Time,
                    r.Name AS RouteName,
                    am.Name AS AircraftName,
                    am.Capacity,
                    am.Baggage_Capacity
                FROM route_schedule rs
                INNER JOIN route r ON rs.Route_ID = r.ID
                INNER JOIN aircraft_model am ON rs.Aircraft_ID = am.ID
                ORDER BY rs.Takeoff_Time";

            using var cmd = new MySqlCommand(query, _connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                schedule.Add(new FlightScheduleItem
                {
                    ScheduleId = reader.GetInt32("ScheduleID"),
                    TimeInterval = reader.GetString("Time_Interval"),
                    TakeoffTime = reader.GetDateTime("Takeoff_Time"),
                    LandingTime = reader.GetDateTime("Landing_Time"),
                    RouteName = reader.GetString("RouteName"),
                    AircraftName = reader.GetString("AircraftName"),
                    Capacity = reader.GetInt32("Capacity"),
                    BaggageCapacity = reader.GetInt32("Baggage_Capacity")
                });
            }

            return schedule;
        }

        public FlightScheduleItem GetFlightById(int flightId)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    rs.ID AS ScheduleID,
                    rs.Time_Interval,
                    rs.Landing_Time,
                    rs.Takeoff_Time,
                    r.Name AS RouteName,
                    am.Name AS AircraftName,
                    am.Capacity,
                    am.Baggage_Capacity
                FROM route_schedule rs
                INNER JOIN route r ON rs.Route_ID = r.ID
                INNER JOIN aircraft_model am ON rs.Aircraft_ID = am.ID
                WHERE rs.ID = @FlightID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@FlightID", flightId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new FlightScheduleItem
                {
                    ScheduleId = reader.GetInt32("ScheduleID"),
                    TimeInterval = reader.GetString("Time_Interval"),
                    TakeoffTime = reader.GetDateTime("Takeoff_Time"),
                    LandingTime = reader.GetDateTime("Landing_Time"),
                    RouteName = reader.GetString("RouteName"),
                    AircraftName = reader.GetString("AircraftName"),
                    Capacity = reader.GetInt32("Capacity"),
                    BaggageCapacity = reader.GetInt32("Baggage_Capacity")
                };
            }

            return null;
        }

        public bool AddFlight(int routeId, int aircraftId, int pilotId, DateTime takeoffTime, DateTime landingTime)
        {
            EnsureConnection();

            var query = @"
                INSERT INTO route_schedule (Time_Interval, Route_ID, Aircraft_ID, Landing_Time, Takeoff_Time)
                VALUES (@TimeInterval, @RouteID, @AircraftID, @LandingTime, @TakeoffTime)";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@TimeInterval", $"{takeoffTime:HH:mm} - {landingTime:HH:mm}");
            cmd.Parameters.AddWithValue("@RouteID", routeId);
            cmd.Parameters.AddWithValue("@AircraftID", aircraftId);
            cmd.Parameters.AddWithValue("@TakeoffTime", takeoffTime);
            cmd.Parameters.AddWithValue("@LandingTime", landingTime);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateFlight(int flightId, int routeId, int aircraftId, int pilotId, DateTime takeoffTime, DateTime landingTime)
        {
            EnsureConnection();

            var query = @"
                UPDATE route_schedule 
                SET Time_Interval = @TimeInterval, 
                    Route_ID = @RouteID, 
                    Aircraft_ID = @AircraftID,
                    Takeoff_Time = @TakeoffTime,
                    Landing_Time = @LandingTime
                WHERE ID = @FlightID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@FlightID", flightId);
            cmd.Parameters.AddWithValue("@TimeInterval", $"{takeoffTime:HH:mm} - {landingTime:HH:mm}");
            cmd.Parameters.AddWithValue("@RouteID", routeId);
            cmd.Parameters.AddWithValue("@AircraftID", aircraftId);
            cmd.Parameters.AddWithValue("@TakeoffTime", takeoffTime);
            cmd.Parameters.AddWithValue("@LandingTime", landingTime);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteFlight(int flightId)
        {
            EnsureConnection();

            var query = "DELETE FROM route_schedule WHERE ID = @FlightID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@FlightID", flightId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool AllowTakeoff(int scheduleId, DateTime actualTakeoffTime)
        {
            EnsureConnection();

            var query = @"
                UPDATE route_schedule 
                SET Takeoff_Time = @ActualTime 
                WHERE ID = @ScheduleID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
            cmd.Parameters.AddWithValue("@ActualTime", actualTakeoffTime);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool AllowLanding(int scheduleId, DateTime actualLandingTime)
        {
            EnsureConnection();

            var query = @"
                UPDATE route_schedule 
                SET Landing_Time = @ActualTime 
                WHERE ID = @ScheduleID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
            cmd.Parameters.AddWithValue("@ActualTime", actualLandingTime);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<HangarScheduleItem> GetHangarSchedule()
        {
            EnsureConnection();

            var schedule = new List<HangarScheduleItem>();
            var query = @"
                SELECT 
                    hs.ID AS ScheduleID,
                    hs.Time_Interval,
                    hs.Description,
                    h.Name AS HangarName,
                    ht.Name AS HangarType,
                    sp.Full_Name AS PersonnelName,
                    am.Name AS AircraftName
                FROM hangar_schedule hs
                INNER JOIN hangar h ON hs.Hangar_ID = h.ID
                INNER JOIN hangar_type ht ON h.Type_ID = ht.ID
                INNER JOIN service_personnel sp ON hs.Personnel_ID = sp.ID
                INNER JOIN aircraft_model am ON hs.Aircraft_ID = am.ID
                ORDER BY hs.Time_Interval";

            using var cmd = new MySqlCommand(query, _connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                schedule.Add(new HangarScheduleItem
                {
                    ScheduleId = reader.GetInt32("ScheduleID"),
                    TimeInterval = reader.GetString("Time_Interval"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"),
                    HangarName = reader.GetString("HangarName"),
                    HangarType = reader.GetString("HangarType"),
                    PersonnelName = reader.GetString("PersonnelName"),
                    AircraftName = reader.GetString("AircraftName")
                });
            }

            return schedule;
        }

        public HangarScheduleItem GetHangarScheduleById(int scheduleId)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    hs.ID AS ScheduleID,
                    hs.Time_Interval,
                    hs.Description,
                    h.Name AS HangarName,
                    ht.Name AS HangarType,
                    sp.Full_Name AS PersonnelName,
                    am.Name AS AircraftName
                FROM hangar_schedule hs
                INNER JOIN hangar h ON hs.Hangar_ID = h.ID
                INNER JOIN hangar_type ht ON h.Type_ID = ht.ID
                INNER JOIN service_personnel sp ON hs.Personnel_ID = sp.ID
                INNER JOIN aircraft_model am ON hs.Aircraft_ID = am.ID
                WHERE hs.ID = @ScheduleID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new HangarScheduleItem
                {
                    ScheduleId = reader.GetInt32("ScheduleID"),
                    TimeInterval = reader.GetString("Time_Interval"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"),
                    HangarName = reader.GetString("HangarName"),
                    HangarType = reader.GetString("HangarType"),
                    PersonnelName = reader.GetString("PersonnelName"),
                    AircraftName = reader.GetString("AircraftName")
                };
            }

            return null;
        }

        public bool AddHangarSchedule(string timeInterval, int hangarId, int aircraftId, int personnelId, string description)
        {
            EnsureConnection();

            var query = @"
                INSERT INTO hangar_schedule (Time_Interval, Hangar_ID, Aircraft_ID, Personnel_ID, Description)
                VALUES (@TimeInterval, @HangarID, @AircraftID, @PersonnelID, @Description)";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@TimeInterval", timeInterval);
            cmd.Parameters.AddWithValue("@HangarID", hangarId);
            cmd.Parameters.AddWithValue("@AircraftID", aircraftId);
            cmd.Parameters.AddWithValue("@PersonnelID", personnelId);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateHangarSchedule(int scheduleId, string timeInterval, int hangarId, int aircraftId, int personnelId, string description)
        {
            EnsureConnection();

            var query = @"
                UPDATE hangar_schedule 
                SET Time_Interval = @TimeInterval,
                    Hangar_ID = @HangarID,
                    Aircraft_ID = @AircraftID,
                    Personnel_ID = @PersonnelID,
                    Description = @Description
                WHERE ID = @ScheduleID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
            cmd.Parameters.AddWithValue("@TimeInterval", timeInterval);
            cmd.Parameters.AddWithValue("@HangarID", hangarId);
            cmd.Parameters.AddWithValue("@AircraftID", aircraftId);
            cmd.Parameters.AddWithValue("@PersonnelID", personnelId);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteHangarSchedule(int scheduleId)
        {
            EnsureConnection();

            var query = "DELETE FROM hangar_schedule WHERE ID = @ScheduleID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool MarkHangarScheduleComplete(int scheduleId)
        {
            EnsureConnection();

            var query = "UPDATE hangar_schedule SET Description = CONCAT(Description, ' [ВЫПОЛНЕНО]') WHERE ID = @ScheduleID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<AircraftModel> GetAircraftModels()
        {
            EnsureConnection();

            var aircraft = new List<AircraftModel>();
            var query = @"
                SELECT 
                    ID, Name, Aircraft_Type, Fuselage_Length, Fuselage_Construction,
                    Wing_Span, Height, Weight, Flight_Hours, Reserve, Status, Capacity, Baggage_Capacity
                FROM aircraft_model";

            using var cmd = new MySqlCommand(query, _connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                aircraft.Add(new AircraftModel
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    AircraftType = reader.GetString("Aircraft_Type"),
                    FuselageLength = reader.GetDecimal("Fuselage_Length"),
                    FuselageConstruction = reader.GetString("Fuselage_Construction"),
                    WingSpan = reader.GetDecimal("Wing_Span"),
                    Height = reader.GetDecimal("Height"),
                    Weight = reader.GetDecimal("Weight"),
                    FlightHours = reader.GetInt32("Flight_Hours"),
                    Reserve = reader.GetBoolean("Reserve"),
                    Status = reader.GetString("Status"),
                    Capacity = reader.GetInt32("Capacity"),
                    BaggageCapacity = reader.GetInt32("Baggage_Capacity")
                });
            }

            return aircraft;
        }

        public List<CrewMember> GetCrewMembers(string roleFilter = null)
        {
            EnsureConnection();

            var crew = new List<CrewMember>();
            string query;

            if (string.IsNullOrEmpty(roleFilter))
            {
                query = @"
                    SELECT 
                        c.ID, c.Full_Name, c.Flight_Hours, c.Experience, r.Name AS RoleName
                    FROM crew c
                    INNER JOIN roles r ON c.Role_ID = r.ID";
            }
            else
            {
                query = @"
                    SELECT 
                        c.ID, c.Full_Name, c.Flight_Hours, c.Experience, r.Name AS RoleName
                    FROM crew c
                    INNER JOIN roles r ON c.Role_ID = r.ID
                    WHERE r.Name = @RoleName";
            }

            using var cmd = new MySqlCommand(query, _connection);
            if (!string.IsNullOrEmpty(roleFilter))
            {
                cmd.Parameters.AddWithValue("@RoleName", roleFilter);
            }

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                crew.Add(new CrewMember
                {
                    Id = reader.GetInt32("ID"),
                    FullName = reader.GetString("Full_Name"),
                    FlightHours = reader.GetInt32("Flight_Hours"),
                    ExperienceYears = reader.GetInt32("Experience"),
                    Role = reader.GetString("RoleName")
                });
            }

            return crew;
        }

        public CrewMember GetCrewMemberById(int crewId)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    c.ID, c.Full_Name, c.Flight_Hours, c.Experience, r.Name AS RoleName
                FROM crew c
                INNER JOIN roles r ON c.Role_ID = r.ID
                WHERE c.ID = @CrewID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@CrewID", crewId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new CrewMember
                {
                    Id = reader.GetInt32("ID"),
                    FullName = reader.GetString("Full_Name"),
                    FlightHours = reader.GetInt32("Flight_Hours"),
                    ExperienceYears = reader.GetInt32("Experience"),
                    Role = reader.GetString("RoleName")
                };
            }

            return null;
        }

        public bool AddCrewMember(string fullName, string role, int flightHours, int experience, string login, string password)
        {
            EnsureConnection();

            var roleId = GetRoleIdByName(role);

            var query = @"
                INSERT INTO crew (Full_Name, Flight_Hours, Experience, Role_ID, Login, Password)
                VALUES (@FullName, @FlightHours, @Experience, @RoleID, @Login, @Password)";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@FlightHours", flightHours);
            cmd.Parameters.AddWithValue("@Experience", experience);
            cmd.Parameters.AddWithValue("@RoleID", roleId);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateCrewMember(int crewId, string fullName, string role, int flightHours, int experience, string login, string password)
        {
            EnsureConnection();

            var roleId = GetRoleIdByName(role);

            var query = @"
                UPDATE crew 
                SET Full_Name = @FullName,
                    Flight_Hours = @FlightHours,
                    Experience = @Experience,
                    Role_ID = @RoleID,
                    Login = @Login,
                    Password = @Password
                WHERE ID = @CrewID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@CrewID", crewId);
            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@FlightHours", flightHours);
            cmd.Parameters.AddWithValue("@Experience", experience);
            cmd.Parameters.AddWithValue("@RoleID", roleId);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteCrewMember(int crewId)
        {
            EnsureConnection();

            var query = "DELETE FROM crew WHERE ID = @CrewID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@CrewID", crewId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<Hangar> GetHangars()
        {
            EnsureConnection();

            var hangars = new List<Hangar>();
            var query = @"
                SELECT 
                    h.ID, h.Name, h.Size, ht.Name AS TypeName
                FROM hangar h
                INNER JOIN hangar_type ht ON h.Type_ID = ht.ID";

            using var cmd = new MySqlCommand(query, _connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hangars.Add(new Hangar
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Size = reader.IsDBNull(reader.GetOrdinal("Size")) ? null : reader.GetString("Size"),
                    Type = reader.GetString("TypeName")
                });
            }

            return hangars;
        }

        public Hangar GetHangarById(int hangarId)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    h.ID, h.Name, h.Size, ht.Name AS TypeName
                FROM hangar h
                INNER JOIN hangar_type ht ON h.Type_ID = ht.ID
                WHERE h.ID = @HangarID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@HangarID", hangarId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Hangar
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Size = reader.IsDBNull(reader.GetOrdinal("Size")) ? null : reader.GetString("Size"),
                    Type = reader.GetString("TypeName")
                };
            }

            return null;
        }

        public bool AddHangar(string name, string type, string size)
        {
            EnsureConnection();

            var typeId = GetHangarTypeIdByName(type);

            var query = @"
                INSERT INTO hangar (Name, Type_ID, Size)
                VALUES (@Name, @Type_ID, @Size)";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Type_ID", typeId);
            cmd.Parameters.AddWithValue("@Size", size ?? (object)DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateHangar(int hangarId, string name, string type, string size)
        {
            EnsureConnection();

            var typeId = GetHangarTypeIdByName(type);

            var query = @"
                UPDATE hangar 
                SET Name = @Name,
                    Type_ID = @Type_ID,
                    Size = @Size
                WHERE ID = @HangarID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@HangarID", hangarId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Type_ID", typeId);
            cmd.Parameters.AddWithValue("@Size", size ?? (object)DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteHangar(int hangarId)
        {
            EnsureConnection();

            var checkQuery = "SELECT COUNT(*) FROM equipment WHERE Hangar_ID = @HangarID";
            using (var commnad = new MySqlCommand(checkQuery, _connection))
            {
                commnad.Parameters.AddWithValue("@HangarID", hangarId);
                var equipmentCount = Convert.ToInt32(commnad.ExecuteScalar());

                if (equipmentCount > 0)
                {
                    return false;
                }
            }

            var query = "DELETE FROM hangar WHERE ID = @HangarID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@HangarID", hangarId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<Route> GetRoutes()
        {
            EnsureConnection();

            var routes = new List<Route>();
            var query = "SELECT ID, Name FROM route ORDER BY Name";

            using var cmd = new MySqlCommand(query, _connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                routes.Add(new Route
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name")
                });
            }

            return routes;
        }

        public Route GetRouteById(int routeId)
        {
            EnsureConnection();

            var query = "SELECT ID, Name FROM route WHERE ID = @RouteID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@RouteID", routeId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Route
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name")
                };
            }

            return null;
        }

        public bool AddRoute(string name)
        {
            EnsureConnection();

            var query = "INSERT INTO route (Name) VALUES (@Name)";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@Name", name);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateRoute(int routeId, string name)
        {
            EnsureConnection();

            var query = "UPDATE route SET Name = @Name WHERE ID = @RouteID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@RouteID", routeId);
            cmd.Parameters.AddWithValue("@Name", name);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteRoute(int routeId)
        {
            EnsureConnection();

            var checkQuery = "SELECT COUNT(*) FROM route_schedule WHERE Route_ID = @RouteID";
            using (var commnad = new MySqlCommand(checkQuery, _connection))
            {
                commnad.Parameters.AddWithValue("@RouteID", routeId);
                var scheduleCount = Convert.ToInt32(commnad.ExecuteScalar());

                if (scheduleCount > 0)
                {
                    return false;
                }
            }

            var query = "DELETE FROM route WHERE ID = @RouteID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@RouteID", routeId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<EquipmentItem> GetEquipment()
        {
            EnsureConnection();

            var equipment = new List<EquipmentItem>();
            var query = @"
                SELECT 
                    e.ID,
                    e.Name,
                    e.Description,
                    e.Is_Working,
                    e.Hangar_ID,
                    h.Name AS HangarName
                FROM equipment e
                LEFT JOIN hangar h ON e.Hangar_ID = h.ID
                ORDER BY e.Name";

            using var cmd = new MySqlCommand(query, _connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                equipment.Add(new EquipmentItem
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"),
                    IsWorking = reader.GetBoolean("Is_Working"),
                    HangarId = reader.IsDBNull(reader.GetOrdinal("Hangar_ID")) ? 0 : reader.GetInt32("Hangar_ID"),
                    HangarName = reader.IsDBNull(reader.GetOrdinal("HangarName")) ? "Не назначен" : reader.GetString("HangarName")
                });
            }

            return equipment;
        }

        public EquipmentItem GetEquipmentById(int equipmentId)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    e.ID,
                    e.Name,
                    e.Description,
                    e.Is_Working,
                    e.Hangar_ID,
                    h.Name AS HangarName
                FROM equipment e
                LEFT JOIN hangar h ON e.Hangar_ID = h.ID
                WHERE e.ID = @EquipmentID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@EquipmentID", equipmentId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new EquipmentItem
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"),
                    IsWorking = reader.GetBoolean("Is_Working"),
                    HangarId = reader.IsDBNull(reader.GetOrdinal("Hangar_ID")) ? 0 : reader.GetInt32("Hangar_ID"),
                    HangarName = reader.IsDBNull(reader.GetOrdinal("HangarName")) ? "Не назначен" : reader.GetString("HangarName")
                };
            }

            return null;
        }

        public bool AddEquipment(string name, string description, int hangarId, bool isWorking)
        {
            EnsureConnection();

            var query = @"
                INSERT INTO equipment (Name, Description, Hangar_ID, Is_Working)
                VALUES (@Name, @Description, @HangarID, @IsWorking)";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@HangarID", hangarId);
            cmd.Parameters.AddWithValue("@IsWorking", isWorking);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateEquipment(int equipmentId, string name, string description, int hangarId, bool isWorking)
        {
            EnsureConnection();

            var query = @"
                UPDATE equipment 
                SET Name = @Name, 
                    Description = @Description,
                    Hangar_ID = @HangarID,
                    Is_Working = @IsWorking
                WHERE ID = @EquipmentID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@EquipmentID", equipmentId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@HangarID", hangarId);
            cmd.Parameters.AddWithValue("@IsWorking", isWorking);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteEquipment(int equipmentId)
        {
            EnsureConnection();

            var query = "DELETE FROM equipment WHERE ID = @EquipmentID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@EquipmentID", equipmentId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<SupplyItem> GetSupplies()
        {
            EnsureConnection();

            var checkTable = "SHOW TABLES LIKE 'supplies'";
            using (var commnad = new MySqlCommand(checkTable, _connection))
            {
                using var readerData = commnad.ExecuteReader();
                if (!readerData.Read())
                {
                    CreateSuppliesTable();
                }
                readerData.Close();
            }

            var supplies = new List<SupplyItem>();
            var query = @"
                SELECT 
                    s.ID,
                    s.Name,
                    s.Category,
                    s.Quantity,
                    s.Unit,
                    s.Hangar_ID,
                    h.Name AS HangarName,
                    s.Description
                FROM supplies s
                LEFT JOIN hangar h ON s.Hangar_ID = h.ID
                ORDER BY s.Name";

            using var cmd = new MySqlCommand(query, _connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                supplies.Add(new SupplyItem
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? null : reader.GetString("Category"),
                    Quantity = reader.GetInt32("Quantity"),
                    Unit = reader.IsDBNull(reader.GetOrdinal("Unit")) ? "шт." : reader.GetString("Unit"),
                    HangarId = reader.IsDBNull(reader.GetOrdinal("Hangar_ID")) ? 0 : reader.GetInt32("Hangar_ID"),
                    HangarName = reader.IsDBNull(reader.GetOrdinal("HangarName")) ? "Не назначен" : reader.GetString("HangarName"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description")
                });
            }

            return supplies;
        }

        public SupplyItem GetSupplyById(int supplyId)
        {
            EnsureConnection();

            var query = @"
                SELECT 
                    s.ID,
                    s.Name,
                    s.Category,
                    s.Quantity,
                    s.Unit,
                    s.Hangar_ID,
                    h.Name AS HangarName,
                    s.Description
                FROM supplies s
                LEFT JOIN hangar h ON s.Hangar_ID = h.ID
                WHERE s.ID = @SupplyID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@SupplyID", supplyId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new SupplyItem
                {
                    Id = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? null : reader.GetString("Category"),
                    Quantity = reader.GetInt32("Quantity"),
                    Unit = reader.IsDBNull(reader.GetOrdinal("Unit")) ? "шт." : reader.GetString("Unit"),
                    HangarId = reader.IsDBNull(reader.GetOrdinal("Hangar_ID")) ? 0 : reader.GetInt32("Hangar_ID"),
                    HangarName = reader.IsDBNull(reader.GetOrdinal("HangarName")) ? "Не назначен" : reader.GetString("HangarName"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description")
                };
            }

            return null;
        }

        public bool AddSupply(string name, string category, int quantity, string unit, int hangarId, string description)
        {
            EnsureConnection();

            var query = @"
                INSERT INTO supplies (Name, Category, Quantity, Unit, Hangar_ID, Description)
                VALUES (@Name, @Category, @Quantity, @Unit, @HangarID, @Description)";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Category", category ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Unit", unit ?? "шт.");
            cmd.Parameters.AddWithValue("@HangarID", hangarId);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateSupply(int supplyId, string name, string category, int quantity, string unit, int hangarId, string description)
        {
            EnsureConnection();

            var query = @"
                UPDATE supplies 
                SET Name = @Name, 
                    Category = @Category,
                    Quantity = @Quantity,
                    Unit = @Unit,
                    Hangar_ID = @HangarID,
                    Description = @Description
                WHERE ID = @SupplyID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@SupplyID", supplyId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Category", category ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Unit", unit ?? "шт.");
            cmd.Parameters.AddWithValue("@HangarID", hangarId);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteSupply(int supplyId)
        {
            EnsureConnection();

            var query = "DELETE FROM supplies WHERE ID = @SupplyID";

            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@SupplyID", supplyId);

            return cmd.ExecuteNonQuery() > 0;
        }

        private int GetHangarTypeIdByName(string typeName)
        {
            var query = "SELECT ID FROM hangar_type WHERE Name = @TypeName";
            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@TypeName", typeName);

            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 1;
        }

        private int GetRoleIdByName(string roleName)
        {
            var query = "SELECT ID FROM roles WHERE Name = @RoleName";
            using var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@RoleName", roleName);

            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 4;
        }

        private void CreateSuppliesTable()
        {
            var createTable = @"
                CREATE TABLE IF NOT EXISTS supplies (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Name VARCHAR(255) NOT NULL,
                    Category VARCHAR(100),
                    Quantity INT NOT NULL DEFAULT 0,
                    Unit VARCHAR(50) DEFAULT 'шт.',
                    Hangar_ID INT,
                    Description TEXT,
                    FOREIGN KEY (Hangar_ID) REFERENCES hangar(ID)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";

            using var cmd = new MySqlCommand(createTable, _connection);
            cmd.ExecuteNonQuery();
        }

        private Role MapRoleIdToEnum(int roleId)
        {
            return roleId switch
            {
                1 => Role.Pilot,
                2 => Role.Coordinator,
                3 => Role.Repair,
                4 => Role.Personal,
                _ => Role.Guest
            };
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing && _connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~AirportDbContext()
        {
            Dispose(false);
        }

   

        public class FlightScheduleItem
        {
            public int ScheduleId { get; set; }
            public string TimeInterval { get; set; }
            public DateTime TakeoffTime { get; set; }
            public DateTime LandingTime { get; set; }
            public string RouteName { get; set; }
            public string AircraftName { get; set; }
            public int Capacity { get; set; }
            public int BaggageCapacity { get; set; }
        }

        public class HangarScheduleItem
        {
            public int ScheduleId { get; set; }
            public string TimeInterval { get; set; }
            public string Description { get; set; }
            public string HangarName { get; set; }
            public string HangarType { get; set; }
            public string PersonnelName { get; set; }
            public string AircraftName { get; set; }
        }

        public class AircraftModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string AircraftType { get; set; }
            public decimal FuselageLength { get; set; }
            public string FuselageConstruction { get; set; }
            public decimal WingSpan { get; set; }
            public decimal Height { get; set; }
            public decimal Weight { get; set; }
            public int FlightHours { get; set; }
            public bool Reserve { get; set; }
            public string Status { get; set; }
            public int Capacity { get; set; }
            public int BaggageCapacity { get; set; }
        }

        public class CrewMember
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public int FlightHours { get; set; }
            public int ExperienceYears { get; set; }
            public string Role { get; set; }
        }

        public class Hangar
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Size { get; set; }
            public string Type { get; set; }
        }

        public class Route
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class EquipmentItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int HangarId { get; set; }
            public string HangarName { get; set; }
            public bool IsWorking { get; set; }
        }

        public class SupplyItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public int Quantity { get; set; }
            public string Unit { get; set; }
            public int HangarId { get; set; }
            public string HangarName { get; set; }
            public string Description { get; set; }
        }
    }
}