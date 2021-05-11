using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    public class TodoTask
    {
        public int Id;
        public Guid UserId;
        public string Title;
        public string Description;
        public bool IsFinished;

        public TodoTask(int number, Guid userId, string title, string desc)
        {
            Id = number;
            UserId = userId;
            Title = title;
            Description = desc;
            IsFinished = false;
        }
    }
}
