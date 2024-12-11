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

namespace Real_Estate_Management_System.Employee
{
    public partial class Employeepropertyimage : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Employeepropertyimage()
        {
            InitializeComponent();
            LoadData();
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
                    dataGridViewpropertytypeview.DataSource = dataTable;
                }
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

        private void dataGridViewpropertytypeview_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dataGridViewpropertytypeview.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            if (dataGridViewpropertytypeview.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewpropertytypeview.SelectedRows[0];

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
                        string query = $"SELECT Propertytype, Ownerusername, Size, Price, Address, Bedroom, Washroom, Parking, Pool FROM Propertyinfo WHERE Propertytype Like '%{selectedPropertyType}%'";

                        // Create a SqlDataAdapter to fetch data from the database
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                        // Create a DataTable to hold the fetched data
                        DataTable dt = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dataGridViewpropertyalldetails.DataSource = dt;

                        // Retrieve photo data
                        string photoQuery = $"SELECT Photo FROM Propertyinfo WHERE Propertytype Like '%{selectedPropertyType}%'";
                        SqlCommand photoCommand = new SqlCommand(photoQuery, con);
                        byte[] photoBytes = (byte[])photoCommand.ExecuteScalar();

                        // Convert byte array to image
                        using (MemoryStream ms = new MemoryStream(photoBytes))
                        {
                            pictureBoxpropertyimageview.Image = Image.FromStream(ms);
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
                MessageBox.Show("Please select a property type from the list.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewpropertytypeview.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewpropertytypeview.SelectedRows[0];

                // Retrieve the property type from the selected row
                string selectedPropertyType = selectedRow.Cells["Propertytype"].Value.ToString();

                // Display the selected property type
                MessageBox.Show($"Selected property type to remove: {selectedPropertyType}");

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        con.Open();

                        // Define your query to delete property information
                        string query = $"DELETE FROM Propertyinfo WHERE Propertytype LIKE '%{selectedPropertyType}%'";

                        // Create a SqlCommand
                        SqlCommand cmd = new SqlCommand(query, con);

                        // Execute the delete query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the delete was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Property information deleted successfully.");
                            // Refresh the data in the DataGridView
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete property information.");
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
                MessageBox.Show("Please select a property type from the list.");
            }
        }
    }
}
