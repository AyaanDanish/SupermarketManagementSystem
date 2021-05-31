using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class STORE : Form
    {
        List<double> prices = new List<double>();
        List<string> items = new List<string>();
       
        int points = 0;
         
        // Variables to count how many times each item was added to the cart (cannot exceed the amount that is in stock)
        int Potato, Tomato, Apple, Mango, Beef, Chicken, Lamb, Fish, Laptop, Television, Mobile, Headphones, Straightener, Fridge, Telephone, Speakers;

        public STORE()
        {
            InitializeComponent();
        }

        private void total_Click(object sender, EventArgs e)
        {
            double sum = 0;

            // Calls the function to update the stocks in the database according to what was bought
            UpdateStocks();

            // Traverses the prices list and calculates the total cost for this transaction
            foreach (double a in prices)
                sum += a;
            string path = Application.StartupPath + "\\CUSTOMER\\" + login_customer.uname + ".txt";

            // Explicit type casting here so that points are always integers and points earned are equal to 20% of the total bill
            points = (20 * (int)sum) / 100;
            var time = DateTime.Now; // Gets the current system date and time
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);

            // If the user has redeemed his points for a discount then the discount is applied here and the bill is displayed
            if (MEMBERSHIP.check == "y")
            {
                textBox1.Text += "YOU AVAILED " + MEMBERSHIP.discount * 100 + " % DISCOUNT" + Environment.NewLine;
                sum = sum - (sum * MEMBERSHIP.discount);
                textBox1.Text += "TOTAL BILL" + Environment.NewLine;
                textBox1.Text += "$" + sum;
                MEMBERSHIP.check = "n";
            }
            else // Otherwise the total bill is displayed normally
            {
                textBox1.Text += "TOTAL BILL" + Environment.NewLine;
                textBox1.Text += "$" + sum;
            }

            // Reads the customer file and saves all lines to a string array
            string[] arrLine = File.ReadAllLines(path);

            // If the customer has a membership then the points he earned from this transaction are displayed
            if (arrLine[10] == "y")
            {
                textBox1.Text += Environment.NewLine;
                textBox1.Text += Environment.NewLine;
                textBox1.Text += "POINTS EARNED";
                textBox1.Text += Environment.NewLine;
                textBox1.Text += points;
            }

            // Path for the customer history file
            string path2 = Application.StartupPath + "\\CUSTOMER\\" + login_customer.uname + "HISTORY.txt";

            // Writes the contents of the textbox to the customer history file along with the date and time, so that this transaction is logged
            using (StreamWriter sw = File.AppendText(path2))
            {
                sw.WriteLine("----------------------------------------------");
                sw.WriteLine(time);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }

            // Gets the customer's current points from the string array read from file, calculates his new points, and then writes them back to the file
            int oldpoints = Convert.ToInt32(arrLine[11]);
            points += oldpoints;
            arrLine[11] = points.ToString();
            File.WriteAllLines(path, arrLine);
        }

        

        // Function to update the contents of the text box every time an item is added or removed from the cart
        private void UpdateTextBox()
        {
            // String.Join accepts a separator (Newline in this case), and a string array (the items list in this case)
            // And it joins them into a single string which is then written to the textbox
            textBox1.Text = string.Join(Environment.NewLine, items.ToArray()); 
        }

        
        // Function that is called after total button is clicked to update stocks in the database
        private void UpdateStocks()
        {
            // Runs through the list, checks each item, and updates the respective stock upon totalling
            foreach (string a in items)
            {
                // It checks the item by extracting the part before the spaces from the Items list
                int space = a.IndexOf(' ');
                string str = a.Substring(0, space);

                // Deduct the stock from the database for whatever item is in the list
                switch (str)
                {
                    case "POTATOES":
                        Properties.Settings.Default.Potatoes--;
                        break;
                    case "TOMATOES":
                        Properties.Settings.Default.Tomatoes--;
                        break;
                    case "APPLES":
                        Properties.Settings.Default.Apples--;
                        break;
                    case "MANGOES":
                        Properties.Settings.Default.Mangoes--;
                        break;
                    case "BEEF":
                        Properties.Settings.Default.Beef--;
                        break;
                    case "CHICKEN":
                        Properties.Settings.Default.Chicken--;
                        break;
                    case "LAMB":
                        Properties.Settings.Default.Lamb--;
                        break;
                    case "FISH":
                        Properties.Settings.Default.Fish--;
                        break;
                    case "LAPTOP":
                        Properties.Settings.Default.Laptop--;
                        break;
                    case "TELEVISION":
                        Properties.Settings.Default.Television--;
                        break;
                    case "MOBILE":
                        Properties.Settings.Default.Mobile--;
                        break;
                    case "HEADPHONES":
                        Properties.Settings.Default.Headphones--;
                        break;
                    case "FRIDGE":
                        Properties.Settings.Default.Fridge--;
                        break;
                    case "STRAIGHTENER":
                        Properties.Settings.Default.Straightener--;
                        break;
                    case "TELEPHONE":
                        Properties.Settings.Default.Telephone--;
                        break;
                    case "SPEAKERS":
                        Properties.Settings.Default.Speakers--;
                        break;
                }
                
            }
            Properties.Settings.Default.Save(); // Save the changes made to the database
        }


        #region Item Button Clicks
        // Clicking a button for an item adds it to the items and prices lists & increments the cart counter (only if there is stock left)

        private void tomatoes_Click(object sender, EventArgs e)
        {
            Tomato++;
            if (Tomato > Properties.Settings.Default.Tomatoes)
            {
                Tomato--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(7.50);
            items.Add("TOMATOES".PadRight(17) + "$7.50");
            UpdateTextBox();  
        }

       
        private void potato_Click(object sender, EventArgs e)
        {
            Potato++;
            if (Potato > Properties.Settings.Default.Potatoes)
            {
                Potato--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(5.0);
            items.Add("POTATOES".PadRight(17) + "$5.00");
            UpdateTextBox();
        }

        private void apple_Click(object sender, EventArgs e)
        {
            Apple++;
            if (Apple > Properties.Settings.Default.Apples)
            {
                Apple--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(3.55);
            items.Add("APPLES".PadRight(17) + "$3.55");
            UpdateTextBox();
        }

       

        private void mango_click(object sender, EventArgs e)
        {
            Mango++;
            if (Mango > Properties.Settings.Default.Mangoes)
            {
                Mango--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(3.55);
            items.Add("MANGOES".PadRight(17) + "$3.55");
            UpdateTextBox();
        }

        private void beef_click(object sender, EventArgs e)
        {
            Beef++;
            if (Beef > Properties.Settings.Default.Beef)
            {
                Beef--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(12.50);
            items.Add("BEEF".PadRight(17) + "$12.50");
            UpdateTextBox();
        }

        private void chicken_click(object sender, EventArgs e)
        {
            Chicken++;
            if (Chicken > Properties.Settings.Default.Chicken)
            {
                Chicken--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(10.00);
            items.Add("CHICKEN".PadRight(17) + "$10.00");
            UpdateTextBox();
        }

        private void lamb_click(object sender, EventArgs e)
        {
            Lamb++;
            if (Lamb > Properties.Settings.Default.Lamb)
            {
                Lamb--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(13.45);
            items.Add("LAMB".PadRight(17) + "$13.45");
            UpdateTextBox();
        }

        private void fish_click(object sender, EventArgs e)
        {
            Fish++;
            if (Fish > Properties.Settings.Default.Fish)
            {
                Fish--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(9.55);
            items.Add("FISH".PadRight(17) + "$9.55");
            UpdateTextBox();
        }

        private void laptop_Click(object sender, EventArgs e)
        {
            Laptop++;
            if (Laptop > Properties.Settings.Default.Laptop)
            {
                Laptop--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(500.0);
            items.Add("LAPTOP".PadRight(17) + "$500.0");
            UpdateTextBox();
        }

        private void television_Click(object sender, EventArgs e)
        {
            Television++;
            if (Television > Properties.Settings.Default.Television)
            {
                Television--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(750.0);
            items.Add("TELEVISION".PadRight(17) + "$750.00");
            UpdateTextBox();
        }


        private void mobile_Click(object sender, EventArgs e)
        {
            Mobile++;
            if (Mobile > Properties.Settings.Default.Mobile)
            {
                Mobile--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(157.50);
            items.Add("MOBILE".PadRight(17) + "$157.50");
            UpdateTextBox();           
        }

        private void headphone_Click(object sender, EventArgs e)
        {
            Headphones++;
            if (Headphones > Properties.Settings.Default.Headphones)
            {
                Headphones--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(16.75);
            items.Add("HEADPHONES".PadRight(17) + "$16.75");
            UpdateTextBox();         
        }

        private void fridge_Click(object sender, EventArgs e)
        {
            Fridge++;
            if (Fridge > Properties.Settings.Default.Fridge )
            {
                Fridge--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(200.25);
            items.Add("FRIDGE".PadRight(17) + "$200.25");
            UpdateTextBox();           
        }

        private void straigthner_Click(object sender, EventArgs e)
        {
            Straightener++;
            if (Straightener > Properties.Settings.Default.Straightener)
            {
                Straightener--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(60.0);
            items.Add("STRAIGHTENER".PadRight(17) + "$60.00");
            UpdateTextBox();
        }

        private void phone_Click(object sender, EventArgs e)
        {
            Telephone++;
            if (Telephone > Properties.Settings.Default.Telephone)
            {
                Telephone--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(15.0);
            items.Add("TELEPHONE".PadRight(17) + "$15.00");
            UpdateTextBox();          
        }

        private void speakers_Click(object sender, EventArgs e)
        {
            Speakers++;
            if (Speakers > Properties.Settings.Default.Speakers)
            {
                Speakers--;
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + "//SOUNDS//" + "Sound_error.wav");
                sp.Play();
                MessageBox.Show("Sorry, we've run out of stock. You cannot add more of this item to the cart.");
                return;
            }
            prices.Add(50.0);
            items.Add("SPEAKERS".PadRight(17) + "$50.00");
            UpdateTextBox();            
        }

#endregion

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Checks what the last item in the list is and decrements the amount of times it was added to the cart
            // Does so by extracting the part before the spaces from the last element in the Items list
            string str = items[items.Count-1];
            int space = str.IndexOf(' ');
            str = str.Substring(0, space);
            switch (str)
            {
                case "POTATOES":
                    Potato--;
                    break;

                case "TOMATOES":
                    Tomato--;
                    break;

                case "APPLES":
                    Apple--;
                    break;

                case "MANGOES":
                    Mango--;
                    break;

                case "BEEF":
                    Beef--;
                    break;

                case "CHICKEN":
                    Chicken--;
                    break;

                case "LAMB":
                    Lamb--;
                    break;

                case "FISH":
                    Fish--;
                    break;

                case "LAPTOP":
                    Laptop--;
                    break;

                case "TELEVISION":
                    Television--;
                    break;

                case "MOBILE":
                    Mobile--;
                    break;

                case "HEADPHONES":
                    Headphones--;
                    break;

                case "FRIDGE":
                    Fridge--;
                    break;

                case "STRAIGHTENER":
                    Straightener--;
                    break;

                case "TELEPHONE":
                    Telephone--;                  
                    break;

                case "SPEAKERS":
                    Speakers--;
                    break;                      
            }

            // Removing the last item from both lists and updating the text box to reflect the updated lists
            items.RemoveAt(items.Count - 1);
            prices.RemoveAt(prices.Count - 1);
            UpdateTextBox();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Empties out both lists as well as the text box
            items.Clear();
            prices.Clear();
            textBox1.Clear();

            // Resets the number of times each item was added to the cart
            Potato = 0;
            Tomato = 0;
            Apple = 0;
            Mango = 0;
            Beef = 0;
            Chicken = 0;
            Fish = 0;
            Lamb = 0;
            Laptop = 0;
            Mobile = 0;
            Television = 0;
            Headphones = 0;
            Fridge = 0;
            Straightener = 0;
            Speakers = 0;
            Telephone = 0;
        }

    } 
}
