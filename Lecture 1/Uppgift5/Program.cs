using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Uppgift5
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            //Formula = a2 + b2 = c2

            //Write a program that reads four numbers from the user—the x and y coordinates of two points on a grid—and calculates the distance between them, rounded to two decimal places.

            //Input
            Console.WriteLine("Enter x and y coordinates: ");
            double xPoint1 = double.Parse(Console.ReadLine());
            double yPoint1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x and y coordinates: ");
            double xPoint2 = double.Parse(Console.ReadLine());
            double yPoint2 = double.Parse(Console.ReadLine());

            //Calc
            double Point1 = Math.Max(xPoint1, xPoint2) - Math.Min(xPoint1, xPoint2);
            double Point2 = Math.Max(yPoint1, yPoint2) - Math.Min(yPoint1, yPoint2);
            double calc = Math.Pow(Point1, 2) + Math.Pow(Point2, 2);
            double sum = Math.Round(Math.Sqrt(calc), 2);
            
            //Output
            Console.WriteLine($"{sum} km");

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
