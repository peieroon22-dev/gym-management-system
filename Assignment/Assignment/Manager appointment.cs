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
    public partial class Manager_appointment : BaseForm
    {
        public Manager_appointment()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void Manager_appointment_Load(object sender, EventArgs e)
        {
            LoadAppointmentData();
        }

        private void LoadAppointmentData()
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Define the SQL query to fetch receptionist data
                    string query = "SELECT * FROM [dbo].[Appointment]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use a data adapter to fill the data into a DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dgrid_Appointment.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointment(s) data: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Manager_appointment_add manager_Appointment_Add = new Manager_appointment_add();
            manager_Appointment_Add.Show();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Manager_appointment_update manager_Appointment_Update = new Manager_appointment_update();
            manager_Appointment_Update.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Manager_appointment_delete manager_Appointment_Delete = new Manager_appointment_delete();
            manager_Appointment_Delete.Show();
            this.Close();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Manager_appointment_report manager_Appointment_Report = new Manager_appointment_report();
            manager_Appointment_Report.Show();
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchData(txt_search.Text);
        }

        private void SearchData(string search)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT * FROM [dbo].[Appointment] WHERE (Appointment_ID LIKE @Search) OR (Date LIKE @Search) OR (Time LIKE @Search) OR (Session_ID LIKE @Search)
                                    OR (Trainer_ID LIKE @Search) OR (Member_ID LIKE @Search)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

                        // Fill data table with filtered search results
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dgrid_Appointment.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during search: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
