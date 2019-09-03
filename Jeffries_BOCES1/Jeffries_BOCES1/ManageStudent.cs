/*******************************************
 * Author: Chase Jeffries
 * Purpose: Form that displays options for
 *          viewing, adding, updating, and 
 *          deleting student records to/from
 *          the database
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
    public partial class ManageStudent : Form
    {
        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        // List of teachers for combo box and gridview display
        List<Teacher> teachers;

        // Students object for display and button use
        Student students = new Student();

        // Generate connection string, connection object, and teachers list
        public ManageStudent()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.BOCESConnectionString;
            connection = new SqlConnection(connectionString);
            teachers = new List<Teacher>();
        }

        // Form Load function
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            // Tooltip that displays when the user mouses over the Add button for a brief description
            ToolTip tooltip3 = new ToolTip();
            tooltip3.ShowAlways = true;
            tooltip3.SetToolTip(this.btnAdd, "Before clicking please fill in each of the text boxes in the info " +
                                             "group above");

            // Tooltip that displays when the user mouses over the Update button for a brief description
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnUpdate, "Before clicking please enter the prefered students' \n" + 
                                                "first name and last namein the name text box \n" +
                                                "in the Enter Student Info group above");

            // Tooltip that displays when the user mouses over the Delete button for a brief description
            ToolTip tooltip2 = new ToolTip();
            tooltip2.ShowAlways = true;
            tooltip2.SetToolTip(this.btnDelete, "Before clicking please enter just the student's " +
                                                "first and last name into the name field's in the Info group above");

            // string for the teacher name select Sql command
            string teacherNameSelect = "SELECT TeacherID, FirstName, LastName FROM Teachers";
            command = new SqlCommand(teacherNameSelect, connection);

            // This try catch begins the attempt at putting the teacher name into the combo box
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
                displayStudentInfo(Int32.Parse(teachID));
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
        private void displayStudentInfo(int pID)
        {
            string studentInfoSelect = "SELECT Students.StudentID, Students.FirstName, Students.LastName, " +
                "Students.Age, Students.ClassYear, Students.StudentPic, Students.TeacherID " +
                "FROM Students INNER JOIN " +
                "Teachers ON Students.TeacherID = Teachers.TeacherID " +
                "WHERE(Students.TeacherID = @pTeacherID)";

            command = new SqlCommand(studentInfoSelect, connection);
            grdStudentDisplay.Rows.Clear();

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
                    string sFirstName = reader["FirstName"].ToString();
                    string sLastName = reader["LastName"].ToString();
                    string classYear = reader["ClassYear"].ToString();
                    string Age = reader["Age"].ToString();
                    //byte[] sPicture = (byte[])reader["StudentPic"];

                    grdStudentDisplay.AllowUserToAddRows = false;
                    //grdStudentDisplay.RowTemplate.Height = 100;
                    grdStudentDisplay.Rows.Add(teacherID, sFirstName, sLastName, Age, classYear);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 3: \n" + ex.Message);
            }
            connection.Close();
        }

        // For use in adding a student to the database
        private void getStudentInfo()
        {
            students.TeacherID = txtTeacherID.Text;
            students.FirstName = txtFirstName.Text;
            students.LastName = txtLastName.Text;
            students.Age = txtAge.Text;
            students.ClassYear = txtClassYear.Text;
        }

        // Add button that adds a student to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentInfoAdd = "INSERT INTO Students " +
                                    "(FirstName, Age, ClassYear, TeacherID, LastName) " +
                                    "VALUES(@pFirstName, @pAge, @pClassYear, @pTeacherID, @pLastName)";

            command = new SqlCommand(studentInfoAdd, connection);

            // Using the text boxes this attempts to take the entered information and compile it into a new student record
            try
            {
                connection.Open();
                getStudentInfo();
                command.Parameters.AddWithValue("pTeacherID", students.TeacherID);
                command.Parameters.AddWithValue("pFirstName", students.FirstName);
                command.Parameters.AddWithValue("pLastName", students.LastName);
                command.Parameters.AddWithValue("pAge", students.Age);
                command.Parameters.AddWithValue("pClassYear", students.ClassYear);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Student has been added to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 4: \n" + ex.Message);
            }

            grdStudentDisplay.Refresh();

            // Clears the text boxes after the student has been entered
            txtTeacherID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtClassYear.Text = "";
        }

        // Update button allows a user to update various information of a student
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Uses the student's first name and last name as the identifier for who is being updated
            string studentInfoUpdate = "UPDATE Students " +
                                       "SET FirstName = @pFirstName, LastName = @pLastName, " +
                                       "Age = @pAge, ClassYear = @pClassYear, TeacherID = @pTeacherID " +
                                       "WHERE(FirstName = @pFirstName) AND (LastName = @pLastName)";

            command = new SqlCommand(studentInfoUpdate, connection);

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pTeacherID", txtTeacherID.Text);
                command.Parameters.AddWithValue("@pFirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@pLastName", txtLastName.Text);
                command.Parameters.AddWithValue("@pAge", txtAge.Text);
                command.Parameters.AddWithValue("@pClassYear", txtClassYear.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Student has been updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 5: \n" + ex.Message);
            }

            grdStudentDisplay.Refresh();

            // Clears text boxes
            txtTeacherID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtClassYear.Text = "";
        }

        // Delete button removes a student from the database as needed
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Once again uses the first name and last name to determine who is to be deleted
            string studentInfoDelete = "DELETE FROM Students " +
                                       "WHERE(FirstName = @pFirstName) AND " +
                                       "(LastName = @pLastName)";

            command = new SqlCommand(studentInfoDelete, connection);

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pFirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@pLastName", txtLastName.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Student has been deleted from database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 6: \n" + ex.Message);
            }

            grdStudentDisplay.Refresh();

            // Clears text boxes
            txtTeacherID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtClassYear.Text = "";
        }

        // Button that closes the current window returing to the last page
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
    }
}
