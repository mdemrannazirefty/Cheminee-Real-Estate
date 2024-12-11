using Real_Estate_Management_System.Forms;
using Real_Estate_Management_System.Signup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_Estate_Management_System.Admin
{
    public partial class Propertytype : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Propertytype()
        {
            InitializeComponent();
            //LoadData();
        }


        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Overview ov = new Overview();
            ov.Show();
            Visible = false;
        }

        private void Propertytype_Load(object sender, EventArgs e)
        {

        }

        private void buttonptadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; " +
            "integrated security = SSPI";

            string typename = textBoxpttypename.Text;
            string description = textBoxptdescription.Text;

            if (string.IsNullOrEmpty(typename))
            {
                MessageBox.Show("Please fillup information.");
                return;
            }

            Guid id = Guid.NewGuid();
            string query = $"INSERT INTO Propertytype (ID,Propertytype,Description) VALUES (@ID,@Propertytype,@Description)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Propertytype", typename);
                cmd.Parameters.AddWithValue("@Description", description);

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }

            MessageBox.Show("Property Add Successful!!");
            textBoxpttypename.Clear();
            textBoxptdescription.Clear();

        }

        private void buttonptshowall_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Open the connection
                    con.Open();

                    // Define your query to retrieve all records from Propertytype table
                    string query = "SELECT * FROM Propertytype";

                    // Create a SqlDataAdapter to fetch data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                    // Create a DataTable to hold the fetched data
                    DataTable dt = new DataTable();

                    // Fill the DataTable with data from the SqlDataAdapter
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridViewptinfo.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }


        private void dataGridViewptinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewptinfo.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dataGridViewptinfo.Rows[e.RowIndex].Cells["ID"].Value.ToString(); // Assuming the ID column name is "ID"

                    // Enclose the ID value with single quotes in the SQL query
                    string query = $"DELETE FROM Propertytype WHERE ID = '{id}'";

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

                        dataGridViewptinfo.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Record Delete successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonptupdate_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonptdelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewptinfo.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewptinfo.SelectedRows[0];

                // Retrieve the ID of the selected row
                string id = selectedRow.Cells["ID"].Value.ToString();

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user confirmed the deletion
                if (result == DialogResult.Yes)
                {
                    // Delete query
                    string query = $"DELETE FROM Propertytype WHERE ID = '{id}'";

                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                con.Open();

                                // Execute the query
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Remove the selected row from the DataGridView
                        dataGridViewptinfo.Rows.Remove(selectedRow);
                        MessageBox.Show("Record deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}
