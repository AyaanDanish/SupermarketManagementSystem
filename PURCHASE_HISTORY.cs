using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class PURCHASE_HISTORY : Form
    {
        string line;
        public PURCHASE_HISTORY()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;

        }
        
        private void PURCHASE_HISTORY_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\CUSTOMER\\" + login_customer.uname + "HISTORY.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadToEnd();
                textBox1.Text = line;
            }

            


        }

    }
}
