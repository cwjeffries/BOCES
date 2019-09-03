/*******************************************
 * Author: Chase Jeffries
 * Purpose: Form that allows user to upload
 *          images to database for either
 *          students, tasks, or teachers
 ******************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffries_BOCES1
{
    public partial class ManageImages : Form
    {
        private String connectionString;
        private SqlConnection connection;
        private String imageLocation;

        public ManageImages()
        {
            InitializeComponent();
            this.connectionString = Properties.Settings.Default.BOCESConnectionString;
            this.connection = new SqlConnection(this.connectionString);
            imageLocation = "";
        }

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Opens file browser to select desired picture
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFd = new OpenFileDialog();
                // Sets the file types that can be used for task and student pictures
                openFd.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                openFd.Title = "Choose an image";
                if (openFd.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFd.FileName.ToString();
                    picImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1:\n" + ex.Message);
            }
        }

        // Save button for student pictures
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                String sql = "UPDATE Students " +
                             "SET StudentPic = @pImage " +
                             "WHERE(StudentID = @pStudentID)";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand(sql, connection);
                // Takes the Id number placed in the text box for associating with student
                command.Parameters.AddWithValue("@pStudentID", txtID.Text);
                command.Parameters.AddWithValue("@pImage", img);
                int numRecords = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(numRecords.ToString() + " record(s) updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2:\n" + ex.Message);
                connection.Close();
            }
        }

        // Saves picture for task
        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                String sql = "UPDATE Tasks " +
                             "SET TaskPicture = @pImage " +
                             "WHERE(TaskID = @pTaskID)";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sql, connection);
                // Finds task id that user entered in text box
                command.Parameters.AddWithValue("@pTaskID", txtID.Text);
                command.Parameters.AddWithValue("@pImage", img);
                int numRecords = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(numRecords.ToString() + " record(s) updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 3:\n" + ex.Message);
                connection.Close();
            }
        }

        private void btnSaveTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                String sql = "UPDATE Teachers " +
                             "SET Picture = @pImage " +
                             "WHERE(TeacherID = @pTeacherID)";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sql, connection);
                // Finds task id that user entered in text box
                command.Parameters.AddWithValue("@pTeacherID", txtID.Text);
                command.Parameters.AddWithValue("@pImage", img);
                int numRecords = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(numRecords.ToString() + " record(s) updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 4:\n" + ex.Message);
                connection.Close();
            }
        }
    }
}
