using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    class Person
    {
        public int age;
        public string name;
        public int wealth;
        public int salary;
        public void Pay()
        {
            wealth += salary;
        }
        public void WinLottery(int prize)
        {
            wealth += prize; 
        }

        public void CelebrateBirthday()
        {
            age++;
            wealth += 500;
        }

        public void Show()
        {
            Console.WriteLine($"{age}-årige {name} har en lön på {salary}kr och {wealth}kr på banken.");
        }
    }


}
