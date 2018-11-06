﻿using System;
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
            System.Console.WriteLine(this.Name + " has a grade of:" + this.Grade + " in " + this.Teacher.Name + "'s class.");
        }


    }
}