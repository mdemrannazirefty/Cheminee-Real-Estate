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
    public partial class Ownerownerdetails : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Ownerownerdetails()
        {
            InitializeComponent();

            string[] state = new string[3];
            state[0] = "Dhaka";
            state[1] = "Chittagong";
            state[2] = "Rajshahi";
            comboBox1.DataSource = state;
        }

        private void LoadClientData(string username)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT FirstName, LastName, Username, Email, Gender, Dob, Phone, State, Address FROM Ownerinfo WHERE Username = @Username";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Username", username);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox6.Text;
            string username = textBox5.Text;
            string email = textBox4.Text;
            string password = textBox3.Text;
            string gender = radioButtoncdgender.Checked ? "Male" : "Female";
            string dob = dateTimePickercddob.Value.ToString("yyyy-MM-dd");
            string phone = textBox9.Text;
            string state = comboBox1.SelectedItem.ToString();
            string address = textBox11.Text;

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill up all information.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE Ownerinfo SET FirstName = @FirstName, LastName = @LastName, Email = @Email, " +
                                   "Password = @Password, Gender = @Gender, Dob = @Dob, Phone = @Phone, State = @State, " +
                                   "Address = @Address WHERE Username = @Username";

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

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                            LoadClientData(username);
                        }
                        else
                        {
                            MessageBox.Show("No records updated. Please check the username.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
