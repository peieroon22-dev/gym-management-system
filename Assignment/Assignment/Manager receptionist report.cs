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
    public partial class Manager_report : BaseForm
    {
        public Manager_report()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void Manager_report_Load(object sender, EventArgs e)
        {
            LoadReceptionistData();
        }

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_receptionist mangerRegistrationist = new Manager_receptionist();
            mangerRegistrationist.Show();
            this.Close();
        }
    }
}
