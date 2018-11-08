using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Lab3
{
    class Instructor
    {
        public string Name { get; set; }
        public string CourseName { get; set; }

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student someStudent, int grade)
        {
            someStudent.Grade = grade;
        }

        public string instructorsInfoPrint()
        {
            return (this.Name + "'s " + this.CourseName + " class.");
        }

    }
}
