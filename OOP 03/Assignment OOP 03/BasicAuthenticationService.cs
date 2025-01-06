using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Assignment_OOP_03
{
    internal class BasicAuthenticationService : IAuthenticationService
    {

        private string UserName = "Mohamed";
        private string Password = "Mohamed";
        private string Role = "Admin";
        public bool AuthenticateUser(string username, string password)
        {
            if (username == UserName && password == Password)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == UserName && role == Role)
            {
                return true;
            }
            return false;
        }
    }
}
