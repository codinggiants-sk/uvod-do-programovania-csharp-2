using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppScreenSaver
{
    public partial class Screensaver : Form
    {
        private int x, y; // variable for storing cursor position
        private string[] pictures; // array of pictures
        private int number_of_pictures; // number of loaded pictures
        private int picture_number; // number of current loaded picture


        public Screensaver()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.None;
            number_of_pictures = 0;
            picture_number = 0;
        }

        private void Screensaver_Load(object sender, EventArgs e)
        {
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            string folder = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"..\..\pictures";
            //string parentFolder = System.IO.Directory.GetParent();
           
            //MessageBox.Show(parentFolder);
             //MessageBox.Show(folder);

            try
            {
                pictures = Directory.GetFiles(folder);
            } catch (Exception)
            {
                MessageBox.Show("Error while downloading pictures");
                Application.Exit();
            }

            number_of_pictures = pictures.Length;

            if (number_of_pictures == 0)
            {
                MessageBox.Show("No pictures in screensaver");
                Application.Exit();
            }

            BackgroundImage = Image.FromFile(pictures[picture_number]);
            Cursor.Hide();
            WindowState = FormWindowState.Maximized;
            timer.Start();
        }

        private void Screensaver_MouseMove(object sender, MouseEventArgs e)
        {
            int deltaX = Math.Abs(e.X - x);
            int deltaY = Math.Abs(e.Y - y);

            if (deltaX > 10 && deltaY > 10)
            {
                Application.Exit();
            }
        }

        private void Screensaver_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Screensaver_MouseClick");
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // MessageBox.Show(pictures[picture_number++]);
                BackgroundImage = Image.FromFile(pictures[picture_number++]);
                if (picture_number >= number_of_pictures)
                {
                    picture_number = 0;
                }
            } catch (Exception)
            {
                MessageBox.Show("Error while downloading a file");
            }
        }

        private void Screensaver_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Screensaver_KeyDown");
            Application.Exit();
        }
    }
}
