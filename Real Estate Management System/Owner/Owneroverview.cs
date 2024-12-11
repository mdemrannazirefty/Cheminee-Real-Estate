using Real_Estate_Management_System.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Owner
{
    public partial class Owneroverview : Form
    {
        public Owneroverview()
        {
            InitializeComponent();
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owneraddproperty owneraddproperty = new Owneraddproperty();
            owneraddproperty.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ownerownerdetails ownerownerdetails = new Ownerownerdetails();
            ownerownerdetails.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ownerpropertyimage ownerpropertyimage = new Ownerpropertyimage();
            ownerpropertyimage.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ownerresetpassword ownerresetpassword = new Ownerresetpassword();
            ownerresetpassword.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ownersubmitissue ownersubmitissue = new Ownersubmitissue();
            ownersubmitissue.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ownerviewproposal ownerviewproposal = new Ownerviewproposal();
            ownerviewproposal.Show();
            Visible = false;
        }

        private void buttonpdelete_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Visible = false;
        }
    }
}
