using Real_Estate_Management_System.Admin;
using Real_Estate_Management_System.Client;
using Real_Estate_Management_System.Employee;
using Real_Estate_Management_System.Forms;
using Real_Estate_Management_System.GetStarted;
using Real_Estate_Management_System.Login;
using Real_Estate_Management_System.Owner;
using Real_Estate_Management_System.Signup;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //**************************** START FROM HERE *******************************

            Application.Run(new Start());
            //Application.Run(new Contribution());
            //Application.Run(new LoginForm());
            //Application.Run(new Forgetpasswordform());
            //Application.Run(new signup());

            //**admin**
            //Application.Run(new Overview());
            //Application.Run(new Registeradmin());
            //Application.Run(new Registerowner());
            //Application.Run(new Registerclient());
            //Application.Run(new Registeremployee());
            //Application.Run(new Property());
            //Application.Run(new Propertytype());
            //Application.Run(new Adminviewissue());

            //**Employee**
            //Application.Run(new Employeeoverview());
            //Application.Run(new Employeeclientdetails());
            //Application.Run(new Employeeemployeedetails());
            //Application.Run(new EmployeeProperty());
            //Application.Run(new Employeeownerdetails());
            //Application.Run(new Employeepropertyimage());
            //Application.Run(new Employeeviewissue());
            //Application.Run(new Employeeresetpassword());

            //**Owner**
            //Application.Run(new Owneroverview());
            //Application.Run(new Ownerownerdetails()); 
            //Application.Run(new Owneraddproperty());
            //Application.Run(new Ownermyproperty());
            //Application.Run(new Ownercopyid());
            //Application.Run(new Ownerviewproposal());
            //Application.Run(new Ownersubmitissue());
            //Application.Run(new Ownerresetpassword());


            //**Client**
            //Application.Run(new Clientoverview());
            //Application.Run(new Clientclientdetails());
            //Application.Run(new Clientsubmitissue());
            //Application.Run(new Clientresetpassword());
            //Application.Run(new Clientpropertyimage());
            //Application.Run(new Clientsubmitproposal());


        }
    }
}