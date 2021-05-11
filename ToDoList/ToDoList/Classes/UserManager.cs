using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    //class that manages user
    public class UserManager
    {
        //list of users of program
        //private, because it can be modified only inside this class
        private List<User> _users;

        public UserManager()
        {
            _users = FileHelper.LoadUsers();
        }

        //method FindUser returns user
        //with given login and password
        //if such an user exists on the list
        //if not, method returns null
        //it is used for logging in
        public User FindUser(string login, string password)
        {
            //loop through all list
            foreach(User user in _users)
            {
                //if user on the list has the same login and password
                if(user.Login == login && user.Password == password)
                {
                    //return them
                    return user;
                }
            }
            //if there is no user matched, return null
            return null;
        }

        //method that checks if provided login is free
        //there can't be two users with the same login
        //so we have to check if user with given login
        //exists, before adding new one
        public bool LoginFree(string login)
        {
            //loop through all list
            foreach(User user in _users)
            {
                //if user on the list has given login
                if(user.Login == login)
                {
                    return false;
                }
            }
            //if there is no match, login is free
            return true;
        }

        //users list is private
        //so we need method to add new user to it
        public void AddUser(User user)
        {
            FileHelper.SaveUser(user);
            _users = FileHelper.LoadUsers();
        }
    }
}
