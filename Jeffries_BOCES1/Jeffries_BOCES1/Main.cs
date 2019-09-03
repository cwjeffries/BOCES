/*******************************************
 * Author: Chase Jeffries
 * Purpose: Form for the default menu that
 *          allows either a user to login
 *          or an admin to login and access
 *          various controls of application
 ******************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffries_BOCES1
{
    public partial class Main : Form
    {
        string versionNumber = "1.0.0";
        public Main()
        {
            InitializeComponent();
        }

        //Opens new window for display users
        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
            DisplayUsers frmDisplay = new DisplayUsers();
            frmDisplay.ShowDialog();
        }

        //Opens new window for adding students
        private void addStudent_Click(object sender, EventArgs e)
        {
            ManageStudent frmManage = new ManageStudent();
            frmManage.ShowDialog();
        }

        //Opens new window for adding teachers
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            ManageTeacher frmAddTeacher = new ManageTeacher();
            frmAddTeacher.ShowDialog();
        }

        // Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Opens window for admin controls
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Admin password for login
            string[] read = System.IO.File.ReadAllLines(@"Password.txt");

            string password = read[0];

            string pass = txtPassword.Text;

            if (pass == password)
            {
                Admin frmAdmin = new Admin();
                frmAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter the correct password");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version: " + versionNumber;
        }
    }
}
