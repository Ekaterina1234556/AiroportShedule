using AiroportShedule.Data;
using AiroportShedule.Models;
using System;

namespace AiroportShedule
{
    public class AppManager
    {
        private static readonly Lazy<AppManager> _instance =
            new Lazy<AppManager>(() => new AppManager());

        public User CurrentUser { get; private set; }

        public string CurrentAirport { get; set; } = "Шереметьево";


        private AppManager()
        {
            CurrentUser = new User
            {
                Id = 0,
                Login = "guest",
                FullName = "Гость",
                Role = Role.Guest
            };
        }

        public static AppManager Instance => _instance.Value;

        public void SetCurrentUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            CurrentUser = user;
        }

        public void Logout()
        {
            CurrentUser = new User
            {
                Id = 0,
                Login = "guest",
                FullName = "Гость",
                Role = Role.Guest
            };
        }

       
    }
}