using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class CUSTOMER_PORTAL : Form
    {
        string fname;
        string[] arrline;


        public CUSTOMER_PORTAL(string fname)
        {
            this.fname = fname;
            InitializeComponent();
        }
   

        private void CUSTOMER_PORTAL_Load(object sender, EventArgs e)
        {
            textBox1.Text = fname; 
        }

        private void update_acc_Click(object sender, EventArgs e)
        {
            UPDATE_ACC a = new UPDATE_ACC();
            
            a.Show();

        }

        private void store_Click(object sender, EventArgs e)
        {
            STORE str = new STORE();
            str.Show();
        }

        private void purchase_history_click(object sender, EventArgs e)
        {
            PURCHASE_HISTORY ph = new PURCHASE_HISTORY();
            ph.Show();
        }

        private void membership_Click(object sender, EventArgs e)
        {

            string path = Application.StartupPath + "\\CUSTOMER\\" + login_customer.uname + ".txt";
            arrline = File.ReadAllLines(path);
            if (arrline[10] == "y")
            {
                MEMBERSHIP mp = new MEMBERSHIP();
                mp.Show();
            }
            else
                MessageBox.Show("You do not have an active membership!");
        }
       
        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
