using System;

namespace OptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            string censored = HideString(input, "x");
            Console.WriteLine(censored);
            char input2 = char.Parse(Console.ReadLine());
            char cen = HideString(input2);
            Console.WriteLine(cen);


        }

        static string HideString(string input, string option)
        {
            string censored = "";
            foreach (var word in input)
            {
                if (option != null)
                {
                    censored += option;
                }
                else
                {
                    censored += "*";

                }
            }

            return censored;
        }
        static char HideString(char input)
        {
            char censored = ' ';
            for (int i = 0; i < input; i++)
            {
                censored = '*';
            }

            return censored;
        }
    }
}
