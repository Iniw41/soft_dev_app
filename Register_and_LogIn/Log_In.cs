using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Chat_Box;
using Microsoft.Data.SqlClient;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Chat_Box.NVVM.View_Model;



namespace Register_and_LogIn
{
    public partial class Log_In : Form
    {
        private string connectionString = "Server=INIW;Database=Iniw_Chat_DB;Trusted_Connection=True;TrustServerCertificate=True;";

        bool mouseDown;
        private System.Drawing.Point lastLocation;
        public Log_In()
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
                this.Location = new System.Drawing.Point(
                        (this.Location.X - lastLocation.X) + e.X,
                        (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Register_text_click_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register_window = new Register();
            register_window.Show();
        }

        private void Forgot_Pass_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forget_Password forgot_password_window = new Forget_Password();
            forgot_password_window.Show();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text.Trim();
            string password = password_textbox.Text;


            // Hash the password
            byte[] passwordHash = HashPassword(password);

            bool isAuthenticated = AuthenticateUser(username, passwordHash);

            if (isAuthenticated)
            {
                string email = "";
                int age = 0;
                using (var conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
            SELECT email, age FROM Users
            WHERE username = @username";
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        email = reader.GetString(0);
                        age = reader.GetInt32(1);
                    }
                    reader.Close();
                }
                this.Hide();
                Account_Settings account_Settings = new Account_Settings(username, email, age);
                if (System.Windows.Application.Current == null)
                {
                    var app = new Chat_Box.App();
                    app.InitializeComponent(); // Loads App.xaml resources
                    Chat_Box.MainWindow wpfWindow = new Chat_Box.MainWindow(username, email, age);
                    var vm = wpfWindow.DataContext as MainViewModel;
                    if (vm !=  null)
                    {
                        vm.username = username;
                        vm.Email = email;
                        vm.Age = age;
                    }
                    app.Run(wpfWindow);
                }
            }
            else 
            {
                System.Windows.MessageBox.Show("Invalid username or password.");
            }

        }

        private bool AuthenticateUser(string username, byte[] passwordHash)
        {
            using (var conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT COUNT(*) FROM Users
                    WHERE username = @username AND password_hash = @passwordHash";

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@passwordHash", passwordHash);

                conn.Open();
                int matchCount = (int)cmd.ExecuteScalar();

                return matchCount > 0;
            }
        }

        private byte[] HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }


    }
}
