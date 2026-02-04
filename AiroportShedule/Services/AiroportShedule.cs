using AiroportShedule.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AiroportShedule.Services
{
    public class AirportService : IDisposable
    {
        private readonly AirportDbContext _dbContext;
        private readonly bool _ownsDbContext;

        public AirportService()
        {
            _dbContext = new AirportDbContext();
            _ownsDbContext = true;
        }

        public AirportService(AirportDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _ownsDbContext = false;
        }

       
        public List<FlightScheduleViewModel> GetFlightSchedule()
        {
            var dbItems = _dbContext.GetFlightSchedule();
            var viewModel = new List<FlightScheduleViewModel>();

            foreach (var item in dbItems)
            {
                viewModel.Add(new FlightScheduleViewModel
                {
                    Id = item.ScheduleId,
                    FlightNumber = $"FL{item.ScheduleId:D4}",
                    Route = item.RouteName,
                    Aircraft = item.AircraftName,
                    DepartureTime = item.TakeoffTime.ToString("HH:mm"),
                    ArrivalTime = item.LandingTime.ToString("HH:mm"),
                    Status = GetFlightStatus(item.TakeoffTime, item.LandingTime),
                    Passengers = item.Capacity,
                    Baggage = $"{item.BaggageCapacity} kg"
                });
            }

            return viewModel;
        }

        public FlightScheduleViewModel GetFlightById(int flightId)
        {
            var dbItem = _dbContext.GetFlightById(flightId);
            if (dbItem == null) return null;

            return new FlightScheduleViewModel
            {
                Id = dbItem.ScheduleId,
                FlightNumber = $"FL{dbItem.ScheduleId:D4}",
                Route = dbItem.RouteName,
                Aircraft = dbItem.AircraftName,
                DepartureTime = dbItem.TakeoffTime.ToString("HH:mm"),
                ArrivalTime = dbItem.LandingTime.ToString("HH:mm"),
                Status = GetFlightStatus(dbItem.TakeoffTime, dbItem.LandingTime),
                Passengers = dbItem.Capacity,
                Baggage = $"{dbItem.BaggageCapacity} kg"
            };
        }

        public bool AddFlight(int routeId, int aircraftId, int pilotId, DateTime takeoffTime, DateTime landingTime)
        {
            return _dbContext.AddFlight(routeId, aircraftId, pilotId, takeoffTime, landingTime);
        }

        public bool UpdateFlight(int flightId, int routeId, int aircraftId, int pilotId, DateTime takeoffTime, DateTime landingTime)
        {
            return _dbContext.UpdateFlight(flightId, routeId, aircraftId, pilotId, takeoffTime, landingTime);
        }

        public bool DeleteFlight(int flightId)
        {
            return _dbContext.DeleteFlight(flightId);
        }

        public bool AllowTakeoff(int scheduleId)
        {
            return _dbContext.AllowTakeoff(scheduleId, DateTime.Now);
        }

        public bool AllowLanding(int scheduleId)
        {
            return _dbContext.AllowLanding(scheduleId, DateTime.Now);
        }

        public List<HangarScheduleViewModel> GetHangarSchedule()
        {
            var dbItems = _dbContext.GetHangarSchedule();
            var viewModel = new List<HangarScheduleViewModel>();

            foreach (var item in dbItems)
            {
                viewModel.Add(new HangarScheduleViewModel
                {
                    Id = item.ScheduleId,
                    TimeInterval = item.TimeInterval,
                    Hangar = $"{item.HangarName} ({item.HangarType})",
                    Aircraft = item.AircraftName,
                    Personnel = item.PersonnelName,
                    Description = item.Description,
                    Status = "Запланировано"
                });
            }

            return viewModel;
        }

        public HangarScheduleViewModel GetHangarScheduleById(int scheduleId)
        {
            var dbItem = _dbContext.GetHangarScheduleById(scheduleId);
            if (dbItem == null) return null;

            return new HangarScheduleViewModel
            {
                Id = dbItem.ScheduleId,
                TimeInterval = dbItem.TimeInterval,
                Hangar = $"{dbItem.HangarName} ({dbItem.HangarType})",
                Aircraft = dbItem.AircraftName,
                Personnel = dbItem.PersonnelName,
                Description = dbItem.Description,
                Status = "Запланировано"
            };
        }

        public bool AddHangarSchedule(string timeInterval, int hangarId, int aircraftId, int personnelId, string description)
        {
            return _dbContext.AddHangarSchedule(timeInterval, hangarId, aircraftId, personnelId, description);
        }

        public bool UpdateHangarSchedule(int scheduleId, string timeInterval, int hangarId, int aircraftId, int personnelId, string description)
        {
            return _dbContext.UpdateHangarSchedule(scheduleId, timeInterval, hangarId, aircraftId, personnelId, description);
        }

        public bool DeleteHangarSchedule(int scheduleId)
        {
            return _dbContext.DeleteHangarSchedule(scheduleId);
        }

        public bool MarkHangarScheduleComplete(int scheduleId)
        {
            return _dbContext.MarkHangarScheduleComplete(scheduleId);
        }

        public List<AircraftViewModel> GetAvailableAircraft()
        {
            var dbAircraft = _dbContext.GetAircraftModels();
            var viewModel = new List<AircraftViewModel>();

            foreach (var aircraft in dbAircraft)
            {
                if (aircraft.Status == "В эксплуатации" && !aircraft.Reserve)
                {
                    viewModel.Add(new AircraftViewModel
                    {
                        Id = aircraft.Id,
                        Model = aircraft.Name,
                        Type = aircraft.AircraftType,
                        Capacity = aircraft.Capacity,
                        BaggageCapacity = aircraft.BaggageCapacity,
                        FlightHours = aircraft.FlightHours,
                        Status = aircraft.Status
                    });
                }
            }

            return viewModel;
        }

        public List<CrewMemberViewModel> GetCrewMembers(string roleFilter = null)
        {
            var dbCrew = _dbContext.GetCrewMembers(roleFilter);
            var viewModel = new List<CrewMemberViewModel>();

            foreach (var member in dbCrew)
            {
                viewModel.Add(new CrewMemberViewModel
                {
                    Id = member.Id,
                    FullName = member.FullName,
                    Role = member.Role,
                    FlightHours = member.FlightHours,
                    ExperienceYears = member.ExperienceYears
                });
            }

            return viewModel;
        }

        public CrewMemberViewModel GetCrewMemberById(int crewId)
        {
            var dbCrew = _dbContext.GetCrewMemberById(crewId);
            if (dbCrew == null) return null;

            return new CrewMemberViewModel
            {
                Id = dbCrew.Id,
                FullName = dbCrew.FullName,
                Role = dbCrew.Role,
                FlightHours = dbCrew.FlightHours,
                ExperienceYears = dbCrew.ExperienceYears
            };
        }

        public bool AddCrewMember(string fullName, string role, int flightHours, int experience, string login, string password)
        {
            return _dbContext.AddCrewMember(fullName, role, flightHours, experience, login, password);
        }

        public bool UpdateCrewMember(int crewId, string fullName, string role, int flightHours, int experience, string login, string password)
        {
            return _dbContext.UpdateCrewMember(crewId, fullName, role, flightHours, experience, login, password);
        }

        public bool DeleteCrewMember(int crewId)
        {
            return _dbContext.DeleteCrewMember(crewId);
        }

        public List<HangarViewModel> GetHangars()
        {
            var dbHangars = _dbContext.GetHangars();
            var viewModel = new List<HangarViewModel>();

            foreach (var hangar in dbHangars)
            {
                viewModel.Add(new HangarViewModel
                {
                    Id = hangar.Id,
                    Name = hangar.Name,
                    Size = hangar.Size,
                    Type = hangar.Type
                });
            }

            return viewModel;
        }

        public HangarViewModel GetHangarById(int hangarId)
        {
            var dbHangar = _dbContext.GetHangarById(hangarId);
            if (dbHangar == null) return null;

            return new HangarViewModel
            {
                Id = dbHangar.Id,
                Name = dbHangar.Name,
                Size = dbHangar.Size,
                Type = dbHangar.Type
            };
        }

        public bool AddHangar(string name, string type, string size)
        {
            return _dbContext.AddHangar(name, type, size);
        }

        public bool UpdateHangar(int hangarId, string name, string type, string size)
        {
            return _dbContext.UpdateHangar(hangarId, name, type, size);
        }

        public bool DeleteHangar(int hangarId)
        {
            return _dbContext.DeleteHangar(hangarId);
        }

        public List<RouteViewModel> GetRoutes()
        {
            var dbRoutes = _dbContext.GetRoutes();
            var viewModel = new List<RouteViewModel>();

            foreach (var route in dbRoutes)
            {
                viewModel.Add(new RouteViewModel
                {
                    Id = route.Id,
                    Name = route.Name
                });
            }

            return viewModel;
        }

        public RouteViewModel GetRouteById(int routeId)
        {
            var dbRoute = _dbContext.GetRouteById(routeId);
            if (dbRoute == null) return null;

            return new RouteViewModel
            {
                Id = dbRoute.Id,
                Name = dbRoute.Name
            };
        }

        public bool AddRoute(string name)
        {
            return _dbContext.AddRoute(name);
        }

        public bool UpdateRoute(int routeId, string name)
        {
            return _dbContext.UpdateRoute(routeId, name);
        }

        public bool DeleteRoute(int routeId)
        {
            return _dbContext.DeleteRoute(routeId);
        }

        public List<EquipmentViewModel> GetEquipment()
        {
            var dbItems = _dbContext.GetEquipment();
            var viewModel = new List<EquipmentViewModel>();

            foreach (var item in dbItems)
            {
                viewModel.Add(new EquipmentViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    HangarId = item.HangarId,
                    HangarName = item.HangarName,
                    IsWorking = item.IsWorking
                });
            }

            return viewModel;
        }

        public EquipmentViewModel GetEquipmentById(int equipmentId)
        {
            var dbItem = _dbContext.GetEquipmentById(equipmentId);
            if (dbItem == null) return null;

            return new EquipmentViewModel
            {
                Id = dbItem.Id,
                Name = dbItem.Name,
                Description = dbItem.Description,
                HangarId = dbItem.HangarId,
                HangarName = dbItem.HangarName,
                IsWorking = dbItem.IsWorking
            };
        }

        public bool AddEquipment(string name, string description, int hangarId, bool isWorking)
        {
            return _dbContext.AddEquipment(name, description, hangarId, isWorking);
        }

        public bool UpdateEquipment(int equipmentId, string name, string description, int hangarId, bool isWorking)
        {
            return _dbContext.UpdateEquipment(equipmentId, name, description, hangarId, isWorking);
        }

        public bool DeleteEquipment(int equipmentId)
        {
            return _dbContext.DeleteEquipment(equipmentId);
        }

        public List<SupplyViewModel> GetSupplies()
        {
            var dbItems = _dbContext.GetSupplies();
            var viewModel = new List<SupplyViewModel>();

            foreach (var item in dbItems)
            {
                viewModel.Add(new SupplyViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Category = item.Category,
                    Quantity = item.Quantity,
                    Unit = item.Unit,
                    HangarId = item.HangarId,
                    HangarName = item.HangarName,
                    Description = item.Description
                });
            }

            return viewModel;
        }

        public SupplyViewModel GetSupplyById(int supplyId)
        {
            var dbItem = _dbContext.GetSupplyById(supplyId);
            if (dbItem == null) return null;

            return new SupplyViewModel
            {
                Id = dbItem.Id,
                Name = dbItem.Name,
                Category = dbItem.Category,
                Quantity = dbItem.Quantity,
                Unit = dbItem.Unit,
                HangarId = dbItem.HangarId,
                HangarName = dbItem.HangarName,
                Description = dbItem.Description
            };
        }

        public bool AddSupply(string name, string category, int quantity, string unit, int hangarId, string description)
        {
            return _dbContext.AddSupply(name, category, quantity, unit, hangarId, description);
        }

        public bool UpdateSupply(int supplyId, string name, string category, int quantity, string unit, int hangarId, string description)
        {
            return _dbContext.UpdateSupply(supplyId, name, category, quantity, unit, hangarId, description);
        }

        public bool DeleteSupply(int supplyId)
        {
            return _dbContext.DeleteSupply(supplyId);
        }

        private string GetFlightStatus(DateTime takeoff, DateTime landing)
        {
            var now = DateTime.Now;
            if (now < takeoff.AddMinutes(-15)) return "Ожидание";
            if (now >= takeoff.AddMinutes(-15) && now < takeoff) return "Посадка пассажиров";
            if (now >= takeoff && now < landing) return "В полёте";
            if (now >= landing) return "Прибыл";
            return "Запланирован";
        }

        public void Dispose()
        {
            if (_ownsDbContext)
            {
                _dbContext?.Dispose();
            }
        }

        public class FlightScheduleViewModel
        {
            public int Id { get; set; }
            public string FlightNumber { get; set; }
            public string Route { get; set; }
            public string Aircraft { get; set; }
            public string DepartureTime { get; set; }
            public string ArrivalTime { get; set; }
            public string Status { get; set; }
            public int Passengers { get; set; }
            public string Baggage { get; set; }
        }

        public class HangarScheduleViewModel
        {
            public int Id { get; set; }
            public string TimeInterval { get; set; }
            public string Hangar { get; set; }
            public string Aircraft { get; set; }
            public string Personnel { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
        }

        public class AircraftViewModel
        {
            public int Id { get; set; }
            public string Model { get; set; }
            public string Type { get; set; }
            public int Capacity { get; set; }
            public int BaggageCapacity { get; set; }
            public int FlightHours { get; set; }
            public string Status { get; set; }
        }

        public class CrewMemberViewModel
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Role { get; set; }
            public int FlightHours { get; set; }
            public int ExperienceYears { get; set; }
        }

        public class HangarViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Size { get; set; }
            public string Type { get; set; }
        }

        public class RouteViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class EquipmentViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int HangarId { get; set; }
            public string HangarName { get; set; }
            public bool IsWorking { get; set; }
        }

        public class SupplyViewModel
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