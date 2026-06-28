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
    public partial class Manager_member_update : BaseForm
    {
        public Manager_member_update()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_update_Click(object sender, EventArgs e)
        {
            string memberID = txt_memberID.Text.Trim();
            string name = txt_Name.Text.Trim();
            string phoneNumber = txt_phoneNumber.Text.Trim();
            string email = txt_Email.Text.Trim();
            string homeAddress = txt_Home.Text.Trim();

            if (string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Member ID is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Please provide a valid phone number (10-15 digits)", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        new SqlParameter("@MemberID", memberID)
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

                    if (updates.Count == 0)
                    {
                        MessageBox.Show("No fields to update. Please provide at least one field other than Member ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = $"UPDATE [dbo].[Member] SET {string.Join(", ", updates)} WHERE Member_ID = @MemberID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No member found with the given ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the member details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_memberID.Text = txt_Name.Text = txt_phoneNumber.Text = txt_Email.Text = txt_Home.Text ="";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_member manager_Member = new Manager_member();
            manager_Member.Show();
            this.Close();
        }
    }
}
