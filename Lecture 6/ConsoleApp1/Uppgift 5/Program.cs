using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift_5
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Dictionary<string, int> theWords = new Dictionary<string, int> { };

            Console.WriteLine("Enter: ");
            string words = Console.ReadLine();

            string[] split = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });

            foreach (string s in split)
            {

                if (s.Trim() != "")
                {
                    if (theWords.ContainsKey(s))
                    {
                        theWords[s] += 1;
                    }
                    else
                    {
                        theWords.Add(s, 1);
                    }
                }
            }
            var max = theWords.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            Console.WriteLine(max);

        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            using FakeConsole console = new FakeConsole("Jag, heter. Liam. Liam");
            Program.Main();
            Assert.AreEqual("Liam", console.Output);
        }
    }
}
