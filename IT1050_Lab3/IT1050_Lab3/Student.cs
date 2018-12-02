using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Lab3
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Instructor Teacher { get; set; }

        public Student(string name, Instructor teacherName, int grade)
        {
            this.Name = name;
            this.Teacher = teacherName;
            this.Grade = 0;
        }

        public void studentInfoPrint()
        {
            System.Console.WriteLine(this.Name + " has a grade of: " + this.Grade + " in " + Teacher.instructorsInfoPrint());
        }

        public void SetGrade(Student aStudent, int grade)
        {
            Teacher.SetStudentGrade(aStudent, grade);
        }
        class Math

        {

            public double Add(double x, double y)

            {

                return x + y;

            }
            double sum = new Math().Add(5, 10);

        }
    }
}
