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

namespace Real_Estate_Management_System.Client
{
    public partial class Clientoverview : Form
    {
        public Clientoverview()
        {
            InitializeComponent();
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientclientdetails clientclientdetails = new Clientclientdetails();
            clientclientdetails.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clientpropertyimage clientpropertyimage = new Clientpropertyimage();
            clientpropertyimage.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clientresetpassword clientresetpassword = new Clientresetpassword();
            clientresetpassword.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clientsubmitissue clientsubmitissue = new Clientsubmitissue();
            clientsubmitissue.Show();
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
