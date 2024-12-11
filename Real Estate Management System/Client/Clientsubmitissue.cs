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
    public partial class Clientsubmitissue : Form
    {
        public Clientsubmitissue()
        {
            InitializeComponent();
            string[] topic = new string[3];
            topic[0] = "Account";
            topic[1] = "Property";
            topic[2] = "Other";
            comboBoxcisutopic.DataSource = topic;
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Clientoverview clientoverview = new Clientoverview();
            clientoverview.Show();
            Visible = false;
        }

        private void buttoncisusubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; " +
                                   "integrated security = SSPI";

            string username = textBoxcisuusername.Text;
            string email = textBoxcisuemail.Text;
            string topic = comboBoxcisutopic.SelectedItem.ToString();
            string description = textBoxcisudescription.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(topic) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fillup all information.");
                return;
            }

            // Check if the provided username
            bool isValidUsername = false;
            string queryuser = "SELECT COUNT(*) FROM Clientinfo WHERE Username = @Username";

            using (SqlCommand cmd = new SqlCommand(queryuser, con))
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
            string query = $"INSERT INTO Isshueinfo (ID,Username,Email, Topic,Description) VALUES (@ID,@Username,@Email,@Topic,@Description)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Topic", topic);
                cmd.Parameters.AddWithValue("@Description", description);

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }

            MessageBox.Show("Issue submit successful!");
            // Perform actions after successful
            textBoxcisuusername.Clear();
            textBoxcisuemail.Clear();
            comboBoxcisutopic.SelectedIndex = -1;
            textBoxcisudescription.Clear();
        }
    }
}
