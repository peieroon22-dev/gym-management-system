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
    public partial class Manager_product_delete : BaseForm
    {
        public Manager_product_delete()
        {
            InitializeComponent();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string productID = txt_deleteProductID.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Please enter a Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [dbo].[Product] WHERE Product_ID = @ProductID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Product ID not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM [dbo].[Product] WHERE Product_ID = @ProductID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@ProductID", productID);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_deleteProductID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error deleting the product record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_deleteProductID.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_product manager_Product = new Manager_product();
            manager_Product.Show();
            this.Close();
        }
    }
}
