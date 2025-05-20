using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Register_and_LogIn
{
    public partial class Register : Form
    {

        private string confirmPassword;


        




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
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            bool isValidEmail = Regex.IsMatch(email_textbox.Text, pattern);
            bool allowed = true;

            var username = username_textbox.Text.Trim();
            var password = password_textbox.Text;
            if (password != conf_pass_textbox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            else
            {
                // Hash the password (example using SHA256)
                byte[] passwordHash;
                using (var sha = System.Security.Cryptography.SHA256.Create())
                {
                    passwordHash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                }
                int age = Convert.ToInt32(age_textbox.Text);
                if (isValidEmail)
                {
                    var email = email_textbox.Text.Trim();
                    if (allowed)
                    {
                        try
                        {
                            string connectionString = @"Server=INIW;Database=Iniw_Chat_DB;Trusted_Connection=True;";

                            using (var connect = new SqlConnection(connectionString))
                            using (var cmd = connect.CreateCommand())
                            {
                                cmd.CommandText = @"
                                INSERT INTO Users (username, password_hash, email, age)
                                VALUES (@u, @p, @e, @a);
                                SELECT SCOPE_IDENTITY();   -- get the auto-generated id back
                                ";
                                cmd.Parameters.Add("@u", SqlDbType.VarChar, 50).Value = username;
                                cmd.Parameters.Add("@p", SqlDbType.VarBinary, 32).Value = passwordHash;
                                cmd.Parameters.Add("@e", SqlDbType.VarChar, 50).Value = email;
                                cmd.Parameters.Add("@a", SqlDbType.Int).Value = age;

                                connect.Open();

                                var newId = Convert.ToInt32(cmd.ExecuteScalar());

                                    MessageBox.Show($"Registration successful! Your user ID is {newId}.");
                                    this.Hide();
                                    Log_In LogIn_Window = new Log_In();
                                    LogIn_Window.Show();
                                
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Handle SQL exceptions
                            MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                        }
                        catch (FormatException ex)
                        {
                            // Handle format exceptions
                            MessageBox.Show("Invalid input format: " + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            // Handle other exceptions
                            MessageBox.Show("An unexpected error occurred: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email format.");
                }
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
