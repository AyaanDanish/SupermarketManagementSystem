using System;
using System.Windows.Forms;
using System.IO;


namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_GRAPH : Form
    {
        public ADMIN_GRAPH()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try   
            {
                openFileDialog1.ShowDialog();  //opens dialogue box
                string fn = openFileDialog1.FileName;
                string fileread = File.ReadAllText(fn);
                string[] line = fileread.Split('\n'); 
                int count = 0;
              
               
                
                foreach (string str in line[0].Split(','))  //used to separate month from sales from text file (separated by comma)
                {
                    count++; //counting how many columns
                }
                dataGridView1.ColumnCount = count;
                
                
                foreach (string str1 in fileread.Split('\n')) //used to separate all 12 rows (separated by newline)
                {
                 
                        dataGridView1.Rows.Add(str1.Split(','));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("failed to open"); 
            }
        }
         
        private void button2_Click(object sender, EventArgs e)  //VIEW GRAPH
        {
            int rowcount = dataGridView1.RowCount - 1;
            double  c2;
            int a = 0;

            for (int i = 0; i < rowcount; i++)
            { 
                c2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                if(i<12)
                chart1.Series["Year1"].Points.AddXY(i+1, c2);
                else if (i > 12)
                {
                    chart1.Series["Year2"].Points.AddXY(a+1, c2);
                    a++;
                }
            }
        }
    }
}
