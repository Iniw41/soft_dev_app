using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_and_LogIn
{
    public partial class Register : Form
    {
        private string username;
        private string password;
        private string confirmPassword;
        private int age;
        private string email;

        string connectionString = @"Data Source=DESKTOP-8GQK0A1\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True";


        bool mouseDown;
        private Point lastLocation;

        public Register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X,
                        (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Go_back_click_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In LogIn_Window = new Log_In();
            LogIn_Window.Show();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            username = username_textbox.Text;
            password = password_textbox.Text;
            if (password != conf_pass_textbox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            else
            {
                age = Convert.ToInt32(age_textbox.Text);
                email = email_textbox.Text;
            }
        }

        private void age_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if  ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
