using Real_Estate_Management_System.Signup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace Real_Estate_Management_System.Owner
{
    public partial class Ownersubmitissue : Form
    {
        public Ownersubmitissue()
        {
            InitializeComponent();
            string[] topic = new string[3];
            topic[0] = "Account";
            topic[1] = "Property";
            topic[2] = "Other";
            comboBoxisutopic.DataSource = topic;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

            string username = textBoxisuusername.Text;
            string email = textBoxisuemail.Text;
            string topic = comboBoxisutopic.SelectedItem?.ToString();
            string description = textBoxisudescription.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(topic) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill up all information.");
                return;
            }

            // Check if the provided username exists in the Ownerinfo table
            bool isValidUsername = false;
            string query = "SELECT COUNT(*) FROM Ownerinfo WHERE Username = @Username";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isValidUsername = true;
                }
                con.Close();
            }

            if (!isValidUsername)
            {
                MessageBox.Show("Invalid username. Please provide a valid username.");
                return;
            }

            Guid id = Guid.NewGuid();
            string insertQuery = "INSERT INTO Isshueinfo (ID, Username, Email, Topic, Description) " +
                                 "VALUES (@ID, @Username, @Email, @Topic, @Description)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Topic", topic);
                cmd.Parameters.AddWithValue("@Description", description);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Issue submitted successfully!");

            // Clear input fields after successful submission
            textBoxisuusername.Clear();
            textBoxisuemail.Clear();
            comboBoxisutopic.SelectedIndex = -1;
            textBoxisudescription.Clear();

        }
    }
}
