using System;
using static System.Console;

namespace csharp_data_types_and_object_tips
{
    class Program7
    {
        public static void Run(string[] args)
        {
            Uri a = new Uri("https://pluralsight.com");
            Uri b = new Uri("https://pluralsight.com");

            var areEqual1 = Object.ReferenceEquals(a,b);
            WriteLine(areEqual1); //False

            a = b;
            var areEqual2 = Object.ReferenceEquals(a, b);
            WriteLine(areEqual2); //True
        }
    }
}
