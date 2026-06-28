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
    public partial class RE_order_product : ReBaseForm
    {
        public RE_order_product()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string productID = txt_productID.Text.Trim();
            string orderedUnitsText = txt_orderedUnits.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Product ID is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(orderedUnitsText) || !int.TryParse(orderedUnitsText, out int orderedUnits) || orderedUnits <= 0)
            {
                MessageBox.Show("Please enter a valid number of ordered units.", "Invalid Units", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string querySelect = "SELECT Ordered_Units, Sold_Units FROM [dbo].[Product] WHERE Product_ID = @ProductID";

                    using (SqlCommand cmdSelect = new SqlCommand(querySelect, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@ProductID", productID);
                        SqlDataReader reader = cmdSelect.ExecuteReader();

                        if (reader.Read())
                        {
                            // Retrieve current Ordered and Sold Units
                            int currentOrderedUnits = Convert.ToInt32(reader["Ordered_Units"]);
                            int soldUnits = Convert.ToInt32(reader["Sold_Units"]);

                            reader.Close();

                            // Add the new ordered units to the current ones
                            int updatedOrderedUnits = currentOrderedUnits + orderedUnits;

                            // Update the product ordered units in the database
                            string queryUpdateOrdered = "UPDATE [dbo].[Product] SET Ordered_Units = @OrderedUnits WHERE Product_ID = @ProductID";

                            using (SqlCommand cmdUpdateOrdered = new SqlCommand(queryUpdateOrdered, conn))
                            {
                                cmdUpdateOrdered.Parameters.AddWithValue("@ProductID", productID);
                                cmdUpdateOrdered.Parameters.AddWithValue("@OrderedUnits", updatedOrderedUnits);
                                cmdUpdateOrdered.ExecuteNonQuery();
                            }

                            int updatedStockUnits = updatedOrderedUnits - soldUnits;

                            string queryUpdateStock = "UPDATE [dbo].[Product] SET Stock_Units = @StockUnits WHERE Product_ID = @ProductID";

                            using (SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, conn))
                            {
                                cmdUpdateStock.Parameters.AddWithValue("@ProductID", productID);
                                cmdUpdateStock.Parameters.AddWithValue("@StockUnits", updatedStockUnits);
                                cmdUpdateStock.ExecuteNonQuery();
                            }

                            MessageBox.Show("Product ordered units and stock units updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt_productID.Text = txt_orderedUnits.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RE_manage_product rE_Manage_Product = new RE_manage_product();
            rE_Manage_Product.Show();
            this.Close();
        }
    }
}
