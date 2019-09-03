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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeffries_BOCES1
{
    public partial class DisplayUsers : Form
    {
        // Sql objects
        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        List<Teacher> teachers;

        public DataGridViewImageCellLayout ImageLayout { get; set; }

        // Initialize objects
        public DisplayUsers()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.BOCESConnectionString;
            connection = new SqlConnection(connectionString);
            teachers = new List<Teacher>();
        }

        // When the form loads begin by getting the teacher first and last name, and ID from database
        private void DisplayUsers_Load(object sender, EventArgs e)
        {
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

                loadTeacherNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1: \n" + ex.Message);
            }
        }

        // Add teacher first and last name to the combo box
        private void loadTeacherNames()
        {
            foreach (Teacher aTeacher in teachers)
            {
                cboTeacherName.Items.Add(aTeacher.TeacherFirstName + " " + aTeacher.TeacherLastName);
            }

            cboTeacherName.SelectedIndex = 0;
        }

        // When someone selects a teacher this function will begin trying to check the database for the teacher ID for display student info
        private void cboTeacherName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedTeacherName = cboTeacherName.SelectedItem.ToString();

            string teachID = findTeacherID(selectedTeacherName);

            // Displays the teacher's image in the picture box above the combo box
            try
            {
                byte[] picture;

                string teachPic = "SELECT Picture FROM Teachers WHERE(TeacherID = @pTeacherID)";
                command = new SqlCommand(teachPic, connection);

                connection.Open();

                command.Parameters.AddWithValue("@pTeacherID", teachID);

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    picture = (byte[])reader["Picture"];

                    MemoryStream mStream = new MemoryStream();
                    byte[] pData = picture;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    mStream.Dispose();

                    picTeacher.SizeMode = PictureBoxSizeMode.StretchImage;
                    picTeacher.Image = bm;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            if (teachID != "Not Found")
            {
                displayStudentInfo(Int32.Parse(teachID));
            }
            else
            {
                MessageBox.Show("Error 2");
            }
        }

        // Compares the teacher name and the database name to get the ID from the database
        private string findTeacherID(string pTeachName)
        {
            foreach (Teacher aTeach in teachers)
            {
                if (aTeach.TeacherFirstName + " " + aTeach.TeacherLastName == pTeachName)
                {
                    return aTeach.TeacherID;
                }
            }
            return "Not Found!";
        }

        // Using the teacher ID student info is displayed in the gridview
        private void displayStudentInfo(int pID)
        {
            string studentInfoSelect = "SELECT Students.StudentID, Students.FirstName, Students.LastName, " +
                "Students.Age, Students.ClassYear, Students.StudentPic, Students.TeacherID " +
                "FROM Students INNER JOIN " +
                "Teachers ON Students.TeacherID = Teachers.TeacherID " +
                "WHERE(Students.TeacherID = @pTeacherID)";

            command = new SqlCommand(studentInfoSelect, connection);
            grdStudentDisplay.Rows.Clear();

            // Each teacher that is currently selected will have any students associated with their ID displayed in the gridview 
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pTeacherID", pID);

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    string teacherID = reader["TeacherID"].ToString();
                    string studentID = reader["StudentID"].ToString();
                    string sFirstName = reader["FirstName"].ToString();
                    string sLastName = reader["LastName"].ToString();
                    string classYear = reader["ClassYear"].ToString();
                    string Age = reader["Age"].ToString();
                    byte[] sPicture = null;
                    if (!Convert.IsDBNull(reader["StudentPic"]))
                    {
                        sPicture = (byte[])reader["StudentPic"];
                    }
                    // Changes display size of column and removes empty column for better look
                    grdStudentDisplay.AllowUserToAddRows = false;
                    grdStudentDisplay.RowTemplate.Height = 100;
                    grdStudentDisplay.Rows.Add(studentID, sFirstName, sLastName, Age, classYear, sPicture);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 3: \n " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Returns to the previous screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdStudentDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gets the ID and first and last name of the student that clicked login
            int columnIndexID = e.ColumnIndex - 6;
            int columnIndexFirst = e.ColumnIndex - 5;
            int columnIndexLast = e.ColumnIndex - 4;
            int rowIndex = e.RowIndex;
            var id = grdStudentDisplay.Rows[rowIndex].Cells[columnIndexID].Value;
            var first = grdStudentDisplay.Rows[rowIndex].Cells[columnIndexFirst].Value;
            var last = grdStudentDisplay.Rows[rowIndex].Cells[columnIndexLast].Value;

            // Loads the task frm with the student id and name as parameters for reports
            SelectTask frmSelect = new SelectTask(id.ToString(), first.ToString(), last.ToString());
            frmSelect.ShowDialog();
        }
    }
}
