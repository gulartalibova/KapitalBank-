namespace KapitalBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pin = { 1122, 2211 };
            if (textBox1.Text == pin[0].ToString())
            {
                Home home = new Home();
                home.Show();
            }
            else
            {
                label8.Visible = true;
            }
        }
    }
}
