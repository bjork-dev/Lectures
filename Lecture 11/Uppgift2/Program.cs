using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uppgift2
{
    public class Program
    {
        public static void Main()
        {
            // We need this to make sure we can always use periods for decimal points.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            bool running = true;
            while (running)
            {
                int menu = ShowMenu.Menu("Console Blog", new string[]
                {
                    "Add new post",
                    "Read posts",
                    "Exit"
                });
                switch (menu)
                {
                    case 0:
                        BlogSystem.AddPost();
                        break;
                    case 1:
                        //read posts
                        break;
                    case 2:
                        running = false;
                        break;
                }
            }
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
