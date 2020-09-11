using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Uppgift_4
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            List<string> numbers = new List<string> { };


            while (true)
            {
                string input = Console.ReadLine();
                numbers.Add(input);
                if (input == "")
                {
                    break;
                }
            }

            
            

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
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
