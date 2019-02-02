using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        class Student // Creating Class Student
        {
            private string name; // Name of Student
            private string id; // Id of Student
            private int yearofstudy; //Year of studing 
            public Student(string name, string id) // Creating constructure with two parameters
            {
                this.name = name; // writing name , this comand is used in order to not get confused with others 
                this.id = id; // writing id
            }
            public void Increment() // Method in order to increment year of study
            {
                yearofstudy++;
            }
            public int YearofStudy //In order to get access private variable yearofstudy
            {
                get
                {
                    return yearofstudy;
                }
                set
                {
                    yearofstudy = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("Aslan", "18BD110553"); //creating object of class student
            s.YearofStudy = 1; // Value in the beggining is 1
            s.Increment(); // after incrementing the year of study becoming +1
            Console.WriteLine(s.YearofStudy);
        }
    }
}
