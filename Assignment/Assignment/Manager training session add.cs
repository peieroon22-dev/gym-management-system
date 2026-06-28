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
    public partial class Manager_training_session_add : BaseForm
    {
        public Manager_training_session_add()
        {
            InitializeComponent();
        }

        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_add_Click(object sender, EventArgs e)
        {
            string sessionName = txt_sessionName.Text.Trim();
            string category = txt_Category.Text.Trim();
            string priceText = txt_price.Text.Trim();
            decimal price;

            if (string.IsNullOrEmpty(sessionName) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(priceText, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO [dbo].[Training_Session] (Session_Name, Category, Price) VALUES (@SessionName, @Category, @Price)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SessionName", sessionName);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@Price", price);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Training session added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the training session. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_Category.Text = txt_price.Text = txt_sessionName.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_training_session manager_Training_Session = new Manager_training_session();
            manager_Training_Session.Show();
            this.Close();
        }
    }
}
