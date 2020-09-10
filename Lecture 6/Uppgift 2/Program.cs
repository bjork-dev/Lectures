using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift_2
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter citizen number: ");
            string number = Console.ReadLine();

            int birth = int.Parse(number.Substring(0, 4));

            int gender = int.Parse(number.Substring(11, 1));

            if (gender % 2 == 0)
            {
                Console.Write($"This woman is born in {birth}");
            }
            else
            {
                Console.WriteLine($"This man is born in {birth}");
            }
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Man()
        {
            using FakeConsole console = new FakeConsole("20000403-5473");
            Program.Main();
            Assert.AreEqual("This man is born in 2000", console.Output);
        }
        public void Woman()
        {
            using FakeConsole console = new FakeConsole("18430403-5483");
            Program.Main();
            Assert.AreEqual("This woman is born in 1843", console.Output);
        }
    }
}
