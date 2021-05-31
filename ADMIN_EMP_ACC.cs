using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_EMP_ACC : Form
    {
        public ADMIN_EMP_ACC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // If any of the important fields are left blank
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please fill out important fields");
            }
            else
            {
                // If employee username is not unique then return error
                if (File.Exists(Application.StartupPath + "\\EMPLOYEE\\" + textBox3.Text + ".txt"))
                {
                    MessageBox.Show("This Employee ID already exists! Please choose another");
                    textBox3.Clear();
                }
                else
                {
                    // Create file to hold employee details and write all details to the file
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\EMPLOYEE\\" + textBox3.Text + ".txt");
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(textBox4.Text);
                    sw.WriteLine(textBox5.Text);
                    sw.WriteLine(textBox8.Text);
                    sw.WriteLine(textBox7.Text);
                    sw.WriteLine(textBox6.Text);
                    sw.WriteLine(dateTimePicker1.Text);
                    sw.Close();
                    MessageBox.Show("Account registered!");                   
                }

            }

            // Create attendance and inbox files for later use
            StreamWriter swr = new StreamWriter(Application.StartupPath + "\\EMPLOYEE\\" + textBox3.Text + "ATTENDANCE.txt");
            swr.Close();
            StreamWriter swrd = new StreamWriter(Application.StartupPath + "\\EMPLOYEE\\" + textBox3.Text + "INBOX.txt");
            swrd.Close();

            this.Close();

        }

        // Function to shuffle letters around randomly
        static string Shuffle(string input)
        {
            var q = from c in input.ToCharArray()
                    orderby Guid.NewGuid()
                    select c;
            string s = string.Empty;
            foreach (var r in q)
                s += r;
            return s;
        }

        private void ADMIN_EMP_ACC_Load(object sender, EventArgs e)
        {
            string text = "aAbBcCdDeEfFgGhHiIjJhHkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ01234567890123456789,;:!*$@-_=,;:!*$@-_=";
            text = Shuffle(text); //Shuffle the above symbols using Shuffle() method.  
            text = text.Remove(5); //Cut the string size according to the chosen trackbar value.  
            textBox4.Text = text;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        // Allow the employee to upload a picture of themselves
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
