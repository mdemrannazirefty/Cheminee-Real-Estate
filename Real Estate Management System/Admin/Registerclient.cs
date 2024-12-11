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
    public partial class Registerclient : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Registerclient()
        {
            InitializeComponent();
            LoadData();
            string[] state = new string[3];
            state[0] = "Dhaka";
            state[1] = "Chittagoan";
            state[2] = "Rajshahi";
            comboBoxcdstate.DataSource = state;
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Clientinfo";
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
                    dataGridViewcdclient.DataSource = dataTable;
                }
            }

            // new column for delete option
            if (!dataGridViewcdclient.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridViewcdclient.Columns.Add(deleteButtonColumn);
            }
        }

        private void Registerclient_Load(object sender, EventArgs e)
        {

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

        private void buttoncdadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; " +
                                   "integrated security = SSPI";

            string fname = textBoxcdfirstname.Text;
            string lname = textBoxcdlastname.Text;
            string username = textBoxcdusername.Text;
            string email = textBoxcdemail.Text;
            string password = textBoxcdpassword.Text;
            string gender = string.Empty;
            gender = radioButtoncdgender.Checked ? "Male" : "Female";
            string dob = dateTimePickercddob.Value.ToString();
            string phone = textBoxcdphone.Text;
            string state = comboBoxcdstate.SelectedItem.ToString();
            string address = textBoxcdaddress.Text;

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fillup all information.");
                return;
            }

            Guid id = Guid.NewGuid();
            string query = $"INSERT INTO Clientinfo (ID,FirstName,LastName,Username,Email, Password,Gender,Dob,Phone,State,Address) VALUES (@ID,@FirstName,@LastName,@Username,@Email,@Password,@Gender,@Dob,@Phone,@State,@Address)";


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

            MessageBox.Show("Client Add successful!!");

            // Perform actions after successful
            textBoxcdfirstname.Clear();
            textBoxcdlastname.Clear();
            textBoxcdusername.Clear();
            textBoxcdemail.Clear();
            textBoxcdpassword.Clear();
            textBoxcdphone.Clear();
            comboBoxcdstate.SelectedIndex = -1;
            textBoxcdaddress.Clear();
        }

        private void buttoncdsearch_Click(object sender, EventArgs e)
        {
            string searchtext = textBoxcdsearch.Text;
            if (!string.IsNullOrWhiteSpace(searchtext))
            {
                string query = $"SELECT * FROM Clientinfo WHERE ID LIKE '%{searchtext}%' OR Username LIKE '%{searchtext}%' OR Email LIKE '%{searchtext}%' OR Gender LIKE '%{searchtext}%'OR Phone LIKE '%{searchtext}%'OR State LIKE '%{searchtext}%'  ";
                FillDataGridView(query);
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        private void dataGridViewcdclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewcdclient.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dataGridViewcdclient.Rows[e.RowIndex].Cells["ID"].Value.ToString(); // Assuming the ID column name is "ID"

                    // Enclose the ID value with single quotes in the SQL query
                    string query = $"DELETE FROM Clientinfo WHERE ID = '{id}'";

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

                        dataGridViewcdclient.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Record Delete successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void buttoncdupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string fname = textBoxcdfirstname.Text;
            string lname = textBoxcdlastname.Text;
            string username = textBoxcdusername.Text;
            string email = textBoxcdemail.Text;
            string password = textBoxcdpassword.Text;
            string gender = string.Empty;
            gender = radioButtoncdgender.Checked ? "Male" : "Female";
            string dob = dateTimePickercddob.Value.ToString();
            string phone = textBoxcdphone.Text;
            string state = comboBoxcdstate.SelectedItem.ToString();
            string address = textBoxcdaddress.Text;

            try
            {
                // Update query string corrected
                string query = "UPDATE Clientinfo SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Password=@Password, Gender=@Gender, Dob=@Dob, Phone=@Phone, State=@State, Address=@Address WHERE Username=@Username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", fname);
                    cmd.Parameters.AddWithValue("@LastName", lname);
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
