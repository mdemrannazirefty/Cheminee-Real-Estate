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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Real_Estate_Management_System.Login
{
    public partial class Forgetpasswordform : Form
    {
        private readonly string connectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; integrated security=SSPI";

        public Forgetpasswordform()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Visible = false;
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonfpgetpassword_Click(object sender, EventArgs e)
        {
            string username = textBoxfpusername.Text;
            string phone = textBoxfpphone.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check Ownerinfo table
                    string ownerQuery = "SELECT Password FROM Ownerinfo WHERE Username = @Username AND Phone = @Phone";
                    using (SqlCommand ownerCmd = new SqlCommand(ownerQuery, con))
                    {
                        ownerCmd.Parameters.AddWithValue("@Username", username);
                        ownerCmd.Parameters.AddWithValue("@Phone", phone);
                        object ownerResult = ownerCmd.ExecuteScalar();
                        if (ownerResult != null)
                        {
                            textBoxfppassword.Text = ownerResult.ToString();
                            textBoxfpusername.Clear();
                            textBoxfpphone.Clear();
                            return;
                        }
                    }

                    // Check Admininfo table
                    string adminQuery = "SELECT Password FROM Admininfo WHERE Username = @Username AND Phone = @Phone";
                    using (SqlCommand adminCmd = new SqlCommand(adminQuery, con))
                    {
                        adminCmd.Parameters.AddWithValue("@Username", username);
                        adminCmd.Parameters.AddWithValue("@Phone", phone);
                        object adminResult = adminCmd.ExecuteScalar();
                        if (adminResult != null)
                        {
                            textBoxfppassword.Text = adminResult.ToString();
                            return;
                        }
                    }

                    // Check Clientinfo table
                    string clientQuery = "SELECT Password FROM Clientinfo WHERE Username = @Username AND Phone = @Phone";
                    using (SqlCommand clientCmd = new SqlCommand(clientQuery, con))
                    {
                        clientCmd.Parameters.AddWithValue("@Username", username);
                        clientCmd.Parameters.AddWithValue("@Phone", phone);
                        object clientResult = clientCmd.ExecuteScalar();
                        if (clientResult != null)
                        {
                            textBoxfppassword.Text = clientResult.ToString();
                            return;
                        }
                    }

                    // Check Employeeinfo table
                    string employeeQuery = "SELECT Password FROM Employeeinfo WHERE Username = @Username AND Phone = @Phone";
                    using (SqlCommand employeeCmd = new SqlCommand(employeeQuery, con))
                    {
                        employeeCmd.Parameters.AddWithValue("@Username", username);
                        employeeCmd.Parameters.AddWithValue("@Phone", phone);
                        object employeeResult = employeeCmd.ExecuteScalar();
                        if (employeeResult != null)
                        {
                            textBoxfppassword.Text = employeeResult.ToString();
                            return;
                        }
                    }

                    MessageBox.Show("Incorrect input. Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Visible = false;
        }
    }
}
