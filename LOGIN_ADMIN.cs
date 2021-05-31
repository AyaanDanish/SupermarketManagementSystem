using System;
using System.Windows.Forms;
using System.Media;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class LOGIN_ADMIN : Form
    {
        public LOGIN_ADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text == "admin")
            {
                ADMIN_PORTAL a = new ADMIN_PORTAL();
                a.Show();
                this.Close();
            }
            else
            {
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("INCORRECT USERNAME OR PASSWORD");
            }
        }
    }
}
