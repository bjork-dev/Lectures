using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift2
{
    public class Person
    {
        public string Name;
        public int Age;
        public double Height;
        public double Weight;
    }
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            bool done = false;
            var people = new List<Person>();
            while (!done)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (name == "")
                {
                    done = true;
                }
                else
                {
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("Weight: ");
                    double weight = double.Parse(Console.ReadLine());

                    var p = new Person()
                    {
                        Name = name,
                        Age = age,
                        Height = height,
                        Weight = weight
                            
                    };
                    people.Add(p);
                }
            }

            var avgAge = people.Average(p => p.Age);
            var tallest = people.OrderBy(p => p.Height).Last();
            var tallerThan = people.Where(p => p.Height >= 1.80).Select(p => p.Name).ToArray();
            var firstLetters = people.Select(p => p.Name[0])
                .OrderBy(p => p)
                .Distinct().ToArray();
            Console.WriteLine("Tallest: " + tallest.Name + ", " + tallest.Height);
            Console.WriteLine("Taller than 1.80: " + string.Join(", ",tallerThan ) + ", " + tallest.Height);
            Console.WriteLine("First letters: " + string.Join(", ", firstLetters));
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
