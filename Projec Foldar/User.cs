using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finite_Automata
{
    public class User
    {
        public User(string username, string password, string ip, DateTime registrationTime, DateTime lastLoginTime, int countLogin) 
        {
            Username = username;
            Password = password;
            IP = ip;
            RegistrationTime = registrationTime;
            LastLoginTime = lastLoginTime;
            CountLogin = countLogin;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string IP { get; set; }
        public DateTime RegistrationTime { get; set; }
        public DateTime LastLoginTime { get; set; }
        public int CountLogin { get; set; }
    }
}
