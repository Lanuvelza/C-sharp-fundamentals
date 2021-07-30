using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // while looping 
            int counter = 0;
            while (counter < 10) {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            // do-while looping
            counter = 0;
            do {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);


            // for looping
            for (int index = 0; index < 10; index++) {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }
    }
}
