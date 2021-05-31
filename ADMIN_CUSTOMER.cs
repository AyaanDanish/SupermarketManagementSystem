using System;
using System.Windows.Forms;
using System.IO;
namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_CUSTOMER : Form
    {
        public ADMIN_CUSTOMER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\CUSTOMER\\" + textBox1.Text + ".txt";

            // IF invalid username entered
            if (File.Exists(path) == false)
            {
                MessageBox.Show("This username does not exist!");
            }
            else
            {
                // Opens the file and writes all details to their respective text boxes
                using (StreamReader sr = new StreamReader(path))
                {
                    textBox2.Text = sr.ReadLine();
                    textBox3.Text = sr.ReadLine();
                    textBox4.Text = sr.ReadLine();
                    textBox5.Text = sr.ReadLine();
                    textBox6.Text = sr.ReadLine();
                    textBox7.Text = sr.ReadLine();
                    textBox8.Text = sr.ReadLine();
                    textBox9.Text = sr.ReadLine();
                    textBox10.Text = sr.ReadLine();
                    textBox11.Text = sr.ReadLine();
                    textBox12.Text = sr.ReadLine();
                    textBox13.Text = sr.ReadLine();
                    sr.Close();
                }
            }
        }
    }
}
