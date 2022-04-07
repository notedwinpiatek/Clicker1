namespace Clicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        int A1Amount
        int A1Interval
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonLevel = 1;
            A1Amount = 10;
            A1Interval = 0;
            A1AmountTextBox.Text = A1Amount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonLevel-1);
            label1.Text = "Money: $"+cash.ToString();
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (cash >= upgradeCost)
            {
                buttonLevel++;
                buttonLevelTextBox.Text = buttonLevel.ToString();
                cash -= upgradeCost;
                label1.Text = "Money: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradeButton.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void A1UpgradeAmount_Click(object sender, EventArgs e)
        {
             
        }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if (Cash >= upgradeCost)
            {
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) * 100;
                if (!A1Timer.Enabled)
                    A1Timer.Enabled = true;
                Cash -= upgradeCost;

            }
        }

        private void A1Tick(object sender, EventArgs e)
        {
            Cash += A1Ammount;
            label1.Text = "Money: $" + cash.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}