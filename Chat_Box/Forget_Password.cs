using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Register_and_LogIn
{
    public partial class Forget_Password : Form
    {
        private string connectionString = "Server=INIW;Database=Iniw_Chat_DB;Trusted_Connection=True;TrustServerCertificate=True;";
        private string _password;
        private string _username;
        public Forget_Password(string password, string username)
        {
            _password = password;
            _username = username;
            InitializeComponent();
            
        }
        private void Change_pass_btn_Click(object sender, EventArgs e)
        {
            var password = current_password_textbox.Text;
            var new_password = new_pass_textbox.Text;
            var confirm_password = new_pass_conf_textbox.Text;

            if (password != _password)
            {
                MessageBox.Show("Current password is incorrect. Please try again.");
                return;
            }
            if (new_password != confirm_password)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            // Hash the new password
            byte[] newPasswordHash = HashPassword(new_password);

            
            string username = _username;

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            UPDATE Users
            SET password_hash = @passwordHash
            WHERE username = @username";
                cmd.Parameters.AddWithValue("@passwordHash", newPasswordHash);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update password. Please try again.");
                }
            }
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
            this.Close();
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
