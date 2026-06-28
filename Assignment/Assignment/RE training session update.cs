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
    public partial class RE_training_session_update : ReBaseForm
    {
        public RE_training_session_update()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sessionID = txt_sessionID.Text.Trim();
            string sessionName = txt_sessionName.Text.Trim();
            string category = txt_Category.Text.Trim();
            string priceText = txt_price.Text.Trim();

            if (string.IsNullOrEmpty(sessionID))
            {
                MessageBox.Show("Session ID is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = 0;
            if (!string.IsNullOrEmpty(priceText))
            {
                if (!decimal.TryParse(priceText, out price) || price < 0)
                {
                    MessageBox.Show("Please provide a valid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<string> updates = new List<string>();
                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@SessionID", sessionID)
                    };

                    if (!string.IsNullOrEmpty(sessionName))
                    {
                        updates.Add("Session_Name = @SessionName");
                        parameters.Add(new SqlParameter("@SessionName", sessionName));
                    }

                    if (!string.IsNullOrEmpty(category))
                    {
                        updates.Add("Category = @Category");
                        parameters.Add(new SqlParameter("@Category", category));
                    }

                    if (!string.IsNullOrEmpty(priceText))
                    {
                        updates.Add("Price = @Price");
                        parameters.Add(new SqlParameter("@Price", price));
                    }

                    if (updates.Count == 0)
                    {
                        MessageBox.Show("No fields to update. Please provide at least one field other than Session ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = $"UPDATE [dbo].[Training_Session] SET {string.Join(", ", updates)} WHERE Session_ID = @SessionID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Training session details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No training session found with the given ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the training session details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_sessionID.Text = txt_sessionName.Text = txt_Category.Text = txt_price.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RE_training_session rE_Training_Session = new RE_training_session();
            rE_Training_Session.Show();
            this.Close();
        }
    }
}
