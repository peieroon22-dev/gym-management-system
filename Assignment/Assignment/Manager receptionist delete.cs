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
    public partial class Manager_delete : BaseForm
    {
        public Manager_delete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string receptionistID = txt_deleteReceptionistID.Text.Trim();

            // Check if the input field is empty
            if (string.IsNullOrEmpty(receptionistID))
            {
                MessageBox.Show("Please enter a Receptionist ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Database connection string
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

                // Connect to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the receptionist ID exists
                    string checkQuery = "SELECT COUNT(*) FROM [dbo].[Receptionist] WHERE Receptionist_ID = @ReceptionistID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ReceptionistID", receptionistID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Receptionist ID not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // If exists, delete the receptionist
                    string deleteQuery = "DELETE FROM [dbo].[Receptionist] WHERE Receptionist_ID = @ReceptionistID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@ReceptionistID", receptionistID);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Receptionist record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_deleteReceptionistID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error deleting the receptionist record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_deleteReceptionistID.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_receptionist mangerRegistrationist = new Manager_receptionist();
            mangerRegistrationist.Show();
            this.Close();
        }
    }
}
