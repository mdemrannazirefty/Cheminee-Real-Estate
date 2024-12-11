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
    public partial class Ownerviewproposal : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Ownerviewproposal()
        {
            InitializeComponent();
            //LoadData();
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
                    dataGridViewviewproposal.DataSource = dataTable; // Correct name used here
                }
            }
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Owneroverview owneroverview = new Owneroverview();
            owneroverview.Show();
            Visible = false;
        }

        private void dataGridViewviewproposal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string searchtext = textBoxpropertyid.Text;
            if (!string.IsNullOrWhiteSpace(searchtext))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        //ID,Username,Fullname,Email,Phone,Offerprice,Requirment
                        string query = $"SELECT * FROM Submitproposalinfo WHERE ID LIKE '{searchtext}'";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                FillDataGridView(query);
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID. No matching records found.");
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
                MessageBox.Show("Please enter search ID");
            }
        }

        private void buttonreject_Click(object sender, EventArgs e)
        {
            if (dataGridViewviewproposal.SelectedRows.Count > 0) // Correct name used here
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewviewproposal.SelectedRows[0]; // Correct name used here

                // Retrieve the ID of the selected row
                string submitid = selectedRow.Cells["SubmitID"].Value.ToString();

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to reject this Proposal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user confirmed the deletion
                if (result == DialogResult.Yes)
                {
                    // Delete query
                    string query = $"DELETE FROM Submitproposalinfo WHERE SubmitID = '{submitid}'";

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
                        dataGridViewviewproposal.Rows.Remove(selectedRow);
                        MessageBox.Show("Proposal rejected successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Proposal to reject.");
            }
        }

        private void buttonaccept_Click(object sender, EventArgs e)
        {
            if (dataGridViewviewproposal.SelectedRows.Count > 0) 
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewviewproposal.SelectedRows[0];

                // Retrieve the ID of the selected row
                string submitid = selectedRow.Cells["SubmitID"].Value.ToString();

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to accept this Proposal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user confirmed the deletion
                if (result == DialogResult.Yes)
                {
                    // Delete query
                    string query = $"DELETE FROM Submitproposalinfo WHERE SubmitID = '{submitid}'";

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
                        dataGridViewviewproposal.Rows.Remove(selectedRow); // Correct name used here
                        MessageBox.Show("Proposal accepted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a proposal to accept.");
            }
        }
    }
}
