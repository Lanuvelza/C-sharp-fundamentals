using System;

namespace Numbers_and_Decimals
{
    class Program
    {
        static void Main(string[] args)
        {
            //maximum and minimum limit of decimals
            decimal min = decimal.MinValue; //-79228162514264337593543950335
            decimal max = decimal.MaxValue; //79228162514264337593543950335
            Console.WriteLine($"The range of the decimal type is {min} and {max}");

            double a = 1.0; 
            double b = 3.0;
            Console.WriteLine(a / b); //0.3333333333333333

            // M indicates that a constant should use decimal type
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d); //0.3333333333333333333333333333

            // maximum and minimum limit of long
            long MIN = long.MinValue; //-9223372036854775808
            long MAX = long.MaxValue; //9223372036854775807
            Console.WriteLine($"The range of the long type is {MIN} and {MAX}");

            // maximum and minimum limit of short
            short min2 = short.MinValue; //-9223372036854775808
            short max2 = short.MaxValue; //9223372036854775807
            Console.WriteLine($"The range of the long type is {min2} and {max2}");

            //Calculating radius of a circle
            double radius = 2.50; 
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
