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
    public partial class RE_appointment_delete : ReBaseForm
    {
        public RE_appointment_delete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string appointmentID = txt_deleteAppointmentID.Text.Trim();

            // Check if the input field is empty
            if (string.IsNullOrEmpty(appointmentID))
            {
                MessageBox.Show("Please enter an Appointment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [dbo].[Appointment] WHERE Appointment_ID = @AppointmentID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Appointment ID not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM [dbo].[Appointment] WHERE Appointment_ID = @AppointmentID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_deleteAppointmentID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error deleting the appointment record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_deleteAppointmentID.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RE_appointment rE_Appointment = new RE_appointment();
            rE_Appointment.Show();
            this.Close();
        }
    }
}
