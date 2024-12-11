using Real_Estate_Management_System.Admin;
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

namespace Real_Estate_Management_System.Forms
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registerowner ro = new Registerowner();
            ro.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registerclient rc = new Registerclient();
            rc.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Registeremployee re = new Registeremployee();
            re.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Propertytype pt = new Propertytype();
            pt.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Property p = new Property();
            p.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Propertyimage propertyimage = new Propertyimage();
            propertyimage.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminviewissue adminviewissue = new Adminviewissue();
            adminviewissue.Show();
            Visible = false;
        }

        private void buttonadministrator_Click(object sender, EventArgs e)
        {
            Registeradmin registeradmin = new Registeradmin();
            registeradmin.Show();
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
