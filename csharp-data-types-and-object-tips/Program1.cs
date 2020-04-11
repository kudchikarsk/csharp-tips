using System;
using static System.Console;

namespace csharp_data_types_and_object_tips
{
    class Program1
    {
        public static void Run(string[] args)
        {
            Tuple<int, string, string> person1 =
                new Tuple<int, string, string>(1, "Steve", "Jobs");
            WriteLine(person1.Item1); // returns 1
            WriteLine(person1.Item2); // returns "Steve"
            WriteLine(person1.Item3); // returns "Jobs"

            var person2 = Tuple.Create(1, "Steve", "Jobs");
            WriteLine(person2.Item1); // returns 1
            WriteLine(person2.Item2); // returns "Steve"
            WriteLine(person2.Item3); // returns "Jobs"



            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            WriteLine(numbers.Item1); // returns "One"
            WriteLine(numbers.Item2); // returns 2
            WriteLine(numbers.Item3); // returns 3
            WriteLine(numbers.Item4); // returns "Four"
            WriteLine(numbers.Item5); // returns 5
            WriteLine(numbers.Item6); // returns "Six"
            WriteLine(numbers.Item7); // returns 7
            WriteLine(numbers.Rest ); // returns (8)
            WriteLine(numbers.Rest.Item1); // returns 8
        }
    }
}
