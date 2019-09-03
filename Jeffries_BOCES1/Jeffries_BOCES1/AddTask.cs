/*********************************
 * Author: Chase Jeffries
 * Purpose: Create application for adding users
 *          and managing tasks done by some users
 ********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffries_BOCES1
{
    public partial class AddTask : Form
    {
        // Objects for sql commands
        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        
        // List object for tasks to be displayed
        List<Task> tasks;

        Task task = new Task();

        // Default with sql and list initialization
        public AddTask()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.BOCESConnectionString;
            connection = new SqlConnection(connectionString);
            tasks = new List<Task>();
        }

        // Displays the task names in a datagrid view
        private void displayTaskInfo()
        {
            string taskInfoSelect = "SELECT TaskName FROM Tasks";

            command = new SqlCommand(taskInfoSelect, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    string taskName = reader["TaskName"].ToString();

                    grdTasks.Rows.Add(taskName);
                }
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        // Calls function above when the form loads
        private void AddTask_Load(object sender, EventArgs e)
        {
            displayTaskInfo();
        }

        // Gets task name
        private void getTaskInfo()
        {
            task.TaskName = txtTaskName.Text;
        }

        // Button allows user to attempt at adding a new task into the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskInfoAdd = "INSERT INTO Tasks " +
                                 "(TaskName) VALUES(@pTaskName)";

            command = new SqlCommand(taskInfoAdd, connection);

            try
            {
                connection.Open();
                getTaskInfo();
                command.Parameters.AddWithValue("pTaskName", task.TaskName);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Task has been added to the database");
            }
            catch (Exception ex)
            {

            }

            txtTaskName.Text = "";
        }

        // Allows user to attempt deleting a task from database using the task's name
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string taskInfoDelete = "DELETE FROM Tasks " +
                                    "WHERE(TaskName = @pTaskName)";

            command = new SqlCommand(taskInfoDelete, connection);

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pTaskName", txtTaskName.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Task has been deleted from database");
            }
            catch (Exception ex)
            {

            }

            txtTaskName.Text = "";
        }

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
