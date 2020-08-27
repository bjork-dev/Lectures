using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static System.Console;

namespace Uppgift3
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            //Formula: Celsius = (Fahrenheit - 32) x 0.556

            //Input
            WriteLine("Enter temperature in F: ");
            double faTemp = double.Parse(ReadLine());

            //Calc
            double calc = (faTemp - 32) * 0.556;
            int ceTemp = (int)Math.Round(calc);

            //Output
            WriteLine($"Temp in celsius = {ceTemp}.");


        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void DegreeTest()
        {
            using FakeConsole console = new FakeConsole("140");
            Program.Main();
            Assert.AreEqual("Temp in celsius = 60.", console.Output);
        }
        [TestMethod]
        public void DegreeTest2()
        {
            using FakeConsole console = new FakeConsole("100");
            Program.Main();
            Assert.AreEqual("Temp in celsius = 38.", console.Output);
        }
        [TestMethod]
        public void DegreeTest3()
        {
            using FakeConsole console = new FakeConsole("-12");
            Program.Main();
            Assert.AreEqual("Temp in celsius = -24.", console.Output);
        }
    }
}
