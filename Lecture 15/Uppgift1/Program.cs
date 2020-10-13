using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift1
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var theList = new List<int>();
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter some numbers: ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    running = false;
                    var sum = theList.Sum();
                    var max = theList.Max();
                    var min = theList.Min();
                    var avg = theList.Average();
                    var tenOrHigher = theList.Where(n => n >= 10);
                    var btwnTenAndTwenty = theList.Where(n => n >= 10 && n <= 20);
                    var sumTenAndTwenty = theList.Where(n => n >= 10 && n <= 20).Sum();
                    var squared = theList.Select(n => n * n);
                    var ordered = theList.OrderBy(n => n);

                    Console.WriteLine($"Sum of numbers: {sum} \nMax number: {max} \nMin number: {min} \nAverage: {avg} \nNumbers that are 10 or higher: {string.Join(", ", tenOrHigher)} \nNumbers that are between 10 and 20: {string.Join(", ", btwnTenAndTwenty)} \nSum of numbers between 10 and 20: {string.Join(", ", sumTenAndTwenty)} \nSquared: {string.Join(", ", squared)} \nOrdered: {string.Join(", ", ordered)} ");
                }
                else
                {
                    int parsed = int.Parse(input);
                    theList.Add(parsed);
                }




            }

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
