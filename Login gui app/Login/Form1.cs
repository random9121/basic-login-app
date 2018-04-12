using System;

using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        // checks to see if the credentials entered are the Admin
        private bool isAdmincheck(User user)
        {
            if (user.Username == user.adminusercheck)
            {
                if (user.Password == user.Adminpasscheck)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // makes the usertest object and sets the username and password
            //to the inputted ones
            User usertest = new User();
            usertest.Username = txtUserName.Text;
            usertest.Password = txtPassword.Text;

            // if the credentials entered are admin
            //notify the user they logged in
            if (isAdmincheck(usertest))
            {
                errormsg.Text = "Logged In";
                errormsg.Visible = true;


            }
            // else notify the user they entered the invalid credentials
            else
            {
                errormsg.Text = "Invalid Credentials";
                errormsg.Visible = true;
            }
        }
    }
}
