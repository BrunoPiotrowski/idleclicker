namespace idleclicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonlevel;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonlevel = 1;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonlevel-1);
            label1.Text = "kasa: $"+ cash.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int upgradecost = (int)Math.Pow(10, buttonlevel);
            if(cash >= upgradecost)
            buttonlevel++;
            buttonleveltextbox.Text = buttonlevel.ToString();
            cash -= upgradecost;
            label1.Text = "kasa: $" + cash.ToString();
            string nextupgradecost = "($" + Math.Pow(10, buttonlevel).ToString() + ")";
            upgradebutton2.Text = "upgrade\n" + nextupgradecost;

        }

        private void buttonleveltextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}