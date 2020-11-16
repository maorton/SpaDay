using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string Username, string Email, string Password)
        {
            username = Username;
            email = Email;
            password = Password;
        }

        public User()
        {

        }
    }

   
}
