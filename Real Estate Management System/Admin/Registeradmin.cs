using Real_Estate_Management_System.Forms;
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

namespace Real_Estate_Management_System.Admin
{
    public partial class Registeradmin : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Registeradmin()
        {
            InitializeComponent();
            LoadData();

            string[] state = new string[3];
            state[0] = "Dhaka";
            state[1] = "Chittagoan";
            state[2] = "Rajshahi";
            comboBoxrestate.DataSource = state;
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Admininfo";
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
                    dataGridViewadmin.DataSource = dataTable;
                }
            }

            // new column for delete option
            if (!dataGridViewadmin.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridViewadmin.Columns.Add(deleteButtonColumn);
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Overview overview = new Overview();
            overview.Show();
            Visible = false;
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonresubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; " +
                                   "integrated security = SSPI";

            string fname = textBoxrefname.Text;
            string lname = textBoxrelname.Text;
            string username = textBoxreusername.Text;
            string email = textBoxreemail.Text;
            string password = textBoxrepassword.Text;
            string gender = string.Empty;
            gender = radioButtonregender.Checked ? "Male" : "Female";
            string dob = dateTimePickerredob.Value.ToString();
            string phone = textBoxrephone.Text;
            string state = comboBoxrestate.SelectedItem.ToString();
            string address = textBoxreaddress.Text;

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fillup all information.");
                return;
            }

            Guid id = Guid.NewGuid();
            string query = $"INSERT INTO Admininfo (ID,FirstName,LastName,Username,Email, Password,Gender,Dob,Phone,State,Address) VALUES (@ID,@FirstName,@LastName,@Username,@Email,@Password,@Gender,@Dob,@Phone,@State,@Address)";


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@FirstName", fname);
                cmd.Parameters.AddWithValue("@LAstName", lname);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Dob", dob);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Address", address);

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }

            MessageBox.Show("Admin Add successful!!");

            // Perform actions after successful
            textBoxrefname.Clear();
            textBoxrelname.Clear();
            textBoxreusername.Clear();
            textBoxreemail.Clear();
            textBoxrepassword.Clear();
            textBoxrephone.Clear();
            comboBoxrestate.SelectedIndex = -1;
            textBoxreaddress.Clear();
        }

        private void buttonresearch_Click(object sender, EventArgs e)
        {
            string searchtext = textBoxreusersearch.Text;
            if (!string.IsNullOrWhiteSpace(searchtext))
            {
                string query = $"SELECT * FROM Admininfo WHERE ID LIKE '%{searchtext}%' OR Username LIKE '%{searchtext}%' OR Email LIKE '%{searchtext}%' OR Gender LIKE '%{searchtext}%'OR Phone LIKE '%{searchtext}%'OR State LIKE '%{searchtext}%'  ";
                FillDataGridView(query);
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        private void dataGridViewremployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewadmin.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dataGridViewadmin.Rows[e.RowIndex].Cells["ID"].Value.ToString(); // Assuming the ID column name is "ID"

                    // Enclose the ID value with single quotes in the SQL query
                    string query = $"DELETE FROM Admininfo WHERE ID = '{id}'";

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

                        dataGridViewadmin.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Record Delete successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonreedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string fname = textBoxrefname.Text;
            string lname = textBoxrelname.Text;
            string username = textBoxreusername.Text;
            string email = textBoxreemail.Text;
            string password = textBoxrepassword.Text;
            string gender = string.Empty;
            gender = radioButtonregender.Checked ? "Male" : "Female";
            string dob = dateTimePickerredob.Value.ToString();
            string phone = textBoxrephone.Text;
            string state = comboBoxrestate.SelectedItem.ToString();
            string address = textBoxreaddress.Text;
            try
            {
                // Update query string corrected
                string query = "UPDATE Admininfo SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Password=@Password, Gender=@Gender, Dob=@Dob, Phone=@Phone, State=@State, Address=@Address WHERE Username=@Username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", fname);
                    cmd.Parameters.AddWithValue("@LastName", lname); // Corrected from "@LAstName" to "@LastName"
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@State", state);
                    cmd.Parameters.AddWithValue("@Address", address);

                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful!");
                    }
                    else
                    {
                        MessageBox.Show("No records updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
