using System;
using System.Windows.Forms;
using System.Drawing;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class ADMIN_STOCKS : Form
    {
        public ADMIN_STOCKS()
        {
            InitializeComponent();
        }
        

        private void ADMIN_STOCKS_Load(object sender, EventArgs e)
        {
            // Fetches the current stocks for all items from the database when the form loads
            
            PotatoesStock.Text = Properties.Settings.Default.Potatoes.ToString();
            TomatoesStock.Text = Properties.Settings.Default.Tomatoes.ToString();
            ApplesStock.Text = Properties.Settings.Default.Apples.ToString();
            MangoesStock.Text = Properties.Settings.Default.Mangoes.ToString();
            BeefStock.Text = Properties.Settings.Default.Beef.ToString();
            FishStock.Text = Properties.Settings.Default.Fish.ToString();
            LambStock.Text = Properties.Settings.Default.Lamb.ToString();
            ChickenStock.Text = Properties.Settings.Default.Chicken.ToString();

            LaptopStock.Text = Properties.Settings.Default.Laptop.ToString();
            MobileStock.Text = Properties.Settings.Default.Mobile.ToString();
            HeadphoneStock.Text = Properties.Settings.Default.Headphones.ToString();
            TVStock.Text = Properties.Settings.Default.Television.ToString();
            FridgeStock.Text = Properties.Settings.Default.Fridge.ToString();
            StraightenerStock.Text = Properties.Settings.Default.Straightener.ToString();
            TelephoneStock.Text = Properties.Settings.Default.Telephone.ToString();
            SpeakerStock.Text = Properties.Settings.Default.Speakers.ToString();

            #region Additional Stocks Requests
            //If an employee has requested additional stock for an item, the Admin is notified here

            if (Properties.Settings.Default.PotatoNeeded == true)
            {
                OrderPotato.ForeColor = Color.Red;
                OrderPotato.Text = "Additional Stock Requested";
            }        

            if (Properties.Settings.Default.TomatoNeeded == true)
            {
                OrderTomato.ForeColor = Color.Red;
                OrderTomato.Text = "Additional Stock Requested";
            }
            
            
            if (Properties.Settings.Default.AppleNeeded == true)
            {
                OrderApples.ForeColor = Color.Red;
                OrderApples.Text = "Additional Stock Requested";
            }             
            
            
            if (Properties.Settings.Default.MangoNeeded == true)
            {
                OrderMango.ForeColor = Color.Red;
                OrderMango.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.BeefNeeded == true)
            {
                OrderBeef.ForeColor = Color.Red;
                OrderBeef.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.ChickenNeeded == true)
            {
                OrderChicken.ForeColor = Color.Red;
                OrderChicken.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.LambNeeded == true)
            {
                OrderLamb.ForeColor = Color.Red;
                OrderLamb.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.FishNeeded == true)
            {
                OrderFish.ForeColor = Color.Red;
                OrderFish.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.LaptopNeeded == true)
            {
                OrderLaptop.ForeColor = Color.Red;
                OrderLaptop.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.MobileNeeded == true)
            {
                OrderMobile.ForeColor = Color.Red;
                OrderMobile.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.HeadphoneNeeded == true)
            {
                OrderHeadphones.ForeColor = Color.Red;
                OrderHeadphones.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.TVNeeded == true)
            {
                OrderTelevision.ForeColor = Color.Red;
                OrderTelevision.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.FridgeNeeded == true)
            {
                OrderFridge.ForeColor = Color.Red;
                OrderFridge.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.StraightenerNeeded == true)
            {
                OrderStraightener.ForeColor = Color.Red;
                OrderStraightener.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.TelephoneNeeded == true)
            {
                OrderTelephone.ForeColor = Color.Red;
                OrderTelephone.Text = "Additional Stock Requested";
            }
            

            if (Properties.Settings.Default.SpeakersNeeded == true)
            {
                OrderSpeakers.ForeColor = Color.Red;
                OrderSpeakers.Text = "Additional Stock Requested";
            }
            #endregion
        }


        #region Food Stocks
        
        #region Textbox Clicks
        // Whenever the user enters into a textbox it is cleared so that he can enter a number in it
        private void OrderPotatoes_Click(object sender, EventArgs e)
        {
            OrderPotato.Clear();
        }

        private void OrderTomato_Click(object sender, EventArgs e)
        {
            OrderTomato.Clear();
        }

        private void OrderApples_Click(object sender, EventArgs e)
        {
            OrderApples.Clear();
        }

        private void OrderMango_Click(object sender, EventArgs e)
        {
            OrderMango.Clear();
        }

        private void OrderBeef_Click(object sender, EventArgs e)
        {
            OrderBeef.Clear();
        }

        private void OrderChicken_Click(object sender, EventArgs e)
        {
            OrderChicken.Clear();
        }

        private void OrderLamb_Click(object sender, EventArgs e)
        {
            OrderLamb.Clear();
        }

        private void OrderFish_Click(object sender, EventArgs e)
        {
            OrderFish.Clear();
        }

        #endregion
        #region Button Clicks
        // For each Order More button, it first checks if the textbox contains only numerical values
        // Then it gets the amount of additional stock ordered and updates the new stock in the database as well as in the form
        private void OrderPotatoesBtn_Click(object sender, EventArgs e)
        {
            // Tries to convert the textbox contents to integer, if it fails, or if textbox empty, do nothing
            if (!int.TryParse(OrderPotato.Text, out int i) || OrderPotato.Text == "")
            {
                return;
            }

            int stock = Convert.ToInt32(PotatoesStock.Text);
            int order = Convert.ToInt32(OrderPotato.Text);
            Properties.Settings.Default.Potatoes = order + stock; // Updates the stock in the database
            Properties.Settings.Default.PotatoNeeded = false; // Sets the additional stock needed flag to false
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderPotato.Text + " Potatoes Ordered!");
            PotatoesStock.Text = (order + stock).ToString(); // Updates the stock in the form's table
            OrderPotato.ForeColor = Color.Black;
            OrderPotato.Text = "Quantity";
            
        }

        private void OrderTomatoBtn_Click(object sender, EventArgs e)
        {
            // If user enters an alphabetical value or if user enters nothing at all then button does nothing
            if (!int.TryParse(OrderTomato.Text, out int i) || OrderTomato.Text == "")
            {
                return;
            }

            int stock = Convert.ToInt32(TomatoesStock.Text);
            int order = Convert.ToInt32(OrderTomato.Text);
            Properties.Settings.Default.Tomatoes = order + stock; // updates the stock in the database
            Properties.Settings.Default.TomatoNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderTomato.Text + " Tomatoes Ordered!");
            TomatoesStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderTomato.ForeColor = Color.Black;
            OrderTomato.Text = "Quantity";
            
        }

        private void OrderApplesBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderApples.Text, out int i) || OrderApples.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(ApplesStock.Text);
            int order = Convert.ToInt32(OrderApples.Text);
            Properties.Settings.Default.Apples = order + stock; // updates the stock in the database
            Properties.Settings.Default.AppleNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderApples.Text + " Tomatoes Ordered!");
            ApplesStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderApples.ForeColor = Color.Black;
            OrderApples.Text = "Quantity";
        }

        private void OrderMangoesBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderMango.Text, out int i) || OrderMango.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(MangoesStock.Text);
            int order = Convert.ToInt32(OrderMango.Text);
            Properties.Settings.Default.Mangoes= order + stock; // updates the stock in the database
            Properties.Settings.Default.MangoNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderMango.Text + " Mangoes Ordered!");
            MangoesStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderMango.ForeColor = Color.Black;
            OrderMango.Text = "Quantity";
        }

        private void OrderBeefBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderBeef.Text, out int i) || OrderBeef.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(BeefStock.Text);
            int order = Convert.ToInt32(OrderBeef.Text);
            Properties.Settings.Default.Beef = order + stock; // updates the stock in the database
            Properties.Settings.Default.BeefNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderBeef.Text + " Beef Ordered!");
            BeefStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderBeef.ForeColor = Color.Black;
            OrderBeef.Text = "Quantity";
        }

        private void OrderChickenBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderChicken.Text, out int i) || OrderChicken.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(ChickenStock.Text); 
            int order = Convert.ToInt32(OrderChicken.Text);
            Properties.Settings.Default.Chicken = order + stock; // updates the stock in the database
            Properties.Settings.Default.ChickenNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderChicken.Text + " Chicken Ordered!");
            ChickenStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderChicken.ForeColor = Color.Black;
            OrderChicken.Text = "Quantity";
        }

        private void OrderLambBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderLamb.Text, out int i) || OrderLamb.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(LambStock.Text);
            int order = Convert.ToInt32(OrderLamb.Text);
            Properties.Settings.Default.Lamb = order + stock; // updates the stock in the database
            Properties.Settings.Default.LambNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderLamb.Text + " Lamb Ordered!");
            LambStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderLamb.ForeColor = Color.Black;
            OrderLamb.Text = "Quantity";
        }

        private void OrderFishBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderFish.Text, out int i) || OrderFish.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(FishStock.Text);
            int order = Convert.ToInt32(OrderFish.Text);
            Properties.Settings.Default.Fish = order + stock; // updates the stock in the database
            Properties.Settings.Default.FishNeeded= false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderFish.Text + " Fish Ordered!");
            FishStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderFish.ForeColor = Color.Black;
            OrderFish.Text = "Quantity";
        }
        #endregion
        #endregion

        #region Electronics Stocks

        #region Textbox Clicks
        // Whenever the user enters into a textbox it is cleared so that he can enter a number in it
        private void OrderLaptop_Click(object sender, EventArgs e)
        {
            OrderLaptop.Clear();
        }

        private void OrderMobile_Click(object sender, EventArgs e)
        {
            OrderMobile.Clear();
        }

        private void OrderHeadphone_Click(object sender, EventArgs e)
        {
            OrderHeadphones.Clear();
        }

        private void OrderTelevision_Click(object sender, EventArgs e)
        {
            OrderTelevision.Clear();
        }

        private void OrderFridge_Click(object sender, EventArgs e)
        {
            OrderFridge.Clear();
        }

        private void OrderStraightener_Click(object sender, EventArgs e)
        {
            OrderStraightener.Clear();
        }

        private void OrderTelephone_Click(object sender, EventArgs e)
        {
            OrderTelephone.Clear();
        }

        private void OrderSpeakers_Click(object sender, EventArgs e)
        {
            OrderSpeakers.Clear();
        }
        #endregion
        #region Button Clicks
        // For each Order More button, it first checks if the textbox contains only numerical values
        // Then it gets the amount of additional stock ordered and updates the new stock in the database as well as in the form
        private void OrderLaptopBtn_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(LaptopStock.Text);
            int order = Convert.ToInt32(OrderLaptop.Text);
            Properties.Settings.Default.Laptop = order + stock; // updates the stock in the database
            Properties.Settings.Default.LaptopNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderLaptop.Text + " Laptops Ordered!");
            LaptopStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderLaptop.ForeColor = Color.Black;
            OrderLaptop.Text = "Quantity";
        }

        private void OrderMobileBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderMobile.Text, out int i) || OrderMobile.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(MobileStock.Text);
            int order = Convert.ToInt32(OrderMobile.Text);
            Properties.Settings.Default.Mobile = order + stock; // updates the stock in the database
            Properties.Settings.Default.MobileNeeded= false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderMobile.Text + " Mobiles Ordered!");
            MobileStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderMobile.ForeColor = Color.Black;
            OrderMobile.Text = "Quantity";
        }

        private void OrderHeadphonesBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderHeadphones.Text, out int i) || OrderHeadphones.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(HeadphoneStock.Text);
            int order = Convert.ToInt32(OrderHeadphones.Text);
            Properties.Settings.Default.Headphones = order + stock; // updates the stock in the database
            Properties.Settings.Default.HeadphoneNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderHeadphones.Text + " Headphones Ordered!");
            PotatoesStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderHeadphones.ForeColor = Color.Black;
            OrderHeadphones.Text = "Quantity";
        }

        private void OrderTelevisionBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderTelevision.Text, out int i) || OrderTelevision.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(TVStock.Text);
            int order = Convert.ToInt32(OrderTelevision.Text);
            Properties.Settings.Default.Television = order + stock; // updates the stock in the database
            Properties.Settings.Default.TVNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderTelevision.Text + " Television Sets Ordered!");
            TVStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderTelevision.ForeColor = Color.Black;
            OrderTelevision.Text = "Quantity";
        }

        private void OrderFridgebtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderFridge.Text, out int i) || OrderFridge.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(FridgeStock.Text);
            int order = Convert.ToInt32(OrderFridge.Text);
            Properties.Settings.Default.Fridge = order + stock; // updates the stock in the database
            Properties.Settings.Default.FridgeNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderFridge.Text + " Fridges Ordered!");
            FridgeStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderFridge.ForeColor = Color.Black;
            OrderFridge.Text = "Quantity";
        }

        private void OrderStraightenerBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderStraightener.Text, out int i) || OrderStraightener.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(StraightenerStock.Text);
            int order = Convert.ToInt32(OrderStraightener.Text);
            Properties.Settings.Default.Straightener = order + stock; // updates the stock in the database
            Properties.Settings.Default.StraightenerNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderStraightener.Text + " Straighteners Ordered!");
            StraightenerStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderStraightener.ForeColor = Color.Black;
            OrderStraightener.Text = "Quantity";
        }

        private void OrderTelephoneBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderTelephone.Text, out int i) || OrderTelephone.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(TelephoneStock.Text);
            int order = Convert.ToInt32(OrderTelephone.Text);
            Properties.Settings.Default.Telephone = order + stock; // updates the stock in the database
            Properties.Settings.Default.TelephoneNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderTelephone.Text + " Telephones Ordered!");
            TelephoneStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderTelephone.ForeColor = Color.Black;
            OrderTelephone.Text = "Quantity";
        }

        private void OrderSpeakersBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderSpeakers.Text, out int i) || OrderSpeakers.Text == "")
            {
                return;
            }
            int stock = Convert.ToInt32(SpeakerStock.Text);
            int order = Convert.ToInt32(OrderSpeakers.Text);
            Properties.Settings.Default.Speakers = order + stock; // updates the stock in the database
            Properties.Settings.Default.SpeakersNeeded = false;
            Properties.Settings.Default.Save();
            MessageBox.Show(OrderSpeakers.Text + " Speakers Ordered!");
            SpeakerStock.Text = (order + stock).ToString(); // updates the stock in the form's table
            OrderSpeakers.ForeColor = Color.Black;
            OrderSpeakers.Text = "Quantity";
        }
        #endregion

        #endregion
    }
}
