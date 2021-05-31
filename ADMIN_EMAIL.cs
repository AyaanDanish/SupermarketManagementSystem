using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_EMAIL : Form
    {
        public ADMIN_EMAIL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\EMPLOYEE\\" + textBox1.Text + "INBOX.txt";

            // If valid employee ID was entered then Subject and contents of message are saved to the employee's inbox text file
            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                sw.WriteLine(DateTime.Now + Environment.NewLine);
                sw.WriteLine("Subject: " + textBox2.Text + Environment.NewLine);
                sw.WriteLine(textBox3.Text + Environment.NewLine + Environment.NewLine);
                sw.Close();
                MessageBox.Show("EMAIL SENT!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect ID, Employee does not exist");
            }
        }
    }
}
