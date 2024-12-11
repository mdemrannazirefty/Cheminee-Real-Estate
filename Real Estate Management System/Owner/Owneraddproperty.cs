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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_Estate_Management_System.Owner
{
    public partial class Owneraddproperty : Form
    {
        private readonly string connectionString = "data source=EFTY\\SQLEXPRESS; database=RealEstateManagementSystem; integrated security=SSPI";

        public Owneraddproperty()
        {
            InitializeComponent();
            /*
            string[] propertytype = new string[3];
            propertytype[0] = "Town";
            propertytype[1] = "Village";
            propertytype[2] = "Residential";
            comboBoxpropertytype.DataSource = propertytype; */
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonpadd_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxpowneruname.Text.Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string userQuery = "SELECT ID FROM Ownerinfo WHERE Username = @SearchTerm";

                        using (SqlCommand userCmd = new SqlCommand(userQuery, con))
                        {
                            userCmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                            using (SqlDataReader userReader = userCmd.ExecuteReader())
                            {
                                if (userReader.HasRows)
                                {
                                    userReader.Read();
                                    string userIdString = userReader["ID"].ToString(); // Convert to string
                                    Guid userId = Guid.Parse(userIdString); // Parse string to Guid
                                    userReader.Close();

                                    string propertytype = comboBoxpropertytype.SelectedItem.ToString();
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

                                    bool parking = checkBoxpparking.Checked;
                                    bool pool = checkBoxppool.Checked;
                                    Image photo = pictureBoxpphotoview.Image;

                                    if (string.IsNullOrEmpty(propertytype) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(address) || photo == null)
                                    {
                                        MessageBox.Show("Please fill up all information.");
                                        return;
                                    }

                                    Guid id = Guid.NewGuid();
                                    string query = $"INSERT INTO Propertyinfo (ID,Propertytype,Ownerusername,Size,Price,Address,Bedroom,Washroom,Parking,Pool,Photo) VALUES (@ID,@Propertytype,@Ownerusername,@Size,@Price,@Address,@Bedroom,@Washroom,@Parking,@Pool,@Photo)";

                                    using (SqlCommand cmd = new SqlCommand(query, con))
                                    {
                                        // Convert the image to a byte array
                                        byte[] photoBytes;
                                        using (MemoryStream stream = new MemoryStream())
                                        {
                                            photo.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                            photoBytes = stream.ToArray();
                                        }

                                        cmd.Parameters.AddWithValue("@ID", id);
                                        cmd.Parameters.AddWithValue("@Propertytype", propertytype);
                                        cmd.Parameters.AddWithValue("@Ownerusername", searchTerm);
                                        cmd.Parameters.AddWithValue("@Size", size);
                                        cmd.Parameters.AddWithValue("@Price", price);
                                        cmd.Parameters.AddWithValue("@Address", address);
                                        cmd.Parameters.AddWithValue("@Bedroom", bedroom);
                                        cmd.Parameters.AddWithValue("@Washroom", washroom);
                                        cmd.Parameters.AddWithValue("@Parking", parking);
                                        cmd.Parameters.AddWithValue("@Pool", pool);
                                        cmd.Parameters.AddWithValue("@Photo", photoBytes);

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Property added successfully! Copy your PropertyID");
                                        Ownercopyid ownercopyid = new Ownercopyid(id);
                                        ownercopyid.Show();

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
                                }
                                else
                                {
                                    MessageBox.Show("No matching user found.");
                                    textBoxpowneruname.Clear();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }

        private void buttonpphotobrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxpphotoview.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Owneraddproperty_Load(object sender, EventArgs e)
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

        private void buttonmyproperty_Click(object sender, EventArgs e)
        {
            Ownermyproperty myproperty = new Ownermyproperty();
            myproperty.Show();
            Visible = false;
        }

        private void comboBoxpropertytype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
