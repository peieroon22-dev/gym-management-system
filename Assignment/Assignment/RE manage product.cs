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
    public partial class RE_manage_product : ReBaseForm
    {
        public RE_manage_product()
        {
            InitializeComponent();
        }

        private void RE_manage_product_Load(object sender, EventArgs e)
        {

        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            RE_sell_product rE_Sell_Product = new RE_sell_product();
            rE_Sell_Product.Show();
            this.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            RE_order_product rE_Order_Product = new RE_order_product();
            rE_Order_Product.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RE_product rE_Product = new RE_product();
            rE_Product.Show();
            this.Close();
        }
    }
}
