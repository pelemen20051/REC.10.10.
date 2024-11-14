using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    public class User
    {
        public string ФИО { get; }
        public string Password { get; }
        public string Role { get; }
        public string Предмет { get; }

        public User(string name, string password, string role, string subject)
        {
            ФИО = name;
            Password = password;
            Role = role;
            Предмет = subject; 
        }
    }
}
