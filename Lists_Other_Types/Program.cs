using System;
using System.Collections.Generic;

namespace Lists_Other_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of integers
            var fibonacciNumbers = new List<int> {1, 1}; 


            // generate the first 20 numbers in the fibonacci sequence
            while (fibonacciNumbers.Count < 20) {

                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; //last number
                var prvious2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // second last number

                fibonacciNumbers.Add(previous + prvious2);
            }


            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}
