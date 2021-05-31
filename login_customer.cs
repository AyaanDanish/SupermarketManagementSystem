using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{

    public partial class login_customer : Form
    {
        string pw;
        string un;
        string fname;
        public static string uname;     

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
            // Checks if customer has created an account and asks to Sign Up first if he hasn't
            string path = Application.StartupPath + "\\CUSTOMER\\" + un + ".txt";
            if (File.Exists(path) == false)
            {
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Username doesn't exist. Please Sign Up first.");
            }
            else
            {
                // If customer has created an account then open the file for the customer using the username entered in the username text box
                string[] arrline = File.ReadAllLines(path); // Reads the whole file and saves each line to a string array
                
                fname = arrline[0]; // 1st line of file = First name (will be passed to Customer Portal Form for welcome message)
                uname = arrline[2]; // 3rd line of file = Username (public static string)
                
                if (arrline[3] == pw) // If password read from 4th line of file matches password entered by user then login successful and Customer Portal opens
                {
                    this.Close();
                    CUSTOMER_PORTAL c = new CUSTOMER_PORTAL(fname);
                    c.Show();
                }
                else // If not, display error message and play error sound
                {
                    SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                    sp.Play();
                    MessageBox.Show("Invalid Password!");
                }
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
