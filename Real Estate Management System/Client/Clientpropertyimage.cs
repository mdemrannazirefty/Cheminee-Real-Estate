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

namespace Real_Estate_Management_System.Client
{
    public partial class Clientpropertyimage : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Clientpropertyimage()
        {
            InitializeComponent();
            LoadData();
            button1.Enabled = false;
        }
        private void LoadData()
        {
            string query = "SELECT Propertytype FROM Propertytype";
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
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Clientoverview clientoverview = new Clientoverview();
            clientoverview.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Property is Selected !!");
            Clientsubmitproposal clientsubmitproposal = new Clientsubmitproposal();
            clientsubmitproposal.Show();
            Visible = false;
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve the property type from the selected row
                string selectedPropertyType = selectedRow.Cells["Propertytype"].Value.ToString();

                // Display the selected property type
                MessageBox.Show($"Selected property type: {selectedPropertyType}");

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        con.Open();

                        // Define your query to retrieve all records from Propertytype table
                        string query = $"SELECT Propertytype, Ownerusername, Size, Price, Address, Bedroom, Washroom, Parking, Pool, ID FROM Propertyinfo WHERE Propertytype Like '%{selectedPropertyType}%'";

                        // Create a SqlDataAdapter to fetch data from the database
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                        // Create a DataTable to hold the fetched data
                        DataTable dt = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dataGridView3.DataSource = dt;

                        // Retrieve photo data

                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a property type from the list.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView3.SelectedRows[0];

                // Retrieve the property ID from the selected row
                string propertyID = selectedRow.Cells["ID"].Value.ToString();

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        con.Open();

                        // Retrieve photo data
                        string photoQuery = $"SELECT Photo FROM Propertyinfo WHERE ID = '{propertyID}'";
                        SqlCommand photoCommand = new SqlCommand(photoQuery, con);
                        object photoResult = photoCommand.ExecuteScalar();

                        if (photoResult != null)
                        {
                            // Photo data found, convert byte array to image
                            byte[] photoBytes = (byte[])photoResult;
                            using (MemoryStream ms = new MemoryStream(photoBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                                button1.Enabled = true;
                            }
                        }
                        else
                        {
                            // No photo data found
                            MessageBox.Show("No photo available for this property.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a property from the list.");
            }


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientpropertyimage_Load(object sender, EventArgs e)
        {

        }
    }
}
