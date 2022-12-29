using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.model
{
    public class User
    {
        string username;
        string password;

        public User(string Username, string Password) {
            username = Username;
            password = Password;
        }
        public string getUsername() { return username; }
        public string getPassword() { return password; }
        public void setUsername(string Username) { username = Username;}
        public void setPassword(string Password) { password= Password;}
    }
}
