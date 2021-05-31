using System;
using System.Windows.Forms;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_PORTAL : Form
    {
        public ADMIN_PORTAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN_CUSTOMER ac = new ADMIN_CUSTOMER();
            ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMIN_HISTORY ah = new ADMIN_HISTORY();
            ah.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SURVEILLANCE sur = new SURVEILLANCE();
            sur.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADMIN_EMP_ACC ap = new ADMIN_EMP_ACC();
            ap.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADMIN_EMP_DETAILS frm = new ADMIN_EMP_DETAILS();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ADMIN_EMP_UPDATE frm = new ADMIN_EMP_UPDATE();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ADMIN_EMAIL ae = new ADMIN_EMAIL();
            ae.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ADMIN_STOCKS stocks = new ADMIN_STOCKS();
            stocks.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ADMIN_GRAPH f2 = new ADMIN_GRAPH();
            f2.Show();
        }
    }
}
