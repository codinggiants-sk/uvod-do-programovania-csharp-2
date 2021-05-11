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
using ToDoList.Controls;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        public UserManager UserManager;
        public MainForm()
        {
            InitializeComponent();
            UserManager = new UserManager();
            //when program starts, show login panel
            ShowLoginControl();
        }

        //method that shows login screen
        public void ShowLoginControl()
        {
            //remove all controls from the form
            Controls.Clear();
            //create new object of LoginControl
            //to its constructor the form will be passed using 'this' keyword
            //because we currently inside main form class
            // and 'this' relates to object we are currently inside
            //newly created object add to form's controls
            Controls.Add(new LoginControl(this));
        }

        //method that shows register screen
        public void ShowRegisterControl()
        {
            //remove all controls from the form
            Controls.Clear();
            //create new object of LoginControl
            //to its constructor the form will be passed using 'this' keyword
            //because we currently inside main form class
            // and 'this' relates to object we are currently inside
            //newly created object add to form's controls
            Controls.Add(new RegisterControl(this));
        }

        //method that shows tasks screen
        public void ShowTasksControl(User user)
        {
            //remove all controls from the form
            Controls.Clear();
            //create new object of LoginControl
            //to its constructor the form will be passed using 'this' keyword
            //because we currently inside main form class
            // and 'this' relates to object we are currently inside
            //newly created object add to form's controls
            Controls.Add(new TasksControl(this, user));
        }
    }
}
