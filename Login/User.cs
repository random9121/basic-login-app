using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class User
    {

        private string AdminUser = "randomperson";
        private string AdminPassword = "12345";
        private string AdminName = "randomness";
        private bool Adminbool = true;
        private string username;
        private string password;
        private bool isAdmin;
        private string name;

       
        public string adminusercheck
        {
            get { return AdminUser; }

        }
        public string Adminpasscheck
        {
            get { return AdminPassword; }
        }

        // sets username to the username that was given
        // gets the username
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        // sets password to the password that was given
        // gets the password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //sets isAdmin to the bool that was given
        // gets isAdmin
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        //sets name to the name that was given
        // gets the name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // default constructor for this class
        public User()
        {
            Username = "Invalid";
            Password = "Invalid";
            Name = "Invalid";
            IsAdmin = false;
        }

        // constructor for admin to make a new user --- Not Yet Implemented
        public User(string username, string password, string name, bool isAdmin)
        {
            Username = username;
            Password = password;
            Name = name;
            IsAdmin = isAdmin;
        }


    }
}
