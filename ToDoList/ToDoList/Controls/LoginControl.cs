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
    public partial class LoginControl : UserControl
    {
        //reference to MainForm
        private MainForm _mainForm;
        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();
            //assign passed argument to variable inside the class
            _mainForm = mainForm;
            //set DockStyle, so screen fill all available area in main form
            Dock = DockStyle.Fill;
        }

        //method called when SignIn button is clicked
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //check if user filled everything
            if(string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                //is something is empty, show validation error
                lblLoginValidation.Visible = true;
                //and set error text
                lblLoginValidation.Text = "Login and password are required";
            } else
            {
                //when user filled everything
                //check if given user exists
                //if not, there will be null
                User user = _mainForm.UserManager.FindUser(tbLogin.Text, tbPassword.Text);
                //if null has been returned, show error
                if(user == null)
                {
                    lblLoginValidation.Visible = true;
                    lblLoginValidation.Text = "Wrong login or password";
                } else //if user exits
                {
                    //navigate to tasks screen
                    //and pass logged user
                    _mainForm.ShowTasksControl(user);
                }
            }
        }
        //method called when SignUp button is clicked
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //call method from MainForm
            //which open register screen
            _mainForm.ShowRegisterControl();
        }
    }
}
