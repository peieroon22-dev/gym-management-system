using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RE_trainer_update : ReBaseForm
    {
        public RE_trainer_update()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_update_Click(object sender, EventArgs e)
        {
            string trainerID = txt_ID.Text.Trim();
            string name = txt_name.Text.Trim();
            string phoneNumber = txt_phoneNumber.Text.Trim();
            string email = txt_email.Text.Trim();
            string homeAddress = txt_home.Text.Trim();
            bool isFullTime = cbox_fTime.Checked;
            bool isPartTime = cbox_pTime.Checked;

            if (string.IsNullOrEmpty(trainerID))
            {
                MessageBox.Show("Trainer ID is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(email))
            {
                string emailPattern = @"^([a-zA-Z0-9_\.\-]+)@([a-zA-Z0-9_\.\-]+)\.([a-zA-Z]{2,6})$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    MessageBox.Show("Please provide a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(phoneNumber) && !Regex.IsMatch(phoneNumber, @"^\d{10,15}$"))
            {
                MessageBox.Show("Please provide a valid phone number (10-15 digits).", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<string> updates = new List<string>();
                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@TrainerID", trainerID)
                    };

                    if (!string.IsNullOrEmpty(name))
                    {
                        updates.Add("Name = @Name");
                        parameters.Add(new SqlParameter("@Name", name));
                    }

                    if (!string.IsNullOrEmpty(phoneNumber))
                    {
                        updates.Add("Phone_Number = @PhoneNumber");
                        parameters.Add(new SqlParameter("@PhoneNumber", phoneNumber));
                    }

                    if (!string.IsNullOrEmpty(email))
                    {
                        updates.Add("Email = @Email");
                        parameters.Add(new SqlParameter("@Email", email));
                    }

                    if (!string.IsNullOrEmpty(homeAddress))
                    {
                        updates.Add("Home_Address = @HomeAddress");
                        parameters.Add(new SqlParameter("@HomeAddress", homeAddress));
                    }

                    if (isFullTime || isPartTime)
                    {
                        string employmentStatus = isFullTime ? "Full-Time" : isPartTime ? "Part-Time" : null;
                        if (employmentStatus != null)
                        {
                            updates.Add("Status = @EmploymentStatus");
                            parameters.Add(new SqlParameter("@EmploymentStatus", employmentStatus));
                        }
                    }

                    if (updates.Count == 0)
                    {
                        MessageBox.Show("No fields to update. Please provide at least one field other than Trainer ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = $"UPDATE [dbo].[Trainer] SET {string.Join(", ", updates)} WHERE Trainer_ID = @TrainerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trainer details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No trainer found with the given ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the trainer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ID.Text = txt_name.Text = txt_phoneNumber.Text = txt_email.Text = txt_home.Text = "";
            cbox_fTime.Checked = cbox_pTime.Checked = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RE_trainer re_trainer = new RE_trainer();
            re_trainer.Show();
            this.Close();
        }

        private void cbox_pTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_pTime.Checked) cbox_fTime.Checked = false;
        }

        private void cbox_fTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_fTime.Checked) cbox_pTime.Checked = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
