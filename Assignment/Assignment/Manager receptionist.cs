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
    public partial class Manager_receptionist : BaseForm
    {
        public Manager_receptionist()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void Manager_receptionist_Load(object sender, EventArgs e)
        {
            LoadReceptionistData();
        }

        // Method to load receptionist data from the database
        private void LoadReceptionistData()
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Define the SQL query to fetch receptionist data
                    string query = "SELECT * FROM [dbo].[Receptionist]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use a data adapter to fill the data into a DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dgrid_Receptionist.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading receptionist(s) data: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Manager_add managerAdd = new Manager_add();
            managerAdd.Show();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Manager_update managerUpdate = new Manager_update();
            managerUpdate.Show();
            this.Close();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Manager_report managerReport = new Manager_report();
            managerReport.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Manager_delete managerDelete = new Manager_delete();
            managerDelete.Show();
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

                    string query = @"SELECT * FROM [dbo].[Receptionist] WHERE (Receptionist_ID LIKE @Search) OR (Name LIKE @Search) OR (Password LIKE @Search)
                                    OR (Phone_Number LIKE @Search) OR (Email LIKE @Search) OR (Home_Address LIKE @Search) OR (Employment_Status LIKE @Search)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dgrid_Receptionist.DataSource = dataTable;
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
