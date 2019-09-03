/*******************************************
 * Author: Chase Jeffries
 * Purpose: Class file for creating teacher
 *          object to be used in various
 *          functions
 ******************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffries_BOCES1
{
    // Class for getting teacher information and containing it in an object
    class Teacher
    {
        private string teacherID;
        private string teacherFirstName;
        private string teacherLastName;
        private string email;
        private string phone;

        public Teacher()
        {
            this.teacherID = "";
            this.teacherFirstName = "";
            this.teacherLastName = "";
        }

        public Teacher(string teacherID, string teacherFirstName, string teacherLastName)
        {
            this.teacherID = teacherID;
            this.teacherFirstName = teacherFirstName;
            this.teacherLastName = teacherLastName;
        }

        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string TeacherFirstName { get => teacherFirstName; set => teacherFirstName = value; }
        public string TeacherLastName { get => teacherLastName; set => teacherLastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
