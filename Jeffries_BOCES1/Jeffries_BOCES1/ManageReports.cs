/*******************************************
 * Author: Chase Jeffries
 * Purpose: Form that simply generates a 
 *          report from StudentTaskAndTimes
 *          table into a txt file denoted by
 *          date generated
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
    public partial class ManageReports : Form
    {
        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        public ManageReports()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.BOCESConnectionString;
            connection = new SqlConnection(connectionString);
        }

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // gets the current date and sets file path to my documents for storage
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("MM-dd-yyyy");
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbFile = filePath + @"\Reportfile_" + date + ".txt";

            writeFileFromDB(dbFile);
        }

        // Writes all entries from StudentTaskAndTimes table to a txt file
        private void writeFileFromDB(string pFile)
        {
            // Gets info from table and sorts via the student ID
            String reportInfo = "SELECT StudentID, StudentName, TaskID, TaskName, Date, StartTime, EndTime " +
                                "FROM StudentTaskAndTimes ORDER BY StudentID";

            command = new SqlCommand(reportInfo, connection);

            try
            {
                connection.Open();

                SqlDataReader sqlReader = command.ExecuteReader();

                // Open the file for write operations.  If exists, it will overwrite due to the "false" parameter
                using (StreamWriter file = new StreamWriter(pFile, false))
                {
                    while (sqlReader.Read())
                    {
                        file.WriteLine(sqlReader["StudentID"] + " " + sqlReader["StudentName"] + "\t" + sqlReader["TaskID"] + 
                                                                " " + sqlReader["TaskName"] + "\t" + sqlReader["Date"] + 
                                                                "\t" + sqlReader["StartTime"] + "\t" + sqlReader["EndTime"]);
                    }
                }

                sqlReader.Close();
                connection.Close();

                MessageBox.Show("Report has been generated and saved to My Documents");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1:\n" + ex.Message);
            }
        }
    }
}
