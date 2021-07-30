using System;

namespace Numbers_and_Integers_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18; 
            int b = 6; //
            int c = a + b; //24
            Console.WriteLine(c);

            c = a - b; //12
            Console.WriteLine(c);

            c = a * b; //108
            Console.WriteLine(c);

            c = a / b; //3
            Console.WriteLine(c);


            // Order of operations 
            a = 5; 
            b = 4; 
            c = 2; 
            int d = a + b * c; //13
            Console.WriteLine(d);  


            d = (a + b) * c; //18
            Console.WriteLine(d);


            d = (a + b) - 6 * c + (12 * 4) / 3 + 12; //25
            Console.WriteLine(d);

            // Integer division  always produces an integer result 
            a = 7; 
            b = 4; 
            c = 3; //
            d = (a + b) / c; //3
            Console.WriteLine(d);
        }
    }
}
