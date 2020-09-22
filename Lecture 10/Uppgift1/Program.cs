using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift1
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var person = new Person();

            Console.WriteLine("Enter your first name: ");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            person.age = int.Parse(Console.ReadLine());

            Person.Summary(person.age, person.firstName, person.lastName);
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExampleTest()
        {
      
        }
    }
}
