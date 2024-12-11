using Real_Estate_Management_System.Forms;
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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Real_Estate_Management_System.Admin
{
    public partial class Property : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Property()
        {
            InitializeComponent();
            /*
            string[] propertytype = new string[3];
            propertytype[0] = "Town";
            propertytype[1] = "Village";
            propertytype[2] = "Residential";
            comboBoxpropertytype.DataSource = propertytype; */
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Propertyinfo";
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
                    dataGridViewviewp.DataSource = dataTable;
                }
            }
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

        private void Property_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmdfrtype = new SqlCommand("Select ID, Propertytype from Propertytype", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdfrtype;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBoxpropertytype.DataSource = table1;
            comboBoxpropertytype.DisplayMember = "Propertytype";
            comboBoxpropertytype.ValueMember = "ID";
        }

        private void buttonpupdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonpadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =EFTY\\SQLEXPRESS; database =RealEstateManagementSystem; " +
                                   "integrated security = SSPI";

            string propertytype = comboBoxpropertytype.SelectedItem.ToString();
            string ownerusername = textBoxpowneruname.Text;
            string size = textBoxpsize.Text;
            string price = textBoxpprice.Text;
            string address = textBoxpaddress.Text;
            int bedroom = (int)numericUpDownpbedroom.Value;
            int washroom = (int)numericUpDownpwashroom.Value;

            if (bedroom <= 0 || washroom <= 0)
            {
                MessageBox.Show("Please enter valid values for Bedroom and Washroom.");
                return;
            }
            Boolean parking = checkBoxpparking.Checked;
            Boolean pool = checkBoxppool.Checked;
            System.Drawing.Image photo = pictureBoxpphotoview.Image;

            if (string.IsNullOrEmpty(propertytype) || string.IsNullOrEmpty(ownerusername) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(address) || photo == null)
            {
                MessageBox.Show("Please fill up all information.");
                return;
            }

            Guid id = Guid.NewGuid();
            string query = $"INSERT INTO Propertyinfo (ID,Propertytype,Ownerusername,Size,Price,Address,Bedroom,Washroom,Parking,Pool,Photo) VALUES (@ID,@Propertytype,@Ownerusername,@Size,@Price,@Address,@Bedroom,@Washroom,@Parking,@Pool,@Photo)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Opening the connection:
                con.Open();

                // Convert the image to a byte array
                byte[] photoBytes;
                using (MemoryStream stream = new MemoryStream())
                {
                    photo.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    photoBytes = stream.ToArray();
                }

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Propertytype", propertytype);
                cmd.Parameters.AddWithValue("@Ownerusername", ownerusername);
                cmd.Parameters.AddWithValue("@Size", size);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Bedroom", bedroom);
                cmd.Parameters.AddWithValue("@Washroom", washroom);
                cmd.Parameters.AddWithValue("@Parking", parking);
                cmd.Parameters.AddWithValue("@Pool", pool);
                cmd.Parameters.AddWithValue("@Photo", photoBytes);

                cmd.ExecuteNonQuery();

                // Disconnect
                con.Close();
            }

            MessageBox.Show("Property add successful!");

            //Clear all
            comboBoxpropertytype.SelectedIndex = -1;
            textBoxpowneruname.Clear();
            textBoxpsize.Clear();
            textBoxpprice.Clear();
            textBoxpaddress.Clear();
            numericUpDownpbedroom.Value = 0;
            numericUpDownpwashroom.Value = 0;
            checkBoxpparking.Checked = false;
            checkBoxppool.Checked = false;
            pictureBoxpphotoview.Image = null;

        }

        private void buttonpphotobrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxpphotoview.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonpviewall_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Open the connection
                    con.Open();

                    // Define your query to retrieve all records from Propertytype table
                    string query = "SELECT * FROM Propertyinfo";

                    // Create a SqlDataAdapter to fetch data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                    // Create a DataTable to hold the fetched data
                    DataTable dt = new DataTable();

                    // Fill the DataTable with data from the SqlDataAdapter
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridViewviewp.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonpdelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewviewp.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewviewp.SelectedRows[0];

                // Retrieve the ID of the selected row
                string id = selectedRow.Cells["ID"].Value.ToString();

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user confirmed the deletion
                if (result == DialogResult.Yes)
                {
                    // Delete query
                    string query = $"DELETE FROM Propertyinfo WHERE ID = '{id}'";

                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                con.Open();

                                // Execute the query
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Remove the selected row from the DataGridView
                        dataGridViewviewp.Rows.Remove(selectedRow);
                        MessageBox.Show("Record deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string searchtext = textBoxsearch.Text;
            if (!string.IsNullOrWhiteSpace(searchtext))
            {
                string query = $"SELECT * FROM Propertyinfo WHERE ID LIKE '%{searchtext}%' OR Ownerusername LIKE '%{searchtext}%' OR Propertytype LIKE '%{searchtext}%'OR Size LIKE '%{searchtext}%' OR Price LIKE '%{searchtext}%'";
                FillDataGridView(query);
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        private void dataGridViewviewp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxpphotoview_Click(object sender, EventArgs e)
        {

        }
    }
}
