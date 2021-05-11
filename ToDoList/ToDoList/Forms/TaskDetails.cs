using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Classes;

namespace ToDoList.Forms
{
    public partial class TaskDetails : Form
    {
        public TodoTask TodoTask;
        public bool IsSaved;

        public TaskDetails(TodoTask task)
        {
            InitializeComponent();
            TodoTask = task;
            lblNumber.Text = task.Id.ToString();
            tbTitle.Text = task.Title;
            tbDescription.Text = task.Description;
            cbIsFinished.Checked = task.IsFinished;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TodoTask.Description = tbDescription.Text;
            TodoTask.Title = tbTitle.Text;
            TodoTask.IsFinished = cbIsFinished.Checked;
            IsSaved = true;
            Close();
        }
    }
}
