using System;
using static System.Console;

namespace csharp_data_types_and_object_tips
{
    class Program2
    {
        public static void Run(string[] args)
        {
            var person = (1, "Bill", "Gates");
            WriteLine(person.Item1);  // returns 1
            WriteLine(person.Item2);   // returns "Bill"
            WriteLine(person.Item3);   // returns "Gates"

            //equivalent Tuple
            //var person = Tuple.Create(1, "Bill", "Gates");

            ValueTuple<int, string, string> person1 = (1, "Bill", "Gates");
            WriteLine(person1.Item1);  // returns 1
            WriteLine(person1.Item2);   // returns "Bill"
            WriteLine(person1.Item3);   // returns "Gates"


            (int, string, string) person2 = (1, "Bill", "Gates");
            WriteLine(person2.Item1);  // returns 1
            WriteLine(person2.Item2);   // returns "Bill"
            WriteLine(person2.Item3);   // returns "Gates"

            (int Id, string FirstName, string LastName) person3 = (1, "Bill", "Gates");
            WriteLine(person3.Id);   // returns 1
            WriteLine(person3.FirstName);  // returns "Bill"
            WriteLine(person3.LastName); // returns "Gates"

            //We can also assign member names at the right side with values, as below.
            var person4 = (Id: 1, FirstName: "Bill", LastName: "Gates");
            WriteLine(person4.Id);   // returns 1
            WriteLine(person4.FirstName);  // returns "Bill"
            WriteLine(person4.LastName); // returns "Gates"


            // PersonId, FName, LName will be ignored.
            (int Id, string FirstName, string LastName) person5 =
                            (PersonId: 1, FName: "Bill", LName: "Gates");
            WriteLine(person5.Id);   // returns 1
            WriteLine(person5.FirstName);  // returns "Bill"
            WriteLine(person5.LastName); // returns "Gates"
        }
    }
}
