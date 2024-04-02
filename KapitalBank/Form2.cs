using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapitalBank
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        decimal bank = 4000;
        decimal balans = 100;

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label8.Text = "Balans: " + balans.ToString() + " AZN";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal money = Convert.ToDecimal(textBox2.Text);

            if (bank < balans)
            {
                label5.Text = "Bankda kifayyet qeder mebleg yoxdur";
            }
            else
            {

                if (money < balans)
                {
                    balans = balans - money;
                    label5.Text = "Emeliyyat ugurla heyata kecirildi";
                    label8.Text = "Balans: " + balans.ToString() + " AZN";
                }
                else
                {
                    label5.Text = "Balansda kifayyet qeder mebleg yoxdur";
                }
            }
        }
    }
}
