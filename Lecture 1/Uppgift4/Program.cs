using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift4
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            /*
            Write a program that reads three numbers from the user and then prints the largest of them along with a message.For example, if the user enters 5, 7, and 2, the program should print The largest number is: 7.
            */

            //Input
            Console.WriteLine("Enter 3 numbers: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            //Calc
            int maxNumber = Math.Max(number1, Math.Max( number2, number3));
            //Output
            Console.WriteLine($"Max number is: {maxNumber}.");




        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void BigNumber()
        {
            using FakeConsole console = new FakeConsole("10", "1", "200");
            Program.Main();
            Assert.AreEqual("Max number is: 200.", console.Output);
        }
    }
}
