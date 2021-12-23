using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void MaximizeToMonitor(Form frm, int monitorIndex)
        {
            try
            {
                Screen screen = Screen.AllScreens[monitorIndex];
                if (screen != null)
                {
                    frm.WindowState = FormWindowState.Normal;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Location = screen.Bounds.Location;
                    
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Monitor does not exists. {Environment.NewLine}{ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            var f2 = WinformExntension.MaximizeToMonitor(f, 1);
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();
        }
    }
}
