using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift6
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            /*
              Write a program that evenly distributes a bag of candy between the children at a birthday party. The program should read two numbers from the user—the number of children at the party and the total number of candies in the bag—and print the number of candies per children. For example, if the number of children is 5 and the number of candies is 50, the program should print Candies per child: 10.
            */

            Console.WriteLine("Enter number of children: ");
            int children = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of candies: ");
            int candies = int.Parse(Console.ReadLine());

            int calc = candies / children;

            Console.WriteLine($"Every child gets {calc} candies each.");

        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("Hello!", console.Output);
        }
    }
}
