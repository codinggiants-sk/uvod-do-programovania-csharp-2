using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    public static class FileHelper
    {
        //variable that stores path to folder, where users data are saved
        private static string _basePath = $@"{AppDomain.CurrentDomain.BaseDirectory}/data/";

        public static List<TodoTask> LoadTasks(Guid userID)
        {
            List<TodoTask> todoTasks = new List<TodoTask>();
            //create path to the file
            string filePath = $@"{_basePath}{userID}.txt";
            //check if such a file even exists
            if (File.Exists(filePath))
            {
                //if file exists, read its content line by line
                StreamReader reader = new StreamReader(filePath);
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    //get task data
                    string[] columns = line.Split('|');
                    int id = int.Parse(columns[0]);
                    string title = columns[1];
                    bool isFinished = bool.Parse(columns[2]);
                    string description = columns[3];
                    //create new task
                    TodoTask task = new TodoTask(id, userID, title, description);
                    task.IsFinished = isFinished;
                    todoTasks.Add(task);
                }
                reader.Close();
            }
            return todoTasks;
        }

        public static void SaveTasks(List<TodoTask> tasks, Guid userID)
        {
            string filePath = $"{_basePath}{userID}.txt";
            //create special object to put strings together
            StringBuilder builder = new StringBuilder();

            foreach(var task in tasks)
            {
                //save each task in separate line
                //columns will be separated with '|' character
                builder.AppendLine($"{task.Id}|{task.Title}|{task.IsFinished}|{task.Description}");
            }
            //save everything in the file
            File.WriteAllText(filePath, builder.ToString());
        }

        public static void SaveUser(User user)
        {
            string filePath = $"{_basePath}users.txt";
            var line = $"{user.Id}|{user.Login}|{user.Password}{Environment.NewLine}";

            if (!Directory.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}/data"))
            {
                Directory.CreateDirectory($@"{AppDomain.CurrentDomain.BaseDirectory}/data");
            }
            File.AppendAllText(filePath, line);
        }

        public static List<User> LoadUsers()
        {
            List<User> appUsers = new List<User>();
            string filePath = $"{_basePath}users.txt";

            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split('|');
                    Guid id = Guid.Parse(columns[0]);
                    string login = columns[1];
                    string name = columns[2];
                    string password = columns[3];
                    User user = new User(id, name, login, password);
                    appUsers.Add(user);
                }
                reader.Close();
            }
            return appUsers;
        }
    }
}
