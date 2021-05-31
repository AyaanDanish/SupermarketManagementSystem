using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class EMPLOYEE_VIEW_ATTENDANCE : Form
    {
        public EMPLOYEE_VIEW_ATTENDANCE()
        {
            InitializeComponent();
        }

        private void EMPLOYEE_VIEW_ATTENDANCE_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\EMPLOYEE\\" + EMPLOYEE_LOGIN.un + "ATTENDANCE.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
