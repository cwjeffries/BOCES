/*******************************************
 * Author: Chase Jeffries
 * Purpose: Class file for student objects
 *          to use in functions
 ******************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffries_BOCES1
{
    // Just a class for getting student information and containing them in an object
    class Student
    {
        private string teacherID;
        public string TeacherID { get => teacherID; set => teacherID = value; }

        private string studentID;
        public string StudentID { get => studentID; set => studentID = value; }

        private string firstName;
        public string FirstName { get => firstName; set => firstName = value; }

        private string lastName;
        public string LastName { get => lastName; set => lastName = value; }

        private string age;
        public string Age { get => age; set => age = value; }

        private string classYear;
        public string ClassYear { get => classYear; set => classYear = value; }

    }
}
