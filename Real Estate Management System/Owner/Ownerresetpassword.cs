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
    public partial class Ownerresetpassword : Form
    {
        private readonly string connectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; integrated security=SSPI";

        public Ownerresetpassword()
        {
            InitializeComponent();
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

        private void buttonrpoupdate_Click(object sender, EventArgs e)
        {
            string username = textBoxrpousername.Text;
            string currentPassword = textBoxrpocurrentpassword.Text;
            string newPassword = textBoxrponewpassword.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check username and pass
                    string query = "SELECT COUNT(*) FROM Ownerinfo WHERE Username = @Username AND Password = @Password";
                    query += " UNION ALL SELECT COUNT(*) FROM Employeeinfo WHERE Username = @Username AND Password = @Password";
                    query += " UNION ALL SELECT COUNT(*) FROM Clientinfo WHERE Username = @Username AND Password = @Password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", currentPassword);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        //update the password
                        query = "UPDATE Ownerinfo SET Password = @NewPassword WHERE Username = @Username";
                        query += " UPDATE Employeeinfo SET Password = @NewPassword WHERE Username = @Username";
                        query += " UPDATE Clientinfo SET Password = @NewPassword WHERE Username = @Username";

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
            textBoxrpousername.Clear();
            textBoxrpocurrentpassword.Clear();
            textBoxrponewpassword.Clear();
        }
    }
}
