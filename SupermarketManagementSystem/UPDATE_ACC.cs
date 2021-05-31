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
    public partial class UPDATE_ACC : Form
    {
        public UPDATE_ACC()
        {
            InitializeComponent();
        }
        private void UPDATE_ACC_Load(object sender, EventArgs e)
        {
            textBox1.Text = login_customer.fname;
            textBox2.Text = login_customer.lname;
            textBox3.Text = login_customer.uname;
            textBox4.Text = login_customer.passw;
            textBox5.Text = login_customer.mail;
            textBox6.Text= login_customer.cnic;
            textBox7.Text = login_customer.address;
            textBox8.Text = login_customer.creditcard;
            textBox9.Text = login_customer.ph_no;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
            textBox4.Clear();

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

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
            sw.WriteLine(login_customer.dob);

            sw.Close();

            MessageBox.Show("changes saved!");
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
