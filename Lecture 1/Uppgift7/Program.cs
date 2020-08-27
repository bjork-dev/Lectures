using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift7
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            /*
             Write a program that reads a number of seconds from the user and then prints that number of seconds expressed in hours, minutes, and seconds. For example, if the number of seconds is 3735, the program should print 1h, 2m, 15.
                */

            Console.WriteLine("Enter a number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            //here backslash is must to tell that colon is
            //not the part of format, it just a character that we want in output
            string str = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                        time.Hours,
                        time.Minutes,
                        time.Seconds);



            Console.WriteLine(str);
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
