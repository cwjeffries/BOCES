/*******************************************
 * Author: Chase Jeffries
 * Purpose: Form that allows admin to view
 *          update, add, and delete teachers
 *          from the database
 ******************************************/
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
    public partial class ManageTeacher : Form
    {
        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        // List of teachers for combo box and gridview display
        List<Teacher> teachers;

        Teacher teacher = new Teacher();

        // Generate connection string, connection object, and teachers list
        public ManageTeacher()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.BOCESConnectionString;
            connection = new SqlConnection(connectionString);
            teachers = new List<Teacher>();
        }

        // Form Load function
        private void ManageTeacher_Load(object sender, EventArgs e)
        {
            // string for the teacher name select Sql command
            string teacherNameSelect = "SELECT TeacherID, FirstName, LastName FROM Teachers";
            command = new SqlCommand(teacherNameSelect, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Teacher tempTeach = new Teacher();

                    tempTeach.TeacherID = reader["TeacherID"].ToString();
                    tempTeach.TeacherFirstName = reader["FirstName"].ToString();
                    tempTeach.TeacherLastName = reader["LastName"].ToString();

                    teachers.Add(tempTeach);
                }

                connection.Close();

                // Calls the function that will actually attempt to put the info gathered above together into the combo box
                loadTeacherNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1: \n" + ex.Message);
            }
        }

        // Uses a loop to put each teacher name that is in the database into the combo box at the top of the page
        private void loadTeacherNames()
        {
            foreach (Teacher aTeacher in teachers)
            {
                cboTeacherName.Items.Add(aTeacher.TeacherFirstName + " " + aTeacher.TeacherLastName);
            }
        }

        // Function for when a new item is selected in the combo box
        private void cboTeacherName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacherName = cboTeacherName.SelectedItem.ToString();

            // Gets the teacher ID if the teacher listed in the box actually has one
            string teachID = findTeacherID(selectedTeacherName);

            // Uses the teacher ID to determine whether it will call the function below or return an error
            if (teachID != "Not Found")
            {
                displayTeacherInfo(Int32.Parse(teachID));
            }
            else
            {
                MessageBox.Show("Error 2: \n");
            }
        }

        // Compares teacher name with the string gotton from the combo box
        private string findTeacherID(string pTeachName)
        {

            foreach (Teacher aTeach in teachers)
            {
                if (aTeach.TeacherFirstName + " " + aTeach.TeacherLastName == pTeachName)
                {
                    return aTeach.TeacherID;
                }
            }
            return "Not Found";
        }

        // Function to put the student info from the database into a gridview on the screen
        private void displayTeacherInfo(int pID)
        {
            string teacherInfoSelect = "SELECT TeacherID, FirstName, LastName, Email, Phone FROM Teachers";

            command = new SqlCommand(teacherInfoSelect, connection);
            grdTeacherDisplay.Rows.Clear();

            // Try catch that actually goes through and checks which students are listed under the given teacher ID by comparing the parameter to the database
            // and then if true putting those students' information into the gridview
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pTeacherID", pID);

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    string teacherID = reader["TeacherID"].ToString();
                    string tFirstName = reader["FirstName"].ToString();
                    string tLastName = reader["LastName"].ToString();
                    string tEmail = reader["Email"].ToString();
                    string tPhone = reader["Phone"].ToString();

                    grdTeacherDisplay.AllowUserToAddRows = false;
                    //grdStudentDisplay.RowTemplate.Height = 100;
                    grdTeacherDisplay.Rows.Add(teacherID, tFirstName, tLastName, tEmail, tPhone);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 3: \n" + ex.Message);
            }
            connection.Close();
        }

        // For use in adding teacher to database
        private void getTeacherInfo()
        {
            teacher.TeacherFirstName = txtFirstName.Text;
            teacher.TeacherLastName = txtLastName.Text;
            teacher.Email = txtEmail.Text;
            teacher.Phone = txtPhone.Text;
        }

        // Add button that adds teacher to database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string teacherInfoAdd = "INSERT INTO Teachers " +
                                    "(FirstName, LastName, Email, Phone) " +
                                    "VALUES(@pFirstName, @pLastName, @pEmail, @pPhone)";

            command = new SqlCommand(teacherInfoAdd, connection);

            // Using the text boxes this attempts to take the entered information and compile it into a new teacher record
            try
            {
                connection.Open();
                getTeacherInfo();
                command.Parameters.AddWithValue("pFirstName", teacher.TeacherFirstName);
                command.Parameters.AddWithValue("pLastName", teacher.TeacherLastName);
                command.Parameters.AddWithValue("pEmail", teacher.Email);
                command.Parameters.AddWithValue("pPhone", teacher.Phone);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Teacher has been added to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 4: \n" + ex.Message);
            }

            grdTeacherDisplay.Refresh();

            // Clears text boxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        // Update button that updates a teacher's information in database
        private void button2_Click(object sender, EventArgs e)
        {
            // Uses first and last name to determine which teacher is to be updated
            string teacherInfoUpdate = "UPDATE Teachers " +
                                       "SET FirstName = @pFirstName, LastName = @pLastName, " +
                                       "Email = @pEmail, Phone = @pPhone " +
                                       "WHERE(FirstName = @pFirstName) AND (LastName = @pLastName)";

            command = new SqlCommand(teacherInfoUpdate, connection);

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pFirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@pLastName", txtLastName.Text);
                command.Parameters.AddWithValue("@pEmail", txtEmail.Text);
                command.Parameters.AddWithValue("@pPhone", txtPhone.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Teacher has been updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 5: \n" + ex.Message);
            }

            grdTeacherDisplay.Refresh();

            // Clears text boxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        // Delete button that deletes teacher from database
        private void button3_Click(object sender, EventArgs e)
        {
            // Once again uses the first name and last name to determine who is to be deleted
            string teacherInfoDelete = "DELETE FROM Teachers " +
                                       "WHERE(FirstName = @pFirstName) AND " +
                                       "(LastName = @pLastName)";

            command = new SqlCommand(teacherInfoDelete, connection);

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pFirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@pLastName", txtLastName.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Teacher has been deleted from database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 6: \n" + ex.Message);
            }

            grdTeacherDisplay.Refresh();

            // Clears text boxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
