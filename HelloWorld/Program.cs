using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string aFriend = "Bill"; 
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);

            // String Interpolation 
            Console.WriteLine($"Hello {aFriend}");
        }
    }
}
