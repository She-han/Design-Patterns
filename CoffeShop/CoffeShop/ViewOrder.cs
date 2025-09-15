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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OrderRepo.orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h2 = new Home();
            h2.Show();
        }
    }
}
