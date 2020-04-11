using System;
using static System.Console;

namespace string_formatting_tips
{
    class Program1
    {
        public static void Run(string[] args)
        {
            while (true)
            {
                WriteLine("Enter your name:");

                string name = ReadLine();


                if (String.IsNullOrWhiteSpace(name))
                {
                    WriteLine("Please enter your name");
                    continue;
                }

                WriteLine("Hello!" + name);
                break;
            }

            ReadLine();
        }
    }
}