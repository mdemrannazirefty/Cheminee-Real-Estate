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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Real_Estate_Management_System.GetStarted
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contribution contribution = new Contribution();
            contribution.Show();
            Visible = false;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttongetstarted_Click(object sender, EventArgs e)
        {
            LoginForm l=new LoginForm();
            l.Show();
            Visible=false;
        }
    }
}
