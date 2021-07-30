using System;
using System.Collections.Generic;

namespace ArraysListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // List example
            // var refers to a variable of arbitrary type. 
            var names = new List<string> { "<name>", "Ana", "Felipe" }; 
            foreach (string name in names) {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // We can also write it like this.
            List<string> names2 = new List<string> { "<name>", "Ana", "Felipe" }; 
            foreach (string name in names2) {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // also acheives the same desired output
            for (int i = 0; i < names.Count; i++) {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }
            
            // Adding and removing items in a list
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("<name>");

            foreach (var name in names) {
                Console.WriteLine(name);
            }

            // accessing items of the List
            Console.WriteLine(names[1]); //Felipe
            Console.WriteLine(names[0]); //Ana
        }
    }
}
