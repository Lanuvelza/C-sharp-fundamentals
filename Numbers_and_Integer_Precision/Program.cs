using System;

namespace Numbers_and_Integer_Precision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7; 
            int b = 4; 
            int c = 3; 
            int d = (a + b) / c; //3

            // modulo operator returns remainder
            int e = (a + b) % c; //2

            Console.WriteLine($"quotient: {d}"); 
            Console.WriteLine($"remainder: {e}");

            //maximum and minimum limit of int
            int max = int.MaxValue; //2147483647
            int min = int.MinValue; //-2147483648
            Console.WriteLine($"The range of integers is {min} and {max}.");


            // Overflow describes where if we exceed the maximum, we obtain an integer number very similar to that of the minimum 
            // This is because overflow starts over from the largest possible integer value to the smallest. 
            // max + 3 => min + 2 
            int what = max + 3; 
            Console.WriteLine($"An example of overflow: {what}");


            // double type - decimals 
            double A = 7; 
            double B = 4; 
            double C = 2; 
            double D = (A + B) / C; //5.5
            Console.WriteLine(D);

            // double will only return a decimal value if at least one of the other variables is a double 
            double E = (a + b) / C; //5.5
            Console.WriteLine(E);

            double F = (a + b) / c; //3 
            Console.WriteLine(F);

            // maximum and minimum limit of double 
            double MAX = double.MaxValue; //1.7976931348623157E+308
            double MIN = double.MinValue; //-1.7976931348623157E+308
            Console.WriteLine($"The range of double is {MIN} and {MAX}");


            // returns 0.3 repeating rather that 1/3, which is not rounded
            double third = 1.0 / 3.0; //0.3333333333333333
            Console.WriteLine(third);
        }
    }
}
