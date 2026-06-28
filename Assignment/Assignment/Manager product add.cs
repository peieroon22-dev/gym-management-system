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
    public partial class Manager_product_add : BaseForm
    {
        public Manager_product_add()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_add_Click(object sender, EventArgs e)
        {
            string productName = txt_productName.Text.Trim();
            string category = txt_category.Text.Trim();
            string sellingPriceText = txt_sellingPrice.Text.Trim();

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(sellingPriceText))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(sellingPriceText, out decimal sellingPrice))
            {
                MessageBox.Show("Please enter a valid selling price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO [dbo].[Product] (Product_Name, Category, Selling_Price) VALUES (@ProductName, @Category, @SellingPrice)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_category.Text = txt_productName.Text = txt_sellingPrice.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_product manager_Product = new Manager_product();
            manager_Product.Show();
            this.Close();
        }
    }
}
