using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class STORE : Form
    {
        double sum = 0;
        int counter=0;
        public STORE()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                textBox1.Text += "POTATOES      $5.00\n" + Environment.NewLine;
                sum = sum + 5.00;
                
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
            
                textBox1.Text += "TOMATOES        $7.50\n" + Environment.NewLine;
                sum = sum + 7.50;
               
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                textBox1.Text += "APPLES          $3.55\n" + Environment.NewLine;
                sum = sum + 3.50;
                counter++;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                textBox1.Text += "FISH         $9.55\n" + Environment.NewLine;
                sum = sum + 9.55;
                counter++;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
                textBox1.Text += "MANGOES             $10.00\n" + Environment.NewLine;
                sum = sum + 10.00;
                counter++;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                textBox1.Text += "BEEF          $12.50\n" + Environment.NewLine;
                sum = sum + 12.50;
                counter++;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                textBox1.Text += "CHICKEN         $10.00\n" + Environment.NewLine;
                sum = sum + 10.00;
                counter++;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                textBox1.Text += "LAMB                $13.45\n" + Environment.NewLine;
                sum = sum + 13.45;
                counter++;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);
            textBox1.Text += "TOTAL BILL" + Environment.NewLine;
            textBox1.Text += "$" + sum;

        }
    } 
}
