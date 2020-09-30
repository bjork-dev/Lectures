using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    internal class Company
    {
        public string CompanyName1;
        public string CompanyName2;
        public string City1;
        public string City2;
        public int Age1;
        public int Age2;
        public void Merge()
        {
            string newCompany = CompanyName1 + "-" + CompanyName2;
            var newCity = Age1 > Age2 ? City1 : City2;
            const int newAge = 0;
            Console.WriteLine($"The new {newCity} based company is called {newCompany}, founded {newAge} years ago.");
        }
    }
}
