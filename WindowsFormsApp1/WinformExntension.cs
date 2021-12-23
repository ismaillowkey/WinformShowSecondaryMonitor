using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class WinformExntension
    {
        public static Form MaximizeToMonitor(Form frm, int monitorIndex)
        {
            try
            {
                Screen screen = Screen.AllScreens[monitorIndex];
                if (screen != null)
                {
                    frm.WindowState = FormWindowState.Normal;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Location = screen.Bounds.Location;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Monitor does not exists. {Environment.NewLine}{ex.Message}");
            }
            return frm;
        }
    }
}
