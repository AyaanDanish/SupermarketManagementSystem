using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{

    public partial class login_customer : Form
    {
        public static string var=" ";

        string pw;
        string un;
        public static string fname = " ";
        public static string lname = " ";
        public static string uname= " ";
        public static string passw = " ";
        public static string mail = " ";
        public static string cnic = " ";
        public static string address = " ";
        public static string creditcard = " ";
        public static string ph_no = " ";
        public static string dob = " ";
        public login_customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SIGNUP s = new SIGNUP();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   string pass;
               string path =  Application.StartupPath + "\\CUSTOMER\\" + un + ".txt";

               StreamReader sw = new StreamReader(path);

               pass = sw.ReadLine();


               if (String.Equals(pass, pw))
               {
                   MessageBox.Show("Welcome!");
               }
               else
               {
                   MessageBox.Show("Invalid Username Or Password!");
               }
               sw.Close();
            */
            string path = Application.StartupPath + "\\CUSTOMER\\" + un + ".txt";
            using (StreamReader sr = new StreamReader(path))
            {
                fname = sr.ReadLine();
                lname = sr.ReadLine();
                uname = sr.ReadLine();
                passw = sr.ReadLine();
                mail = sr.ReadLine();
                cnic = sr.ReadLine();
                address = sr.ReadLine();
                creditcard = sr.ReadLine();
                ph_no = sr.ReadLine();
                dob=sr.ReadLine();

                sr.Close();
            }

            
            const int l=4;

            string line;


            line = func(l);


            if (String.Equals(line, pw))
            {
                var = username.Text;
                MessageBox.Show("Welcome!");
                CUSTOMER_PORTAL c = new CUSTOMER_PORTAL();
                c.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password!");
            }




        }

        private string func(int specifiedLine)
        {
            int lineCount = 0;

            string path = Application.StartupPath + "\\CUSTOMER\\" + un + ".txt";
            using (StreamReader sr = new StreamReader(path))
            {
                lineCount++;
                var line = sr.ReadLine();

                while (lineCount != 5)
                {
                    
                    if (lineCount == specifiedLine)
                    {
                        return line;
                    }
                    line = sr.ReadLine();
                    
                    lineCount++;
                }

                sr.Close();
                return line;

            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            un = username.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            pw = password.Text;
        }

        private void login_customer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            login.Show("Login", button1);
        }

        private void SIGNUP_MouseHover(object sender, EventArgs e)
        {
            sign.Show("Create new account", SIGNUP);
        }
    }
}
