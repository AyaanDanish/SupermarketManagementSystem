using System;
using System.Windows.Forms;
using System.Media;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//"+ "Sound_open.wav");
            sp.Play();
               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LOGIN_ADMIN f1 = new LOGIN_ADMIN();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            login_customer s1 = new login_customer();
            s1.Show();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPLOYEE_LOGIN emp = new EMPLOYEE_LOGIN();
            emp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label5.Text = dateTime.ToString("dd-MM-yyyy" + Environment.NewLine+ "hh:mm:ss tt");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "exit.wav");
            sp.Play();
            MessageBox.Show("Project made by Rayyan, Kainat and Ayaan" +Environment.NewLine + "For the CS-217 Course" + Environment.NewLine+ "Sections BCS-2B & 2F");
        }
    }
}
