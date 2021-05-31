using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class EMPLOYEE_LOGIN : Form
    {
        public static string un;
        string name;       
        string pw;
        public EMPLOYEE_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\EMPLOYEE\\" + un + ".txt";
            if (File.Exists(path) == false)
            {
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Username doesn't exist");
                
            }
            else
            {
                

                string[] arrline = File.ReadAllLines(path);
                if (arrline[3] == pw)
                {

                    name = arrline[0];


                    EMPLOYEE_PORTAL emp = new EMPLOYEE_PORTAL(name);
                    emp.Show();

                    this.Close();
                }


                else
                {
                    SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                    sp.Play();
                    MessageBox.Show("Invalid Password!");
                }
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            un = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pw = textBox2.Text;
        }
    }
}
