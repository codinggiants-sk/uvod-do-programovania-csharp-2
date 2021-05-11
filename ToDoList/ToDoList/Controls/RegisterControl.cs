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

namespace ToDoList.Controls
{
    public partial class RegisterControl : UserControl
    {
        //reference to MainForm
        private MainForm _mainForm;
        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();
            //assign passed argument to variable inside the class
            _mainForm = mainForm;
            //set DockStyle, so screen fill all available area in main form
            Dock = DockStyle.Fill;
        }

        //method called when Back button is clicked
        private void btnBack_Click(object sender, EventArgs e)
        {
            //call method from MainForm
            //which open login screen
            _mainForm.ShowLoginControl();
        }
        //method called when SignUp button is clicked
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //create new user
                User newUser = new User(Guid.NewGuid(), tbName.Text, tbLogin.Text, tbPassword.Text);
                //add new user to the list of users
                _mainForm.UserManager.AddUser(newUser);
                //call method from MainForm
                //which open tasks screen
                //when user is signed up, they will be logged automatically
                _mainForm.ShowTasksControl(newUser);
            }
        }
        //additional method
        private bool ValidateForm()
        {
            //hide all validation labels
            lblLoginValid.Visible = false;
            lblNameValid.Visible = false;
            lblPasswordValid.Visible = false;
            lblRepeatPasswordValid.Visible = false;

            //helper variable that determines
            //if everything is correct
            bool allCorrect = true;

            //check name
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                lblNameValid.Text = "Name is required";
                lblNameValid.Visible = true;
                allCorrect = false;
            }
            //check login
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                lblLoginValid.Text = "Login is required";
                lblLoginValid.Visible = true;
                allCorrect = false;
            }
            //and if login is free
            else if (!_mainForm.UserManager.LoginFree(tbLogin.Text))
            {
                lblLoginValid.Text = "This login is in use";
                lblLoginValid.Visible = true;
                allCorrect = false;
            }
            //check password
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                lblPasswordValid.Text = "Password is required";
                lblPasswordValid.Visible = true;
                allCorrect = false;
            }
            //check repeat password
            if (string.IsNullOrWhiteSpace(tbRepeatPassword.Text))
            {
                lblRepeatPasswordValid.Text = "Repeat the password";
                lblRepeatPasswordValid.Visible = true;
                allCorrect = false;
            }
            //are passwords the same, if both are filled
            if(!string.IsNullOrWhiteSpace(tbPassword.Text) && !string.IsNullOrWhiteSpace(tbRepeatPassword.Text))
            {
                if(tbPassword.Text != tbRepeatPassword.Text)
                {
                    lblRepeatPasswordValid.Text = "Provided passwords differ";
                    lblRepeatPasswordValid.Visible = true;
                    allCorrect = false;
                }
            }

            return allCorrect;
        }
    }
}
