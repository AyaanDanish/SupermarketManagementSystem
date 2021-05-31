using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_EMP_DETAILS : Form
    {
        public ADMIN_EMP_DETAILS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Opens the employee details file if it exists
            string path = Application.StartupPath + "\\EMPLOYEE\\" + textBox1.Text + ".txt";
            if (File.Exists(path) == false)
            {
                MessageBox.Show("This Employee does not exist!");
            }
            else
            {
                // Reads the file and displays the value of each line in its respective field
                using (StreamReader sr = new StreamReader(path))
                {
                    label7.Text = sr.ReadLine();
                    label10.Text = sr.ReadLine();
                    label13.Text = sr.ReadLine();
                    label14.Text = sr.ReadLine();
                    label15.Text = sr.ReadLine();
                    label16.Text = sr.ReadLine();
                    label17.Text = sr.ReadLine();
                    label18.Text = sr.ReadLine();
                    label19.Text = sr.ReadLine();
                    sr.Close();
                }
            }

            // Gets the attendance for this employee from his attendance file and displays it in the text box
            string path2 = Application.StartupPath + "\\EMPLOYEE\\" + textBox1.Text + "ATTENDANCE.txt";
            using (StreamReader sr = new StreamReader(path2))
            {
                textBox2.Text = sr.ReadToEnd();
                sr.Close();
            }

        }
    }
}
