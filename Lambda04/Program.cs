using Lambda04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda04 {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();
            foreach (string item in result) {
                Console.WriteLine(item);
            }
        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }
    }
}
