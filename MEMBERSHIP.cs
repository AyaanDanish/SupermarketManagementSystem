using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class MEMBERSHIP : Form
    {
        public int points;
        public static double discount = 0;
        public static string check = "n";
       
        public MEMBERSHIP()
        {
            InitializeComponent();
        }
        
        private void MEMBERSHIP_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\CUSTOMER\\" + login_customer.uname + ".txt";
            string[] arrline = File.ReadAllLines(path);
            pointsTextBox.Text = arrline[11];

            string pts = arrline[11];
            points = int.Parse(pts);

            if(points>=10 && points <= 25)
            {
                textBox1.Text = "20%";
            }
            else if (points>25 && points<=50)
            {
                textBox1.Text = "30%";
            }
            else if (points > 50)
            {
                textBox1.Text = "40%";
            }
            else
            {
                textBox1.Text = "0%";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "20%")
            {
                discount = 0.2;
                check = "y";
            }
            else if (textBox1.Text == "30%")
            {
                discount = 0.3;
                check = "y";
            }
            else if (textBox1.Text == "40%")
            {
                discount = 0.4;
                check = "y";
            }
            else
            {
                discount = 0;
                check = "y";
            }



            MessageBox.Show("DISCOUNT WILL BE APPLIED NEXT TIME YOU SHOP!" +Environment.NewLine + "SHOPPING MUST BE DONE BEFORE LOGGING OUT OF THE APP");
            this.Close();


            string path = Application.StartupPath + "\\CUSTOMER\\" + login_customer.uname + ".txt";
            string[] arrline = File.ReadAllLines(path);
            arrline[11] = "0";
            File.WriteAllLines(path, arrline);




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
