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
using ToDoList.Forms;

namespace ToDoList.Controls
{
    public partial class TasksControl : UserControl
    {
        //reference to MainForm
        private MainForm _mainForm;
        //variable for logged in user
        private User _logged;
        //variable for storing Tasks Manager
        private TodoTaskManager _todoTaskManager;

        public TasksControl(MainForm mainForm, User user)
        {
            InitializeComponent();
            //assign passed argument to variable inside the class
            _mainForm = mainForm;
            //set DockStyle, so screen fill all available area in main form
            Dock = DockStyle.Fill;

            //assign provided user to variable
            _logged = user;
            //show user name in the label
            lblLoggedUser.Text = _logged.Name;

            //initialize task manager object
            _todoTaskManager = new TodoTaskManager();
            //load user's tasks from file
            _todoTaskManager.LoadUserTasks(_logged.Id);
            //display tasks on the list
            foreach(TodoTask task in _todoTaskManager.GetTasks(_logged.Id))
            {
                AddTaskToList(task);
            }
        }

        //method that adds task to the list in the ListView control
        private void AddTaskToList(TodoTask task)
        {
            //ListView control displays elements of ListViewItem type
            //define first column by creating object
            ListViewItem item = new ListViewItem(task.Id.ToString());
            //next columns will be added as additional elements
            item.SubItems.Add(task.Title);
            //determine icon to display
            //if task is completed display tick
            //if not, cross
            string ready = task.IsFinished ? "✓" : "✕";
            item.SubItems.Add(ready);

            //add element to tasks list
            lvTasks.Items.Add(item);
        }

        //method called when LogOut button is clicked
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //call method from MainForm
            //which open login screen
            _mainForm.ShowLoginControl();
        }
        //method called when Add button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //determine new task id
            int id = _todoTaskManager.GetNextId();
            //create task with new id and user id
            //title and description is empty yet
            TodoTask newTask = new TodoTask(id, _logged.Id, "", "");
            //create form with task details
            TaskDetails detailsForm = new TaskDetails(newTask);
            //show form as the dialog
            detailsForm.ShowDialog();

            //when dialog is closed check, if tash has been saved
            if (detailsForm.IsSaved)
            {
                //if so, add task to the list
                _todoTaskManager.AddTask(newTask);
                //and display it
                AddTaskToList(newTask);
            }
        }
        //method called when Edit button is clicked
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //check if any task is selected
            if(lvTasks.SelectedItems.Count == 0)
            {
                //if nothing is selected, show error
                MessageBox.Show("Select some task first", "Info", MessageBoxButtons.OK);
            } else
            {
                //get id of selected task - tha same way as when removing
                string taskId = lvTasks.SelectedItems[0].SubItems[0].Text;
                //find task by id
                TodoTask task = _todoTaskManager.FindTask(int.Parse(taskId));
                //display form and pass the task
                TaskDetails detailsForm = new TaskDetails(task);
                detailsForm.ShowDialog();

                //if task has been modified
                if (detailsForm.IsSaved)
                {
                    //update tasks in the file
                    _todoTaskManager.UpdateUserTasks(_logged.Id);
                    //update title and is finished
                    lvTasks.SelectedItems[0].SubItems[1].Text = task.Title;
                    lvTasks.SelectedItems[0].SubItems[2].Text = task.IsFinished ? "✓" : "✕";
                }
            }
        }
        //method called when Remove button is clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check if any task on the list is selected
            if(lvTasks.SelectedItems.Count == 0)
            {
                //nothing is selected, show error
                MessageBox.Show("Task to remove is not selected.", "Info", MessageBoxButtons.OK);
            }
            else
            {
                //from the first selected task
                //(it is impossible to select more than one task
                //because we had configured list this way)
                //get first column (i.e. id)
                string selectedTask = lvTasks.SelectedItems[0].SubItems[0].Text;
                //pass remove request to the task manager
                _todoTaskManager.DeleteTask(int.Parse(selectedTask));
                //also remove task from the control's list
                lvTasks.Items.Remove(lvTasks.SelectedItems[0]);
            }
        }
    }
}
