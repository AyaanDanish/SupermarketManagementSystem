using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class EMPLOYEE_INBOX : Form
    {
        public EMPLOYEE_INBOX()
        {
            InitializeComponent();
        }

        private void EMPLOYEE_INBOX_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\EMPLOYEE\\" + EMPLOYEE_LOGIN.un + "INBOX.txt";

            StreamReader sr = new StreamReader(path);
            textBox1.Text = sr.ReadToEnd();
          
        }
    }
}
