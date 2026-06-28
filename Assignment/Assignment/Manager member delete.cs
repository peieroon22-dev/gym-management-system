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
    public partial class Manager_member_delete : BaseForm
    {
        public Manager_member_delete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string memberID = txt_deleteMemberID.Text.Trim();

            if (string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Please enter a Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [dbo].[Member] WHERE Member_ID = @MemberID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MemberID", memberID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Member ID not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM [dbo].[Member] WHERE Member_ID = @MemberID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@MemberID", memberID);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_deleteMemberID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error deleting the member record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_deleteMemberID.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_member manager_Member = new Manager_member();
            manager_Member.Show();
            this.Close();
        }
    }
}
