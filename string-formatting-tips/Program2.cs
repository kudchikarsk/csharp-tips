using System;
using System.Collections.Generic;
using static System.Console;

namespace string_formatting_tips
{
    class Program2
    {
        public static void Run(string[] args)
        {
            var people = new List<Person>()
            {
                new Person{ Name="Clarence Barnes",  Age= 27 },
                new Person{ Name= "Erica Wood",  Age= 33 },
                new Person{ Name= "Lois Watson",  Age= 56 },
                new Person{ Name= "Teresa Moore",  Age= 25 },
                new Person{ Name= "Addison Richardson",  Age= 45 }
            };

            foreach (var person in people)
            {
                WriteLine($"Name: {person.Name,-20} Age:{person.Age,-20}");
            }

            ReadLine();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
