using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class UPDATE_ACC : Form
    {
        string points;
        string dob;
        char hasMembership;
        
        public UPDATE_ACC()
        {           
            InitializeComponent();
        }
        private void UPDATE_ACC_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\CUSTOMER\\" + login_customer.uname + ".txt";
            if (File.Exists(path) == false)
            {
                MessageBox.Show("Username doesn't exist. Please Sign Up First.");
            }
            else
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    textBox1.Text = sr.ReadLine();
                    textBox2.Text = sr.ReadLine();
                    textBox3.Text = sr.ReadLine();
                    textBox4.Text = sr.ReadLine();
                    textBox5.Text = sr.ReadLine();
                    textBox6.Text = sr.ReadLine();
                    textBox7.Text = sr.ReadLine();
                    textBox8.Text = sr.ReadLine();
                    textBox9.Text = sr.ReadLine();
                    dob = sr.ReadLine();
                    hasMembership = char.Parse(sr.ReadLine());
                    points = sr.ReadLine();

                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
            textBox4.Clear();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\CUSTOMER\\" + textBox3.Text + ".txt");
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(textBox5.Text);
            sw.WriteLine(textBox6.Text);
            sw.WriteLine(textBox7.Text);
            sw.WriteLine(textBox8.Text);
            sw.WriteLine(textBox9.Text);
            sw.WriteLine(dob);
            sw.WriteLine(hasMembership);
            sw.WriteLine(points);
            sw.Close();

            MessageBox.Show("Changes have been saved!");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.ReadOnly = false;
            textBox8.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
            textBox7.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
            textBox6.Clear();
        }


    }
}
