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
    public partial class RE_product : ReBaseForm
    {
        public RE_product()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\peier\\Downloads\\WP Assignment\\Assignment\\Assignment\\Database1.mdf;Integrated Security=True;";

        private void RE_product_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Define the SQL query to fetch receptionist data
                    string query = "SELECT * FROM [dbo].[Product]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use a data adapter to fill the data into a DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dgrid_Product.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product(s) data: " + ex.Message);
            }
        }

        private void btn_manageProduct_Click(object sender, EventArgs e)
        {
            RE_manage_product rE_Manage_Product = new RE_manage_product();
            rE_Manage_Product.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RE_product_add rE_Product_Add = new RE_product_add();
            rE_Product_Add.Show();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            RE_product_update rE_Product_Update = new RE_product_update();
            rE_Product_Update.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            RE_product_delete rE_Product_Delete = new RE_product_delete();
            rE_Product_Delete.Show();
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

                    string query = @"SELECT * FROM [dbo].[Product] WHERE (Product_ID LIKE @Search) OR (Product_Name LIKE @Search) OR (Category LIKE @Search)
                                    OR (Selling_Price LIKE @Search) OR (Ordered_Units LIKE @Search) OR (Stock_Units LIKE @Search) OR (Sold_Units LIKE @Search)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dgrid_Product.DataSource = dataTable;
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
