using System;
using System.Windows.Forms;

namespace SUPERMARKET_MANAGEMENT_SYSTEM
{
    public partial class EMP_STOCKS : SUPERMARKET_MANAGEMENT_SYSTEM.ADMIN_STOCKS
    {
        public EMP_STOCKS()
        {
            InitializeComponent();
        }

  
        private void PotatoReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PotatoNeeded = true;
            MessageBox.Show("Potatoes shipment requested from Admin.");
        }

        private void TomatoReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TomatoNeeded = true;
            MessageBox.Show("Tomatoes shipment requested from Admin.");
        }

        private void AppleReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AppleNeeded = true;
            MessageBox.Show("Apples shipment requested from Admin.");
        }

        private void MangoReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MangoNeeded = true;
            MessageBox.Show("Mangoes shipment requested from Admin.");
        }

        private void BeefReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BeefNeeded = true;
            MessageBox.Show("Beef shipment requested from Admin.");
        }

        private void ChickenReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChickenNeeded = true;
            MessageBox.Show("Chicken shipment requested from Admin.");
        }

        private void LambReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LambNeeded = true;
            MessageBox.Show("Lamb shipment requested from Admin.");
        }

        private void FishReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FishNeeded = true;
            MessageBox.Show("Fish shipment requested from Admin.");
        }

        private void LaptopReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LaptopNeeded = true;
            MessageBox.Show("Laptop shipment requested from Admin.");
        }

        private void MobileReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MobileNeeded = true;
            MessageBox.Show("Mobile shipment requested from Admin.");
        }

        private void HeadphonesReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HeadphoneNeeded = true;
            MessageBox.Show("Headphones shipment requested from Admin.");
        }

        private void TVReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TVNeeded = true;
            MessageBox.Show("Television shipment requested from Admin.");
        }

        private void FridgeReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FridgeNeeded = true;
            MessageBox.Show("Fridge shipment requested from Admin.");
        }

        private void StraightenerReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StraightenerNeeded = true;
            MessageBox.Show("Straightener shipment requested from Admin.");
        }

        private void TelephoneReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TelephoneNeeded = true;
            MessageBox.Show("Telephone shipment requested from Admin.");
        }

        private void SpeakersReq_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpeakersNeeded = true;
            MessageBox.Show("Speakers shipment requested from Admin.");
        }
    }
}
