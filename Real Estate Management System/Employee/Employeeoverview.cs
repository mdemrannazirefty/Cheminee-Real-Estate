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

namespace Real_Estate_Management_System.Employee
{
    public partial class Employeeoverview : Form
    {
        public Employeeoverview()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employeeemployeedetails employeeemployeedetails = new Employeeemployeedetails();
            employeeemployeedetails.Show();
            Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employeeclientdetails employeeclientdetails = new Employeeclientdetails();
            employeeclientdetails.Show();
            Visible = false;
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employeeownerdetails employeeownerdetails = new Employeeownerdetails();
            employeeownerdetails.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeProperty employeeProperty = new EmployeeProperty();
            employeeProperty.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employeepropertyimage employeepropertyimage = new Employeepropertyimage();
            employeepropertyimage.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employeeresetpassword employeeresetpassword = new Employeeresetpassword();
            employeeresetpassword.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employeeviewissue employeeviewissue = new Employeeviewissue();
            employeeviewissue.Show();
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
