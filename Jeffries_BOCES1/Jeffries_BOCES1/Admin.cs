/*********************************
 * Author: Chase Jeffries
 * Purpose: Create application for adding users
 *          and managing tasks done by some users
 ********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Simply a menu screen for various functions of managing the database and other aspects
namespace Jeffries_BOCES1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        // Loads form for managing teachers
        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            ManageTeacher frmAddTeacher = new ManageTeacher();
            frmAddTeacher.ShowDialog();
        }

        // Loads form for managing students
        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudent frmStudent = new ManageStudent();
            frmStudent.ShowDialog();
        }

        // Loads form for managing tasks
        private void btnManageTasks_Click(object sender, EventArgs e)
        {
            AddTask frmTask = new AddTask();
            frmTask.ShowDialog();
        }

        // Loads form for generating reports
        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            ManageReports frmReports = new ManageReports();
            frmReports.ShowDialog();
        }

        // Loads form for adding pictures of tasks or students
        private void btnManageImage_Click(object sender, EventArgs e)
        {
            ManageImages frmImage = new ManageImages();
            frmImage.ShowDialog();
        }

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
