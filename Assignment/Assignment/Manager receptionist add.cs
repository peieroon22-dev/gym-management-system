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
    public partial class Manager_add : BaseForm
    {
        public Manager_add()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim();
            string password = txt_Password.Text.Trim();
            string phoneNumber = txt_phoneNumber.Text.Trim();
            string email = txt_email.Text.Trim();
            string homeAddress = txt_home.Text.Trim();
            string employmentStatus = cbox_fTime.Checked ? "Full-Time" : cbox_pTime.Checked ? "Part-Time" : null;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(homeAddress) || string.IsNullOrEmpty(employmentStatus))
            {
                MessageBox.Show("Please fill in all fields and select employment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^([a-zA-Z0-9_\.\-]+)@([a-zA-Z0-9_\.\-]+)\.([a-zA-Z]{2,6})$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please provide a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Regex.IsMatch(txt_phoneNumber.Text, @"^\d{10,15}$"))
            {
                MessageBox.Show("Please provide a valid phone number (10-15 digits)", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO [dbo].[Receptionist] (Name, Password, Phone_Number, Email, Home_Address, Employment_Status) VALUES (@Name, @Password, @Phone, @Email, @Home, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Home", homeAddress);
                        cmd.Parameters.AddWithValue("@Status", employmentStatus);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Receptionist added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add receptionist. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Manager_receptionist mangerRegistrationist = new Manager_receptionist();
            mangerRegistrationist.Show();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Name.Text = txt_Password.Text = txt_phoneNumber.Text = txt_email.Text = txt_home.Text = "";
            cbox_fTime.Checked = cbox_pTime.Checked = false;
        }

        private void cbox_pTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_pTime.Checked) cbox_fTime.Checked = false;
        }

        private void cbox_fTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_fTime.Checked) cbox_pTime.Checked = false;
        }
    }
}
