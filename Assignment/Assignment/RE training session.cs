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
    public partial class RE_training_session : ReBaseForm
    {
        public RE_training_session()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void RE_training_session_Load(object sender, EventArgs e)
        {
            LoadTrainingSessionData();
        }

        private void LoadTrainingSessionData()
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Define the SQL query to fetch receptionist data
                    string query = "SELECT * FROM [dbo].[Training_Session]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use a data adapter to fill the data into a DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dgrid_TrainingSession.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading training session(s) data: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RE_training_session_add rE_Training_Session_Add = new RE_training_session_add();
            rE_Training_Session_Add.Show();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            RE_training_session_update rE_Training_Session_Update = new RE_training_session_update();
            rE_Training_Session_Update.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            RE_training_session_delete rE_Training_Session_Delete = new RE_training_session_delete();
            rE_Training_Session_Delete.Show();
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

                    string query = @"SELECT * FROM [dbo].[Training_Session] WHERE (Session_ID LIKE @Search) OR (Session_Name LIKE @Search) OR (Category LIKE @Search)
                                    OR (Price LIKE @Search)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dgrid_TrainingSession.DataSource = dataTable;
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
