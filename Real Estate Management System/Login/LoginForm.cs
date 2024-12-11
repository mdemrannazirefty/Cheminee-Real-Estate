using Real_Estate_Management_System.Client;
using Real_Estate_Management_System.Employee;
using Real_Estate_Management_System.Forms;
using Real_Estate_Management_System.Owner;
using Real_Estate_Management_System.Signup;
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

namespace Real_Estate_Management_System.Login
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; integrated security=SSPI";
        public LoginForm()
        {
            InitializeComponent();
            //password hide
            textBoxlgnpassword.PasswordChar = '*';

            string[] loginuser = new string[4];
            loginuser[0] = "Admin";
            loginuser[1] = "Employee";
            loginuser[2] = "Owner";
            loginuser[3] = "Client";

            comboBoxloginas.DataSource = loginuser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxlgnusername.Text;
            string password = textBoxlgnpassword.Text;
            string loginas = comboBoxloginas.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(loginas))
            {
                MessageBox.Show("Please fillup all information.");
                return;
            }
            //Login as
            string tablename = "";
            Form nextForm = null;
            switch (loginas)
            {
                case "Owner":
                    tablename = "Ownerinfo";
                    nextForm = new Owneroverview();
                    break;
                case "Client":
                    tablename = "Clientinfo";
                    nextForm = new Clientoverview();
                    break;
                case "Admin":
                    tablename = "Admininfo";
                    nextForm = new Overview();
                    break;
                case "Employee":
                    tablename = "Employeeinfo";
                    nextForm = new Employeeoverview();
                    break;
                default:
                    MessageBox.Show("Invalid user type selected.");
                    return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = $"SELECT COUNT(*) FROM {tablename} WHERE Username = @Username AND Password = @Password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Thanks");
                        // Perform actions after successful login
                        textBoxlgnusername.Clear();
                        textBoxlgnpassword.Clear();
                        comboBoxloginas.SelectedIndex = -1;

                        // Show the next form
                        if (nextForm != null)
                            nextForm.Show();
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            signup s = new signup();
            s.Show();
            Visible = false;
        }

        private void checkBoxlgnshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            //password visibility
            if (checkBoxlgnshowpassword.Checked)
            {
                textBoxlgnpassword.PasswordChar = '\0'; //show the password
            }
            else
            {
                textBoxlgnpassword.PasswordChar = '*'; //Mask the password
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forgetpasswordform forgetpasswordform = new Forgetpasswordform();
            forgetpasswordform.Show();
            Visible = false;
        }

        private void comboBoxloginas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
