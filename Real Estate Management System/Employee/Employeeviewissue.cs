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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_Estate_Management_System.Employee
{
    public partial class Employeeviewissue : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Employeeviewissue()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Isshueinfo";
            FillDataGridView(query);
        }

        private void FillDataGridView(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridVieweissues.DataSource = dataTable;
                }
            }

            // new column for delete option
            if (!dataGridVieweissues.Columns.Contains("Resolve"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Resolve";
                deleteButtonColumn.HeaderText = "Resolve";
                deleteButtonColumn.Text = "Resolve";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridVieweissues.Columns.Add(deleteButtonColumn);
            }
        }
        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Employeeoverview employeeoverview = new Employeeoverview();
            employeeoverview.Show();
            Visible = false;
        }

        private void dataGridVieweissues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridVieweissues.Columns["Resolve"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to resolve this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dataGridVieweissues.Rows[e.RowIndex].Cells["ID"].Value.ToString(); // Assuming the ID column name is "ID"

                    // Enclose the ID value with single quotes in the SQL query
                    string query = $"DELETE FROM Isshueinfo WHERE ID = '{id}'";

                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(query, con))
                            {
                                con.Open();
                                command.ExecuteNonQuery();
                            }
                        }

                        dataGridVieweissues.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Record resolved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void buttoneviewall_Click(object sender, EventArgs e)
        {

        }

        private void buttonesearch_Click(object sender, EventArgs e)
        {
            string searchtext = textBoxesearch.Text;
            if (!string.IsNullOrWhiteSpace(searchtext))
            {
                string query = $"SELECT * FROM Isshueinfo WHERE ID LIKE '%{searchtext}%' OR Username LIKE '%{searchtext}%' OR Topic LIKE '%{searchtext}%' OR Email LIKE '%{searchtext}%'";
                FillDataGridView(query);
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        private void buttoneresolve_Click(object sender, EventArgs e)
        {

        }

        private void buttoneresolveall_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear DataGridView
                dataGridVieweissues.DataSource = null;
                dataGridVieweissues.Rows.Clear();

                // Delete all records
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"DELETE FROM Isshueinfo";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    //ResolveEventArgs message
                    MessageBox.Show($"{rowsAffected} record(s) deleted from Data !!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
