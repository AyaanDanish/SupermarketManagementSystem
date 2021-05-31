using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_EMP_UPDATE : Form
    {
        public ADMIN_EMP_UPDATE()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\EMPLOYEE\\" + textBox1.Text + ".txt";
            if (File.Exists(path) == false)
            {
                MessageBox.Show("This Employee doesn't exist!");
            }
            else
            {
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
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.ReadOnly = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\EMPLOYEE\\" + textBox1.Text + ".txt");
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(textBox5.Text);
            sw.WriteLine(textBox6.Text);
            sw.WriteLine(textBox7.Text);
            sw.WriteLine(textBox8.Text);
            sw.WriteLine(textBox9.Text);        
            sw.Close();

            MessageBox.Show("Changes Saved!");
            this.Close();

        }
    }
}
