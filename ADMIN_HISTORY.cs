using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_HISTORY : Form
    {
        public ADMIN_HISTORY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = Application.StartupPath + "\\CUSTOMER\\" + textBox1.Text + "HISTORY.txt";
            if (File.Exists(path) == false)
            {
                MessageBox.Show("USERNAME DOSENT EXIST");
            }
            else
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    textBox2.Text = sr.ReadToEnd();
                    sr.Close();

                }
            }
        }
    }
}
