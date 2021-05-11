
namespace ToDoList.Controls
{
    partial class RegisterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.lblRepeatPasswordValid = new System.Windows.Forms.Label();
            this.lblPasswordValid = new System.Windows.Forms.Label();
            this.lblLoginValid = new System.Windows.Forms.Label();
            this.lblNameValid = new System.Windows.Forms.Label();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(159, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registration";
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.lblRepeatPasswordValid);
            this.groupBoxUserData.Controls.Add(this.lblPasswordValid);
            this.groupBoxUserData.Controls.Add(this.lblLoginValid);
            this.groupBoxUserData.Controls.Add(this.lblNameValid);
            this.groupBoxUserData.Controls.Add(this.tbRepeatPassword);
            this.groupBoxUserData.Controls.Add(this.tbPassword);
            this.groupBoxUserData.Controls.Add(this.tbLogin);
            this.groupBoxUserData.Controls.Add(this.tbName);
            this.groupBoxUserData.Controls.Add(this.lblRepeatPassword);
            this.groupBoxUserData.Controls.Add(this.lblPassword);
            this.groupBoxUserData.Controls.Add(this.lblLogin);
            this.groupBoxUserData.Controls.Add(this.lblName);
            this.groupBoxUserData.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxUserData.Location = new System.Drawing.Point(20, 107);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Size = new System.Drawing.Size(458, 412);
            this.groupBoxUserData.TabIndex = 1;
            this.groupBoxUserData.TabStop = false;
            this.groupBoxUserData.Text = "New user data";
            // 
            // lblRepeatPasswordValid
            // 
            this.lblRepeatPasswordValid.AutoSize = true;
            this.lblRepeatPasswordValid.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPasswordValid.ForeColor = System.Drawing.Color.Red;
            this.lblRepeatPasswordValid.Location = new System.Drawing.Point(186, 347);
            this.lblRepeatPasswordValid.Name = "lblRepeatPasswordValid";
            this.lblRepeatPasswordValid.Size = new System.Drawing.Size(123, 24);
            this.lblRepeatPasswordValid.TabIndex = 11;
            this.lblRepeatPasswordValid.Text = "Validation label";
            this.lblRepeatPasswordValid.Visible = false;
            // 
            // lblPasswordValid
            // 
            this.lblPasswordValid.AutoSize = true;
            this.lblPasswordValid.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordValid.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValid.Location = new System.Drawing.Point(186, 262);
            this.lblPasswordValid.Name = "lblPasswordValid";
            this.lblPasswordValid.Size = new System.Drawing.Size(123, 24);
            this.lblPasswordValid.TabIndex = 10;
            this.lblPasswordValid.Text = "Validation label";
            this.lblPasswordValid.Visible = false;
            // 
            // lblLoginValid
            // 
            this.lblLoginValid.AutoSize = true;
            this.lblLoginValid.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginValid.ForeColor = System.Drawing.Color.Red;
            this.lblLoginValid.Location = new System.Drawing.Point(186, 176);
            this.lblLoginValid.Name = "lblLoginValid";
            this.lblLoginValid.Size = new System.Drawing.Size(123, 24);
            this.lblLoginValid.TabIndex = 9;
            this.lblLoginValid.Text = "Validation label";
            this.lblLoginValid.Visible = false;
            // 
            // lblNameValid
            // 
            this.lblNameValid.AutoSize = true;
            this.lblNameValid.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValid.ForeColor = System.Drawing.Color.Red;
            this.lblNameValid.Location = new System.Drawing.Point(186, 96);
            this.lblNameValid.Name = "lblNameValid";
            this.lblNameValid.Size = new System.Drawing.Size(123, 24);
            this.lblNameValid.TabIndex = 8;
            this.lblNameValid.Text = "Validation label";
            this.lblNameValid.Visible = false;
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepeatPassword.Location = new System.Drawing.Point(196, 307);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.PasswordChar = '*';
            this.tbRepeatPassword.Size = new System.Drawing.Size(231, 37);
            this.tbRepeatPassword.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(196, 222);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(231, 37);
            this.tbPassword.TabIndex = 6;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(196, 136);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(231, 37);
            this.tbLogin.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(196, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(231, 37);
            this.tbName.TabIndex = 4;
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPassword.Location = new System.Drawing.Point(6, 313);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(184, 33);
            this.lblRepeatPassword.TabIndex = 3;
            this.lblRepeatPassword.Text = "Repeat password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(75, 226);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(115, 33);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(111, 139);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(79, 33);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(112, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightGreen;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(125, 534);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(246, 86);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(20, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 68);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "🢨";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.lblTitle);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.groupBoxUserData.ResumeLayout(false);
            this.groupBoxUserData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRepeatPasswordValid;
        private System.Windows.Forms.Label lblPasswordValid;
        private System.Windows.Forms.Label lblLoginValid;
        private System.Windows.Forms.Label lblNameValid;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBack;
    }
}
