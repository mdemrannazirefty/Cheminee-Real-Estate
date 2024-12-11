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
    public partial class Clientresetpassword : Form
    {
        private readonly string connectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; integrated security=SSPI";

        public Clientresetpassword()
        {
            InitializeComponent();
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Clientoverview clientoverview = new Clientoverview();
            clientoverview.Show();
        }

        private void Clientresetpassword_Load(object sender, EventArgs e)
        {

        }

        private void buttonrpupdate_Click(object sender, EventArgs e)
        {
            string username = textBoxrpusername.Text;
            string currentPassword = textBoxrpcurrentpassword.Text;
            string newPassword = textBoxrpnewpassword.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check username and pass
                    string query = "SELECT COUNT(*) FROM Clientinfo WHERE Username = @Username AND Password = @Password";
                    query += " UNION ALL SELECT COUNT(*) FROM Ownerinfo WHERE Username = @Username AND Password = @Password";
                    query += " UNION ALL SELECT COUNT(*) FROM Employeeinfo WHERE Username = @Username AND Password = @Password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", currentPassword);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // If a matching record is found, update the password
                        query = "UPDATE Clientinfo SET Password = @NewPassword WHERE Username = @Username";
                        query += " UPDATE Ownerinfo SET Password = @NewPassword WHERE Username = @Username";
                        query += " UPDATE Employeeinfo SET Password = @NewPassword WHERE Username = @Username";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            // Perform actions after successful
            textBoxrpusername.Clear();
            textBoxrpcurrentpassword.Clear();
            textBoxrpnewpassword.Clear();
        }
    }
}
