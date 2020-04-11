using System;
using static System.Console;

namespace csharp_data_types_and_object_tips
{
    class Program3
    {
        public static void Run(string[] args)
        {
            var person1 = GetPerson();
            WriteLine(person1.Id);   // returns 1
            WriteLine(person1.FirstName);  // returns "Bill"
            WriteLine(person1.LastName); // returns "Gates"

            (var id, var fname, var lname) = GetPerson();
            WriteLine(id);   // returns 1
            WriteLine(fname);  // returns "Bill"
            WriteLine(lname); // returns "Gates"
        }

        static (int Id, string FirstName, string LastName) GetPerson()
        {
            return (1, "Bill", "Gates");
        }
    }
}
