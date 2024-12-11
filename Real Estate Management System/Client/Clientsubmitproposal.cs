using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace Real_Estate_Management_System.Client
{
    public partial class Clientsubmitproposal : Form
    {
        private readonly string connectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; integrated security=SSPI";

        public Clientsubmitproposal()
        {
            InitializeComponent();
        }

        private void Clientsubmitproposal_Load(object sender, EventArgs e)
        {

        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Clientpropertyimage clientpropertyimage = new Clientpropertyimage();
            clientpropertyimage.Show();
            Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; " +
                                   "integrated security = SSPI";

            string propertyid = textBoxpropertyid.Text;
            string username = textBoxusername.Text;
            string fullname = textBoxfullname.Text;
            string email = textBoxemail.Text;
            string phone = textBoxphone.Text;
            string offerprice = textBoxofferprice.Text;
            string requirment = textBoxreq.Text;

            if (string.IsNullOrEmpty(propertyid) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(offerprice))
            {
                MessageBox.Show("Please fillup all information.");
                return;
            }
            // Check provided ID and Username matching
            bool isMatch = false;
            string querycheckid = "SELECT COUNT(*) FROM Propertyinfo WHERE ID = @ID";

            using (SqlCommand cmd = new SqlCommand(querycheckid, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@ID", propertyid);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isMatch = true;
                }
                con.Close();
            }

            if (!isMatch)
            {
                MessageBox.Show("The provided ID do not match.");
                return;
            } 
            // Check provided Username matching


            //For id
            Guid submitID = Guid.NewGuid();

            string query = $"INSERT INTO Submitproposalinfo (SubmitID,ID,Username,Fullname,Email,Phone,Offerprice,Requirment) VALUES (@SubmitID,@ID,@Username,@Fullname,@Email,@Phone,@Offerprice,@Requirment)";


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.AddWithValue("@SubmitID", submitID);
                cmd.Parameters.AddWithValue("@ID", propertyid);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Fullname", fullname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Offerprice", offerprice);
                cmd.Parameters.AddWithValue("@Requirment", requirment);

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }
            MessageBox.Show("Proposal Submited successful!");

            textBoxpropertyid.Clear();
            textBoxusername.Clear();
            textBoxfullname.Clear();
            textBoxemail.Clear();
            textBoxphone.Clear();
            textBoxofferprice.Clear();
            textBoxreq.Clear();

            Clientoverview clientoverview = new Clientoverview();
            clientoverview.Show();
            Visible = false;

        }

        private void textBoxreq_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
