using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RE_product_update : ReBaseForm
    {
        public RE_product_update()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_update_Click(object sender, EventArgs e)
        {
            string productID = txt_productID.Text.Trim();
            string productName = txt_productName.Text.Trim();
            string category = txt_category.Text.Trim();
            string sellingPriceText = txt_sellingPrice.Text.Trim();
            string orderedUnitsText = txt_orderedUnits.Text.Trim();
            string stockUnitsText = txt_stockUnits.Text.Trim();
            string soldUnitsText = txt_soldUnits.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Product ID is required to update the product.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal? sellingPrice = string.IsNullOrEmpty(sellingPriceText) ? (decimal?)null : decimal.Parse(sellingPriceText);
            int? orderedUnits = string.IsNullOrEmpty(orderedUnitsText) ? (int?)null : int.Parse(orderedUnitsText);
            int? stockUnits = string.IsNullOrEmpty(stockUnitsText) ? (int?)null : int.Parse(stockUnitsText);
            int? soldUnits = string.IsNullOrEmpty(soldUnitsText) ? (int?)null : int.Parse(soldUnitsText);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<string> updates = new List<string>();
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrEmpty(productName))
                    {
                        updates.Add("Product_Name = @ProductName");
                        parameters.Add(new SqlParameter("@ProductName", productName));
                    }

                    if (!string.IsNullOrEmpty(category))
                    {
                        updates.Add("Category = @Category");
                        parameters.Add(new SqlParameter("@Category", category));
                    }

                    if (sellingPrice.HasValue)
                    {
                        updates.Add("Selling_Price = @SellingPrice");
                        parameters.Add(new SqlParameter("@SellingPrice", sellingPrice.Value));
                    }

                    if (orderedUnits.HasValue)
                    {
                        updates.Add("Ordered_Units = @OrderedUnits");
                        parameters.Add(new SqlParameter("@OrderedUnits", orderedUnits.Value));
                    }

                    if (stockUnits.HasValue)
                    {
                        updates.Add("Stock_Units = @StockUnits");
                        parameters.Add(new SqlParameter("@StockUnits", stockUnits.Value));
                    }

                    if (soldUnits.HasValue)
                    {
                        updates.Add("Sold_Units = @SoldUnits");
                        parameters.Add(new SqlParameter("@SoldUnits", soldUnits.Value));
                    }

                    if (updates.Count == 0)
                    {
                        MessageBox.Show("No fields to update. Please provide at least one field other than Product ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = $"UPDATE [dbo].[Product] SET {string.Join(", ", updates)} WHERE Product_ID = @ProductID";
                    parameters.Add(new SqlParameter("@ProductID", productID));

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the product details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_productID.Text = txt_productName.Text = txt_category.Text = txt_sellingPrice.Text = txt_orderedUnits.Text = txt_stockUnits.Text = txt_soldUnits.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RE_product rE_Product = new RE_product();
            rE_Product.Show();
            this.Close();
        }
    }
}
