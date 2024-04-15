using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   

    public class GraduateStudent : Student
    {
        public GraduateStudent(string name, double gPA, string major) : base(name, gPA, major)
        {
            Console.WriteLine("Congratulations !!! " + name + " You've graduated!!!");
        }

        
    }

    public class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
        public string Major { get; set; } 
        public Student(string name, double gPA, string major)
        {
            Name = name;
            GPA = gPA;
            Major = major;
        }

        public void FormatStudent()
        {
            Console.WriteLine("Welcome " + Name + " Your GPA is " + GPA + " And your major is " + Major);
        }
    }
}
