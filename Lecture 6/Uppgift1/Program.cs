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

            Console.WriteLine("Enter url: ");
            string url = Console.ReadLine();
            string lowerCase = url.ToLower();

            foreach (var letter in lowerCase)
            {
                if (letter == ' ')
                {
                  lowerCase = lowerCase.Replace(' ', '_');
                }
            }
            Console.WriteLine(lowerCase);
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            using FakeConsole console = new FakeConsole("Test Test Test");
            Program.Main();
            Assert.AreEqual("test_test_test", console.Output);
        }
    }
}
