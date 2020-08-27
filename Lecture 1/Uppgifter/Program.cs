using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgifter
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter cash amount: ");
            int cash = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter bank amount: ");
            int bank = int.Parse(Console.ReadLine());

            int total = cash + bank;
            Console.WriteLine($"You have {total} dollars in total.");
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MoneyTest()
        {
            using FakeConsole console = new FakeConsole("100", "100");
            Program.Main();
            Assert.AreEqual("You have 200 dollars in total.", console.Output);
        }
    }
}
