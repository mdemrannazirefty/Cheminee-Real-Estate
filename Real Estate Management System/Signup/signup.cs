using Real_Estate_Management_System.Forms;
using Real_Estate_Management_System.Login;
using Real_Estate_Management_System.Owner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace Real_Estate_Management_System.Signup
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            string[] signupuser = new string[2];
            signupuser[0] = "Owner";
            signupuser[1] = "Client";
            comboBoxsupsignupas.DataSource = signupuser;

            string[] state = new string[3];
            state[0] = "Dhaka";
            state[1] = "Chittagong";
            state[2] = "Rajshahi";
            comboBoxssupstate.DataSource = state;
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; " +
                                   "integrated security = SSPI";

            string signupas = comboBoxsupsignupas.SelectedItem.ToString();
            string fname = textBoxsupfname.Text;
            string lname = textBoxsuplname.Text;
            string username = textBoxsupusername.Text;
            string email = textBoxsupemail.Text;
            string password = textBoxsuppassword.Text;
            string gender = string.Empty;
            gender = radioButtonsignupgender.Checked ? "Male" : "Female";
            string dob = dateTimePickersupdob.Value.ToString();
            string phone = textBoxsupphone.Text;
            string state = comboBoxssupstate.SelectedItem.ToString();
            string address = textBoxsupaddrss.Text;

            if (string.IsNullOrEmpty(signupas) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fillup all information.");
                return;
            }

            //Signup as owner/client
            string tableName = "";
            if (signupas == "Owner")
            {
                tableName = "Ownerinfo";
            }
            else if (signupas == "Client")
            {
                tableName = "Clientinfo";
            }
            else
            {
                MessageBox.Show("Invalid Signup type.");
                return;
            }

            Guid id = Guid.NewGuid();
            string query = $"INSERT INTO {tableName} (ID,FirstName,LastName,Username,Email, Password,Gender,Dob,Phone,State,Address) VALUES (@ID,@FirstName,@LastName,@Username,@Email,@Password,@Gender,@Dob,@Phone,@State,@Address)";

            //SqlCommand cmd = new SqlCommand(query, con);


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.AddWithValue("@ID", id);
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

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }

            MessageBox.Show("Signup successful!");

            comboBoxsupsignupas.SelectedIndex = -1;
            textBoxsupfname.Clear();
            textBoxsuplname.Clear();
            textBoxsupusername.Clear();
            textBoxsupemail.Clear();
            textBoxsuppassword.Clear();
            textBoxsupphone.Clear();
            comboBoxssupstate.SelectedIndex = -1;
            textBoxsupaddrss.Clear();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Visible = false;

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void textBoxsupaddrss_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
