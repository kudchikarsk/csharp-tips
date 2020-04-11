using System;
using static System.Console;
using System.Collections.Generic;

namespace string_formatting_tips
{
    class Program4
    {
        public static void Run(string[] args)
        {
            var products = new List<Product>()
            {
                new Product{ Name="BLACK SUN GLASS",  Rating= 5 },
                new Product{ Name= "BEAUTIFUL HEAD CAP",  Rating= 3 },
                new Product{ Name= "HEAD PROTECTED CAP",  Rating= 5 },
                new Product{ Name= "BORING HEAD CAP",  Rating= -5 },
                new Product{ Name= "NEW AGE SUN GLASS",  Rating= 0 }
            };

            foreach (var product in products)
            {
                var rating = String.Format(new RatingFormatProvider(), "{0}", product.Rating);
                WriteLine($"Name: {product.Name,-20} Rating: {rating,-20}");
            }

            ReadLine();
        }

        public class Product
        {
            public string Name { get; set; }
            public int Rating { get; set; }
        }

        public class RatingFormatProvider : IFormatProvider, ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                int rating = (int)arg;

                return rating.ToString("Good #;Bad -#;Not Rated");
            }

            public object GetFormat(Type formatType)
            {
                if (formatType == typeof(ICustomFormatter))
                {
                    return this;
                }

                return null;
            }
        }
    }
}
