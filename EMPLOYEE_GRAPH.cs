using System;
using System.Windows.Forms;
using System.IO;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class EMPLOYEE_GRAPH : Form
    {
        public EMPLOYEE_GRAPH()
        {
            InitializeComponent();

            //sets columns to MONTH and SALES 

            dataGridView1.ColumnCount = 2;  //2 cols
            dataGridView1.Columns[0].Name = "MONTH";
            dataGridView1.Columns[1].Name = "SALES";
            dataGridView1.RowCount = 12; //can only enter 12 rows of values
            initialisingdatagrid();




        }
        private void initialisingdatagrid()
        {
            string[] mon = new string[12] { "JANUARY","FEBRUARY" ,"MARCH","APRIL","MAY","JUNE","JULY","AUGUST","SEPTEMBER","OCTOBER","NOVEMBER",
                "DECEMBER" };
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = mon[i];
            }
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
            }
        }
        private void button1_Click(object sender, EventArgs e) //"ENTER"
        {
            string path = Application.StartupPath + "\\SALES\\" + "MONTHLY_SALES" + textBox1.Text + ".txt";

            using (TextWriter tw = new StreamWriter(path)) //ovject is made of TextWriter but its functions are used through StreamWriter because it is abstract class
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}"); //writes all the months followed by comma

                        bool a = j != dataGridView1.Columns.Count - 1;
                        if (a)
                        {
                            tw.Write(",");
                        }
                    }

                    tw.WriteLine(); //writes the sales price next to comma
                }
                tw.Close();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 12; i++) //i here represents months 1 for jan, 2 for feb
            {
                double c = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value); //c is the sales value, being converted to double
                chart1.Series["Sales"].Points.AddXY(i + 1, c); //just plotting (x,y) where x is num of months and y is sales
            }
        }


    }
}
