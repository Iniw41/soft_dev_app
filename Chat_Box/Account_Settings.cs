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

namespace Chat_Box
{
    public partial class Account_Settings : Form
    {
        public Account_Settings()
        {
            InitializeComponent();
        }

        private void Go_forget_password_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Go_back_click_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (System.Windows.Application.Current == null)
            {
                var app = new Chat_Box.App();
                app.InitializeComponent(); // Loads App.xaml resources
                Chat_Box.MainWindow wpfWindow = new Chat_Box.MainWindow();
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
    }
}
