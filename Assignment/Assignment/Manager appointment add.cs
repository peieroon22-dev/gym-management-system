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
    public partial class Manager_appointment_add : BaseForm
    {
        public Manager_appointment_add()
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string time = timePicker.Value.ToString("HH:mm");
            string sessionID = txt_sessionID.Text.Trim();
            string trainerID = txt_trainerID.Text.Trim();
            string memberID = txt_memberID.Text.Trim();

            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) || string.IsNullOrEmpty(sessionID) || 
                string.IsNullOrEmpty(trainerID) || string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Appointment (Date, Time, Session_ID, Trainer_ID, Member_ID) VALUES (@Date, @Time, @SessionID, @TrainerID, @MemberID)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Time", time);
                        cmd.Parameters.AddWithValue("@SessionID", sessionID);
                        cmd.Parameters.AddWithValue("@TrainerID", trainerID);
                        cmd.Parameters.AddWithValue("@MemberID", memberID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add appointment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            datePicker.Text = timePicker.Text = txt_memberID.Text = txt_sessionID.Text = txt_trainerID.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_appointment manager_Appointment = new Manager_appointment();
            manager_Appointment.Show();
            this.Close();
        }
    }
}
