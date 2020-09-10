using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift_3
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            string text = Console.ReadLine();

            if (text.Contains("Area 51"))
            {
                text = text.Replace("Classified:", "");
                text = text.Replace("Area 51", "[AN UNDISCLOSED LOCATION]");
                text = text.TrimStart();
               
            }

            Console.WriteLine(text);
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Test()
        {
            using FakeConsole console = new FakeConsole("Classified: There are extraterrestrials at Area 51.");
            Program.Main();
            Assert.AreEqual("There are extraterrestrials at [AN UNDISCLOSED LOCATION].", console.Output);
        }
    }
}
