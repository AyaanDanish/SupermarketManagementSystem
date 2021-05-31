using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class EMPLOYEE_PORTAL : Form
    {
        string name;
        public EMPLOYEE_PORTAL(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        private void EMPLOYEE_PORTAL_Load(object sender, EventArgs e)
        {
            label2.Text = name;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
             
            string path = Application.StartupPath + "\\EMPLOYEE\\" + EMPLOYEE_LOGIN.un + "ATTENDANCE.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(DateTime.Now.ToString("dd-MM-yyyy")+" Present");
            }

            MessageBox.Show("ATTENDANCE MARKED, REMARKING OF ATTENDANCE WILL RESULT IN PENALTY");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SURVEILLANCE s = new SURVEILLANCE();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EMPLOYEE_VIEW_ATTENDANCE en = new EMPLOYEE_VIEW_ATTENDANCE();
            en.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMPLOYEE_INBOX ei = new EMPLOYEE_INBOX();
            ei.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPLOYEE_CHEQUE ec = new EMPLOYEE_CHEQUE();
            ec.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMPLOYEE_GRAPH g = new EMPLOYEE_GRAPH();
            g.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EMP_STOCKS stocks = new EMP_STOCKS();
            stocks.Show();
        }
    }
}
