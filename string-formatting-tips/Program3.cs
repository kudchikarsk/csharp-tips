using System;
using System.Collections.Generic;
using static System.Console;

namespace string_formatting_tips
{
    class Program3
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
                WriteLine($"Name: {product.Name,-20} Rating:{product.Rating.ToString("Good #;Bad -#;Not Rated"),-20}");
            }

            ReadLine();
        }

        public class Product
        {
            public string Name { get; set; }
            public int Rating { get; set; }
        }
    }
}
