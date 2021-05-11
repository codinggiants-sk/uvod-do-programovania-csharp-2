using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    //class that manages tasks
    public class TodoTaskManager
    {
        //list of tasks
        private List<TodoTask> _allTasks;

        public TodoTaskManager()
        {
            //create empty list
            _allTasks = new List<TodoTask>();
        }

        //method that searches for task with specified id
        public TodoTask FindTask(int id)
        {
            //loop through all list
            foreach(TodoTask task in _allTasks)
            {
                //if task on the list has the same id
                //as given one, return this task
                if(task.Id == id)
                {
                    return task;
                }
            }
            //if there is no task with given id
            return null;
        }

        //method that adds task to the list
        public void AddTask(TodoTask task)
        {
            _allTasks.Add(task);
            UpdateUserTasks(task.UserId);
        }

        //method that removes task from the list
        public void DeleteTask(int id)
        {
            //first find task with given id
            TodoTask task = FindTask(id);
            _allTasks.Remove(task);
            UpdateUserTasks(task.UserId);
        }

        //method that return all tasks from the list
        //assigned to currently logged user
        public List<TodoTask> GetTasks(Guid userId)
        {
            List<TodoTask> loggedTasks = new List<TodoTask>();
            //find all tasks when UserId == userId
            foreach(TodoTask task in _allTasks)
            {
                if(task.UserId == userId)
                {
                    loggedTasks.Add(task);
                }
            }
            return loggedTasks;
        }

        //method that calculate id for the next task
        public int GetNextId()
        {
            //variable that stores highest id
            int max = 0;
            //loop through all tasks
            foreach(TodoTask task in _allTasks)
            {
                if(task.Id > max)
                {
                    //if task has greater id than max, override highest
                    max = task.Id;
                }
            }
            //id of new task is greater by one
            //from highest id of task on the list
            return max + 1;
        }

        public void LoadUserTasks(Guid userID)
        {
            _allTasks = FileHelper.LoadTasks(userID);
        }

        public void UpdateUserTasks(Guid userID)
        {
            FileHelper.SaveTasks(_allTasks, userID);
        }
    }
}
