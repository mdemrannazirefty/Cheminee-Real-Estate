using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.GetStarted
{
    public partial class Contribution : Form
    {
        public Contribution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Contribution_Load(object sender, EventArgs e)
        {

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Start s = new Start();
            s.Show();
            Visible=false;
        }
    }
}
