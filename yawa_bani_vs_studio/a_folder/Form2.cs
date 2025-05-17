using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows; // For WPF window
using WpfApp1; // Reference to WpfApp1 namespace  

namespace yawa_bani_vs_studio.a_folder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        private void OpenWpfWindow()
        {
            // Assuming WpfApp1 contains a WPF Window class named MainWindow  
            var wpfWindow = new WpfApp1.MainWindow();
            wpfWindow.Show(); // Opens the WPF window  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initialize WPF application (only once!)
            if (System.Windows.Application.Current == null)
            {
                new System.Windows.Application(); // create WPF app context if not already running
            }

            // Create and show the WPF window
            MainWindow wpfWindow = new MainWindow();
            wpfWindow.Show(); // Use ShowDialog() if you want it modal
        }
    }
}