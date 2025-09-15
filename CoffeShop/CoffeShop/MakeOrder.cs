using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class MakeOrder : Form
    {
        public MakeOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            Coffee coffee = null;
            string type = null;

            if (radioButton1.Checked)
            {
                coffee = new Cappuccino();
                type = "Cappuccino";
            }else if (radioButton2.Checked)
            {
                coffee = new Latte();
                type = "Latte";
            }else if (radioButton3.Checked)
            {
                coffee = new Espresso();
                type = "Espresso";
            }

            string size = comboBox1.SelectedItem.ToString();

            List<string> addons = new List<string>();

            if (checkBox1.Checked)
            {
                addons.Add("Milk");
            }if (checkBox2.Checked)
            {
                addons.Add("Syrup");
            }if (checkBox3.Checked)
            {
                addons.Add("Cream");
            }

            int quantity = int.Parse(textBox2.Text);

            string addonstring = string.Join(",", addons);

            foreach (var dec in addons)
            {
                if (dec == "Milk")
                {
                    coffee = new Milk(coffee);

                }else if(dec == "Syrup")
                {
                    coffee = new Syrup(coffee);

                }else if (dec == "Cream")
                {
                    coffee = new Cream(coffee);
                }
            }

            double price = coffee.getPrice();
            double total = price * quantity;

            Order order = new Order()
            {
                name = name,
                type = type,
                size = size,
                orderdate = DateTime.Today,
                quantity = quantity,
                addons = addonstring,
                netprice = total,

            };

            OrderRepo.AddOrder(order);

            MessageBox.Show($"Total is : {total}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h2 = new Home();
            h2.Show();
        }
    }
}
