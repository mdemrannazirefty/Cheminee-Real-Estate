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
    public partial class Ownercopyid : Form
    {
        public Ownercopyid()
        {
            InitializeComponent();
        }
        private Guid propertyId;
        public Ownercopyid(Guid id)
        {
            InitializeComponent();
            propertyId = id;
            richTextBoxpropertyid.Text = propertyId.ToString();
        }

        private void Ownercopyid_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxpropertyid_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttondone_Click(object sender, EventArgs e)
        {
            Owneraddproperty owneraddproperty = new Owneraddproperty();
            owneraddproperty.Show();
            Visible = false;
        }
    }
}
