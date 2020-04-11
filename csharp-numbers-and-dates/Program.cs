using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using static System.Console;

namespace csharp_numbers_and_dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Programs.Program1();
            Programs.Program2();
            Programs.Program3();
            Programs.Program4();
            Programs.Program5();
            Programs.Program6();
        }
    }

    public static class Programs
    {
        public static void Program6()
        {
            var numberList = Enumerable.Range(0, 10).Select(x => x * 2);
            WriteLine(string.Join(",", numberList));
            ReadLine();
        }

        public static void Program5()
        {
            var random1 = new Random(128);
            var random2 = new Random(256);
            var random3 = new Random(128);
            WriteLine("The random1 numbers is: " + random1.Next());
            WriteLine("The random2 numbers is: " + random2.Next());
            WriteLine("The random3 numbers is: " + random3.Next());
            ReadLine();
        }

        public static void Program4()
        {
            using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[4];

                rnd.GetBytes(randomBytes);

                int result = BitConverter.ToInt32(randomBytes, 0);

                WriteLine(result);
            }
            ReadLine();
        }

        public static void Program3()
        {
            Console.WriteLine("Please enter a number:");
            var input = ReadLine();
            var number = int.Parse(input, NumberStyles.AllowThousands | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            WriteLine("The numbers is: " + number);
            ReadLine();
        }

        public static void Program2()
        {
            Console.WriteLine("Please enter your date of birth:");
            var input = ReadLine();
            var dob = DateTime.ParseExact(input, "MM/dd/yyyy", null);
            WriteLine("Your date of birth is:" + dob.ToShortDateString());
            ReadLine();
        }

        public static void Program1()
        {
            DateTime d1 = DateTime.Parse("01/12/2000"); //01-12-2000 00:00:00
            DateTime d2 = DateTime.Parse("01/12/2000", null, DateTimeStyles.AssumeUniversal); //01-12-2000 05:30:00
            DateTime d3 = DateTime.Parse("01/12/2000", null, DateTimeStyles.AssumeLocal); //01-12-2000 00:00:00
            DateTime d4 = DateTime.Parse("13:30:00"); //31-03-2020 13:30:00 
            DateTime d5 = DateTime.Parse("13:30:00", null, DateTimeStyles.NoCurrentDateDefault); //01-01-0001 13:30:00

            WriteLine(d1);
            WriteLine(d2);
            WriteLine(d3);
            WriteLine(d4);
            WriteLine(d5);
            ReadLine();
        }
    }
}
 