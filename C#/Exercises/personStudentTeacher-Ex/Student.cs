using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personStudentTeacher_Ex
{
    internal class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm Studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is : {age} years old");
        }
    }
}
