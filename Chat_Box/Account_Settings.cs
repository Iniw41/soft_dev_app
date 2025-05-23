using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Register_and_LogIn;
using Microsoft.Data.SqlClient;


namespace Chat_Box
{
    public partial class Account_Settings : Form
    {
        private string connectionString = "Server=INIW;Database=Iniw_Chat_DB;Trusted_Connection=True;TrustServerCertificate=True;";
        private string _username;
        private string _email;
        private int _age;
        private string _password;

        bool mouseDown;
        private System.Drawing.Point lastLocation;
        public Account_Settings(string username, string email, int age, string password)
        {
            InitializeComponent();
            _username = username;
            _email = email;
            _age = age;
            _password = password;

            Username_info_text.Text = _username;
            Email_info_text.Text = _email;
            Age_info_text.Text = _age.ToString();
        }

        private void Go_forget_password_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forget_Password forget_password_window = new Forget_Password(_password, _username);
            forget_password_window.Show();

        }

        private void Go_back_click_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (System.Windows.Application.Current == null)
            {
                var app = new Chat_Box.App();
                app.InitializeComponent(); // Loads App.xaml resources
                Chat_Box.MainWindow wpfWindow = new Chat_Box.MainWindow(_username, _email, _age, _password);
                app.Run(wpfWindow);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void change_username_btn_Click(object sender, EventArgs e)
        {
            var new_username = change_username_textbox.Text;
            if (string.IsNullOrEmpty(new_username))
            {
                System.Windows.MessageBox.Show("Please enter a new username.");
                return;
            }

            string old_username = _username;

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                UPDATE Users
                SET username = @username
                WHERE username = @oldusername";

                cmd.Parameters.AddWithValue("@username", new_username);
                cmd.Parameters.AddWithValue("@oldUsername", old_username);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    System.Windows.MessageBox.Show("Username updated successfully.");
                    _username = new_username; // Update the local field if needed
                    this.Close();
                }
                else
                {
                    System.Windows.MessageBox.Show("Faild to update Username");
                }
            }
        }
        private void Delete_account_Click(object sender, EventArgs e)
        {
            var result = System.Windows.MessageBox.Show(
        "Are you sure you want to delete your account?",
        "Confirm Delete",
        MessageBoxButton.OKCancel,
        MessageBoxImage.Warning);

            if (result == MessageBoxResult.OK)
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Users WHERE username = @username";
                    cmd.Parameters.AddWithValue("@username", _username);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        System.Windows.MessageBox.Show("Account deleted successfully.");
                        this.Close();
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Failed to delete account.");
                    }
                }
            }
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
                this.Location = new System.Drawing.Point(
                        (this.Location.X - lastLocation.X) + e.X,
                        (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
