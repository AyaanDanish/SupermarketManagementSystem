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



    public partial class SIGNUP : Form
    {
        

       
        public SIGNUP()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please fill out important fields");
            }
            else
            {
                
                if(File.Exists(Application.StartupPath + "\\CUSTOMER\\" + textBox3.Text + ".txt"))
                {
                    MessageBox.Show("USERNAME ALREADY TAKEN");
                    textBox3.Clear();

                }
                else {
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
                    sw.WriteLine(dateTimePicker1.Text);

                    sw.Close();

                    MessageBox.Show("Account registered!");
                    this.Close();
                }

            }

           


        }

        string name;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            F_name.Show("Enter first name",textBox1);
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            email.Show("XXXXXX@nu.edu.pk", textBox5);
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Clear();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            L_name.Show("Enter Last name", textBox2);
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            Username.Show("Enter a unique username", textBox3);
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            Password.Show("Enter a unique password", textBox4);
        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox9.Clear();
        }

        private void textBox9_MouseHover(object sender, EventArgs e)
        {
            CNIC.Show("Enter CNIC: XXXXX-XXXXXXX-X", textBox9);
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            address.Show("Enter permanent home address", textBox8);
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox7.Clear();
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            credit.Show("Enter credit card: 1234-1234-1234-1234", textBox7);

        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Clear();
        }

        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            phone.Show("Enter phone number: 03XX-XXXXXXX", textBox6);
        }
    }
}
