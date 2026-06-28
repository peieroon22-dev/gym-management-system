using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Receptionist_registration : Form
    {
        public Receptionist_registration()
        {
            InitializeComponent();
        }

        // Enable window movement using the panel
        private void panel_header_Paint(object sender, PaintEventArgs e)
        {
            MouveForm.Mouve.Go(panel_header);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_restore.Visible = true;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restore.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string emailPattern = "^([a-zA-Z0-9_\\.-]+)@([a-zA-Z0-9_\\.-]+)\\.([a-zA-Z]{2,6})$";

            // Check for empty fields
            if (string.IsNullOrEmpty(txt_userName.Text) || string.IsNullOrEmpty(txt_password.Text) ||
                string.IsNullOrEmpty(txt_phoneNumber.Text) || string.IsNullOrEmpty(txt_email.Text) ||
                string.IsNullOrEmpty(txt_home.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email
            if (!Regex.IsMatch(txt_email.Text, emailPattern))
            {
                MessageBox.Show("Please provide a valid email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validate phone number (example: must be digits and 10-15 characters long)
            if (!Regex.IsMatch(txt_phoneNumber.Text, @"^\d{10,15}$"))
            {
                MessageBox.Show("Please provide a valid phone number (10-15 digits)", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string name = txt_userName.Text;
            string home = txt_home.Text;
            string phone = txt_phoneNumber.Text;
            string email = txt_email.Text;
            string password = txt_password.Text;

            if (!radio_manager.Checked && !radio_receptionist.Checked)
            {
                MessageBox.Show("Please select either Manager or Receptionist role.", "Role Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string employmentStatus = "";
            if (radio_receptionist.Checked)
            {
                if (!cbox_fTime.Checked && !cbox_pTime.Checked)
                {
                    MessageBox.Show("Please select employment status (Full-time or Part-time) for Receptionist.", "Employment Status Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                employmentStatus = cbox_fTime.Checked ? "Full-time" : "Part-time";
            }

            // Insert into database
            bool result;
            if (radio_manager.Checked)
            {
                result = Database.AddManager(name, home, phone, email, password);
            }
            else
            {
                result = Database.AddReceptionist(name, home, phone, email, password, employmentStatus);
            }

            if (result)
            {
                MessageBox.Show($"{(radio_manager.Checked ? "Manager" : "Receptionist")} Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Prompt user to proceed to login
                DialogResult dialogResult = MessageBox.Show("Proceed to login?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Open Login form
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    // Clear fields and remain on registration page
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txt_userName.Clear();
            txt_password.Clear();
            txt_phoneNumber.Clear();
            txt_email.Clear();
            txt_home.Clear();
            radio_manager.Checked = false;
            radio_receptionist.Checked = false;
            cbox_fTime.Checked = false;
            cbox_pTime.Checked = false;
        }

        private void radio_manager_CheckedChanged(object sender, EventArgs e)
        {
            cbox_fTime.Enabled = cbox_pTime.Enabled = !radio_manager.Checked;
        }

        private void radio_receptionist_CheckedChanged(object sender, EventArgs e)
        {
            cbox_fTime.Enabled = cbox_pTime.Enabled = radio_receptionist.Checked;
        }

        private void cbox_fTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_fTime.Checked) cbox_pTime.Checked = false;
        }

        private void cbox_pTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_pTime.Checked) cbox_fTime.Checked = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static class Database
        {
            private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

            private static bool IsEmailExist(string email)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM [dbo].[Manager] WHERE Email = @Email UNION ALL SELECT COUNT(*) FROM [dbo].[Receptionist] WHERE Email = @Email";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            int emailCount = (int)cmd.ExecuteScalar();
                            return emailCount > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                    return true;
                }
            }

            public static bool AddManager(string name, string home, string phone, string email, string password)
            {
                if (IsEmailExist(email))
                {
                    MessageBox.Show("Email already registered. Please use a different email.", "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO [dbo].[Manager] (Name, Password, Phone_Number, Email, Home_Address) VALUES (@Name, @Password, @Phone, @Email, @Home)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@Phone", phone);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Home", home);
                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                    return false;
                }
            }

            public static bool AddReceptionist(string name, string home, string phone, string email, string password, string employmentStatus)
            {
                if (IsEmailExist(email))
                {
                    MessageBox.Show("Email already registered. Please use a different email.", "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
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
                            cmd.Parameters.AddWithValue("@Phone", phone);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Home", home);
                            cmd.Parameters.AddWithValue("@Status", employmentStatus);
                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}