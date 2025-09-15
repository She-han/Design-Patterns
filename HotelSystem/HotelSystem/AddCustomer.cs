using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            Room room = null;
            string roomtype = null;

            if (radioButton1.Checked)
            {
                room = new Standard();
                roomtype = "Standard";

            }else if (radioButton2.Checked)
            {
                room = new Double();
                roomtype = "Double";

            }else if (radioButton3.Checked)
            {
                room = new Deluxe();
                roomtype = "Deluxe";
            }

            double res_chgs, bar_chgs, well_chgs, pick_chgs;

            double.TryParse(textBox2.Text, out res_chgs);
            double.TryParse(textBox3.Text, out bar_chgs);
            double.TryParse(textBox4.Text, out well_chgs);
            double.TryParse(textBox5.Text, out pick_chgs);

            if (res_chgs > 0)
            {
                room = new Restaurent(room, res_chgs);
            }
            if (bar_chgs > 0)
            {
                room = new Bar(room, bar_chgs);
            }
            if (well_chgs > 0)
            {
                room = new Wellness(room, well_chgs);
            }
            if (pick_chgs > 0)
            {
                room = new Pickup(room, pick_chgs);
            }

            double netpayment = room.getPrice();

            Customer customer = new Customer()
            {
                name = name,
                checkingdate = DateTime.Today,
                roomtype = roomtype,
                rescharges = res_chgs,
                barcharges = bar_chgs,
                wellcharges = well_chgs,
                pickcharges = pick_chgs,
                total =netpayment,
            };

            CustomerRepo.addCustomer(customer);

            MessageBox.Show($"Total payment : {netpayment}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
