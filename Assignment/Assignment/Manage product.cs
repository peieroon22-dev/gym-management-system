using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Manage_product : BaseForm
    {
        public Manage_product()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Manage_order_product manage_Order_Product = new Manage_order_product();
            manage_Order_Product.Show();
            this.Close();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            Manage_sell_product manage_Sell_Product = new Manage_sell_product();
            manage_Sell_Product.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_product manager_Product = new Manager_product();
            manager_Product.Show();
            this.Close();
        }
    }
}
