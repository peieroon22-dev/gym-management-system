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
    public partial class Manage_sell_product : BaseForm
    {
        public Manage_sell_product()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string productID = txt_productID.Text.Trim();
            string soldUnitsText = txt_soldUnits.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Product ID is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(soldUnitsText) || !int.TryParse(soldUnitsText, out int soldUnits) || soldUnits <= 0)
            {
                MessageBox.Show("Please enter a valid number of sold units.", "Invalid Units", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to get the current sold units for the product
                    string querySelect = "SELECT Sold_Units, Ordered_Units FROM [dbo].[Product] WHERE Product_ID = @ProductID";

                    using (SqlCommand cmdSelect = new SqlCommand(querySelect, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@ProductID", productID);
                        SqlDataReader reader = cmdSelect.ExecuteReader();

                        if (reader.Read())
                        {
                            int currentSoldUnits = Convert.ToInt32(reader["Sold_Units"]);
                            int currentOrderedUnits = Convert.ToInt32(reader["Ordered_Units"]);

                            reader.Close();

                            // Add the new sold units to the current ones
                            int updatedSoldUnits = currentSoldUnits + soldUnits;

                            string queryUpdateSold = "UPDATE [dbo].[Product] SET Sold_Units = @SoldUnits WHERE Product_ID = @ProductID";

                            using (SqlCommand cmdUpdateSold = new SqlCommand(queryUpdateSold, conn))
                            {
                                cmdUpdateSold.Parameters.AddWithValue("@ProductID", productID);
                                cmdUpdateSold.Parameters.AddWithValue("@SoldUnits", updatedSoldUnits);
                                cmdUpdateSold.ExecuteNonQuery();                               
                            }

                            int updatedStockUnits = currentOrderedUnits - updatedSoldUnits;

                            string queryUpdateStock = "UPDATE [dbo].[Product] SET Stock_Units = @StockUnits WHERE Product_ID = @ProductID";

                            using (SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, conn))
                            {
                                cmdUpdateStock.Parameters.AddWithValue("@ProductID", productID);
                                cmdUpdateStock.Parameters.AddWithValue("@StockUnits", updatedStockUnits);
                                cmdUpdateStock.ExecuteNonQuery();
                            }

                            MessageBox.Show("Product sold units and stock units updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Product ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_productID.Text = txt_soldUnits.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manage_product manage_Product = new Manage_product();
            manage_Product.Show();
            this.Close();
        }
    }
}
