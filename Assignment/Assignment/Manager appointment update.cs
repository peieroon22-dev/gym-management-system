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
    public partial class Manager_appointment_update : BaseForm
    {
        public Manager_appointment_update()
        {
            InitializeComponent();

            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd/MM/yyyy";
            datePicker.ShowUpDown = false;

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void btn_update_Click(object sender, EventArgs e)
        {
            string appointmentID = txt_appointmentID.Text.Trim();
            string sessionID = txt_sessionID.Text.Trim();
            string trainerID = txt_trainerID.Text.Trim();
            string memberID = txt_memberID.Text.Trim();
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string time = timePicker.Value.ToString("HH:mm");

            if (string.IsNullOrEmpty(appointmentID))
            {
                MessageBox.Show("Appointment ID is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        new SqlParameter("@AppointmentID", appointmentID)
                    };

                    if (!string.IsNullOrEmpty(sessionID))
                    {
                        updates.Add("Session_ID = @SessionID");
                        parameters.Add(new SqlParameter("@SessionID", sessionID));
                    }

                    if (!string.IsNullOrEmpty(trainerID))
                    {
                        updates.Add("Trainer_ID = @TrainerID");
                        parameters.Add(new SqlParameter("@TrainerID", trainerID));
                    }

                    if (!string.IsNullOrEmpty(memberID))
                    {
                        updates.Add("Member_ID = @MemberID");
                        parameters.Add(new SqlParameter("@MemberID", memberID));
                    }

                    if (!string.IsNullOrEmpty(date))
                    {
                        updates.Add("Date = @Date");
                        parameters.Add(new SqlParameter("@Date", date));
                    }

                    if (!string.IsNullOrEmpty(time))
                    {
                        updates.Add("Time = @Time");
                        parameters.Add(new SqlParameter("@Time", time));
                    }

                    if (updates.Count == 0)
                    {
                        MessageBox.Show("No fields to update. Please provide at least one field other than Appointment ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = $"UPDATE [dbo].[Appointment] SET {string.Join(", ", updates)} WHERE Appointment_ID = @AppointmentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No appointment found with the given ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_appointmentID.Text = datePicker.Text = timePicker.Text = txt_sessionID.Text = txt_trainerID.Text = txt_memberID.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_appointment manager_Appointment = new Manager_appointment();
            manager_Appointment.Show();
            this.Close();
        }
    }
}
