using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class CUSTOMER_PORTAL : Form
    {
        public static string d=" ";
        public CUSTOMER_PORTAL()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void CUSTOMER_PORTAL_Load(object sender, EventArgs e)
        {
            textBox1.Text = login_customer.var;
        }

        private void update_acc_Click(object sender, EventArgs e)
        {
            UPDATE_ACC a = new UPDATE_ACC();
            d = login_customer.dob;
            a.Show();

        }
    }
}
