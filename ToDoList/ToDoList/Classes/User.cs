using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    //class that stores user data
    public class User
    {
        //unique ID will be used to
        //recognize user
        //remind students what this data type is
        public Guid Id;
        public string Name;
        public string Login;
        public string Password;

        public User(Guid id, string name, string login, string password)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
        }
    }
}
