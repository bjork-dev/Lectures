using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    class Person
    {
        public int age;
        public string firstName;
        public string lastName;

        public static void Summary(int age, string fname, string lname)
        {
            Console.WriteLine($"Your name is {fname} {lname} and you are {age} years old.");
        }
    }
}
