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
    public partial class RE_trainer_delete : ReBaseForm
    {
        public RE_trainer_delete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string trainerID = txt_deleteTrainerID.Text.Trim();

            if (string.IsNullOrEmpty(trainerID))
            {
                MessageBox.Show("Please enter a Trainer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [dbo].[Trainer] WHERE Trainer_ID = @TrainerID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@TrainerID", trainerID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Trainer ID not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM [dbo].[Trainer] WHERE Trainer_ID = @TrainerID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@TrainerID", trainerID);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trainer record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_deleteTrainerID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error deleting the trainer record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RE_trainer re_trainer = new RE_trainer();
            re_trainer.Show();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_deleteTrainerID.Text = "";
        }
    }
}
