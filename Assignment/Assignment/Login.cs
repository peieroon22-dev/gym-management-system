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
using MouveForm;

namespace Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_restore.Location = btn_max.Location;
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            if (radio_manager.Checked)
            {
                // Check Manager credentials
                if (ValidateManagerCredentials(email, password))
                {
                    Manager_profile managerProfile = new Manager_profile();
                    managerProfile.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Manager credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radio_receptionist.Checked)
            {
                // Check Receptionist credentials
                if (ValidateReceptionistCredentials(email, password))
                {
                    RE_profile reProfile = new RE_profile();
                    reProfile.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Receptionist credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a role (Manager or Receptionist).", "Role Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_email.Text = txt_password.Text = "";
            radio_manager.Checked = radio_receptionist.Checked = false;
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {
            MouveForm.Mouve.Go(panel_header);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_showPW_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '\0';
        }

        private void btn_showPW_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ID != "")
            {
                txt_email.Text = Properties.Settings.Default.ID;
                txt_password.Text = Properties.Settings.Default.Password;
            }
        }

        private bool ValidateManagerCredentials(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM [dbo].[Manager] WHERE Email = @Email AND Password = @Password";

            return CheckUserCredentials(query, email, password);
        }

        private bool ValidateReceptionistCredentials(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM [dbo].[Receptionist] WHERE Email = @Email AND Password = @Password";

            return CheckUserCredentials(query, email, password);
        }

        private bool CheckUserCredentials(string query, string email, string password)
        {
            bool isValid = false;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            isValid = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }

            return isValid;
        }
    }
}
