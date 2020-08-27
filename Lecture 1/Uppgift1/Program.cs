using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift1
{
    public class Program
    {
        public static void Main()
        {
            int total1 = 5 + 7;
            int total2 = 5 + 2 * 7;
            int total3 = 10 + 2 / 3;
            int total4 = 3 * 8 / 4 * 2;

            Console.WriteLine($"5 + 7 = {total1}.");
            Console.WriteLine($"5 + 2 * 7 = {total2}.");
            Console.WriteLine($"10 + 2 / 3 = {total3}.");
            Console.WriteLine($"3 * 8 / 4 * 8 = {total4}.");
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Total1()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("3 * 8 / 4 * 8 = 12.", console.Output);
        }
        public void Total2()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("5 + 2 * 7 = 19.", console.Output);
        }
        public void Total3()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("10 + 2 / 3 = 10.", console.Output);
        }
        public void Total4()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("3 * 8 / 4 * 8 = 12.", console.Output);
        }
    }
}
