/*******************************************
 * Author: Chase Jeffries
 * Purpose: Form that displays current users
 *          name and allows them to select
 *          a task to complete and stores
 *          the data in the database
 ******************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Jeffries_BOCES1
{
    public partial class SelectTask : Form
    {
        // Variable for DateTime function
        int count = 0;

        int id;
        string first;
        string last;
        string start;
        string end;

        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        // List of tasks for combo box
        List<Task> tasks;

        public SelectTask(string pid, string pfirst, string plast)
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.BOCESConnectionString;
            connection = new SqlConnection(connectionString);
            tasks = new List<Task>();

            id = int.Parse(pid);
            first = pfirst;
            last = plast;
        }

        // Load function for selectTask
        private void SelectTask_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;

            lblFirst.Text = first;
            lblLast.Text = last;

            // Automatically hides button
            btnBegin.Visible = false;

            string taskNameSelect = "SELECT TaskID, TaskName FROM Tasks";
            command = new SqlCommand(taskNameSelect, connection);

            // Attempts to access database and retrieve task name and taskID
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Task tempTask = new Task();

                    tempTask.TaskID = reader["TaskID"].ToString();
                    tempTask.TaskName = reader["TaskName"].ToString();

                    tasks.Add(tempTask);
                }
                connection.Close();

                loadTaskNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1: \n" + ex);
            }
        }

        // When called it will take the task name from the database and put any retrieved into the combo box
        private void loadTaskNames()
        {
            foreach (Task aTask in tasks)
            {
                cboTaskDisplay.Items.Add(aTask.TaskName);
            }

            cboTaskDisplay.SelectedIndex = 0;
        }

        private string findTaskID(string pTaskName)
        {
            foreach (Task aTask in tasks)
            {
                if (aTask.TaskName == pTaskName)
                {
                    return aTask.TaskID;
                }
            }
            return "Not Found!";
        }

        // Displays the begin task button once a task has been selected
        private void cboTaskDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBegin.Visible = true;

            string selectedTaskName = cboTaskDisplay.SelectedItem.ToString();

            string taskid = findTaskID(selectedTaskName);
            txtTaskId.Text = taskid;

            // Attempts to place the image of the task selected into a picture box display
            try
            {
                byte[] picture;

                string taskPic = "SELECT TaskPicture FROM Tasks WHERE(TaskID = @pTaskID)";
                command = new SqlCommand(taskPic, connection);

                connection.Open();

                command.Parameters.AddWithValue("@pTaskID", taskid);

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    picture = (byte[])reader["TaskPicture"];

                    MemoryStream mStream = new MemoryStream();
                    byte[] pData = picture;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    mStream.Dispose();

                    picTask.SizeMode = PictureBoxSizeMode.StretchImage;
                    picTask.Image = bm;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2:\n" + ex.Message);
            }
        }

        // Closes the form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button to begin and end task
        private void btnBegin_Click(object sender, EventArgs e)
        {

            // Changes title to help user determine if they have begun a task
            btnBegin.Text = "End Task";

            count++;

            // Sets the current date and time to a label for display
            if (count == 1)
            {
                //btnSave.Enabled = false;

                lblEnd.Text = "End Time:";

                start = DateTime.Now.ToString("hh:mm:ss tt");
                lblStart.Text = "Start Time: " + start;
            }

            // Sets the current date and time to a label for display as the end
            // and changes the button text back to begin
            if (count == 2)
            {
                end = DateTime.Now.ToString("hh:mm:ss tt");
                lblEnd.Text = "End Time: " + end;

                btnBegin.Text = "Begin Task";

                count = 0;

                saveRecord(start, end);
                MessageBox.Show("Record File has been saved");

                //btnSave.Enabled = true;
            }
        }

        // Function for saving record to database
        private void saveRecord(string pStart, string pEnd)
        {
            int tID = int.Parse(txtTaskId.Text);
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            string recordTask = "INSERT INTO StudentTaskAndTimes " +
                                "(StudentID, StudentName, TaskID, TaskName, Date, StartTime, EndTime) " +
                                "VALUES(@pStudentID, @pStudentName, @pTaskID, @pTaskName, @pDate, @pStart, @pEnd)";

            command = new SqlCommand(recordTask, connection);

            // Attempts to store user's task id and their time worked into the database
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@pStudentID", id);
                command.Parameters.AddWithValue("@pStudentName", first + " " + last);
                command.Parameters.AddWithValue("@pTaskID", tID);
                command.Parameters.AddWithValue("@pTaskName", cboTaskDisplay.SelectedItem.ToString());
                command.Parameters.AddWithValue("@pDate", date);
                command.Parameters.AddWithValue("@pStart", pStart);
                command.Parameters.AddWithValue("@pEnd", pEnd);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Record saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 3:\n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveRecord(start, end);
        }
    }
}
