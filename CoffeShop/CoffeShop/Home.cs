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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeOrder order = new MakeOrder();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrder v = new ViewOrder();
            v.Show();
        }
    }
}
