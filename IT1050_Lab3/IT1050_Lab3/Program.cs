using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "English");
            Instructor mike = new Instructor("Mike", "Math");
            Student jane = new Student("Jane", john, 0);
            Student joe = new Student("Jane", john, 0);
            Student melissa = new Student("Melissa", mike, 0);
            Student matt = new Student("Matt", mike, 0);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            System.Console.WriteLine("");

            jane.studentInfoPrint();
            joe.studentInfoPrint();
            melissa.studentInfoPrint();
            matt.studentInfoPrint();

            System.Console.ReadKey();
        }
    }
}
