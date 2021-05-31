using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class EMPLOYEE_CHEQUE : Form
    {
        public EMPLOYEE_CHEQUE()
        {
            InitializeComponent();
        }

        private void EMPLOYEE_CHEQUE_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\EMPLOYEE\\" + EMPLOYEE_LOGIN.un + ".txt";

            StreamReader sr = new StreamReader(path);

            string[] arrline = File.ReadAllLines(path);

            label1.Text = "AL-FAYSAL BANK".PadRight(79)+ "Fast NUCES Ltd."+Environment.NewLine+
                Environment.NewLine + "PAY: " +arrline[5] +
                Environment.NewLine + "A/C No. AFK-256 MM7 " +
                Environment.NewLine + "Presented To: Mr. "+ arrline[0] + arrline[1] +
                Environment.NewLine + "CNIC: "+ arrline[7]+
                Environment.NewLine + Environment.NewLine + "AL-FAYSAL BANK LTD." +
                Environment.NewLine + "FAST-NUCES KARACHI CAMPUS."+
                Environment.NewLine + "1923183219809" +
                Environment.NewLine + "Made by Rayyan, Kainat and Ayaan".PadRight(55) + "SIGNATURE: " + Environment.NewLine + Environment.NewLine; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label1.Text, new Font("Century Gothic",12,FontStyle.Regular),Brushes.Black, new PointF(130,130));
        }
    }
}
