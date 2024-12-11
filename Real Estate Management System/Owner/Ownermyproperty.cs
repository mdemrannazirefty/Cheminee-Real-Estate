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

namespace Real_Estate_Management_System.Owner
{
    public partial class Ownermyproperty : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Ownermyproperty()
        {
            InitializeComponent();
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
                    dataGridViewviewproposal.DataSource = dataTable;
                }
            }
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Owneraddproperty owneraddproperty = new Owneraddproperty();
            owneraddproperty.Show();
            Visible = false;
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            string searchtext = textBoxusername.Text;
            if (!string.IsNullOrWhiteSpace(searchtext))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string query = $"SELECT * FROM Propertyinfo WHERE Ownerusername LIKE '{searchtext}'";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                FillDataGridView(query);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username. No matching records found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter Username");
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewviewproposal.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                string selectedID = dataGridViewviewproposal.SelectedRows[0].Cells["ID"].Value.ToString();

                // Confirm with the user before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this property?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();

                            // Execute the DELETE statement
                            string query = $"DELETE FROM Propertyinfo WHERE ID = '{selectedID}'";
                            using (SqlCommand command = new SqlCommand(query, con))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    // If deletion is successful, update the DataGridView
                                    MessageBox.Show("Property delete successfully.");
                                    string searchtext = textBoxusername.Text;
                                    if (!string.IsNullOrWhiteSpace(searchtext))
                                    {
                                        string searchQuery = $"SELECT * FROM Propertyinfo WHERE Ownerusername LIKE '{searchtext}'";
                                        FillDataGridView(searchQuery);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete Property. Please try again.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a proposal to reject/delete.");
            }
        }
    }
}
