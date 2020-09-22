using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift2
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person();
            person.age = 20;
            person.name = "Liam";
            person.salary = 35000;
            person.wealth = 70000;

            person.Pay();
            person.CelebrateBirthday();
            person.WinLottery(2000);
            person.Show();
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
