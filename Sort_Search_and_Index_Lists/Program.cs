using System;
using System.Collections.Generic;

namespace Sort_Search_and_Index_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" }; 

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("<name>");


            // IndexOf method
            var index = names.IndexOf("Felipe"); // 1
            Console.WriteLine($"Found Felipe at {index}");

            var index2 = names.IndexOf("Scott"); // -1
            Console.WriteLine($"Found Scott at {index2}");


            var index3 = names.IndexOf("Ana");
            if (index3 == -1) {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else {
                Console.WriteLine($"The name {names[index]} is found at {index}");
            }

            // Sort method 
            names.Sort(); //sorts the names by alpahabetical order 
            foreach (var name in names) {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
