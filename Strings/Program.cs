using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "Maria";
            string secondFriend = "Sage"; 
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            // Length properties
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters"); 
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters"); 


            // Trimming white-spaces
            string greeting = "      Hello World!     ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart(); 
            Console.WriteLine($"[{trimmedGreeting}]"); 

            trimmedGreeting = greeting.TrimEnd(); 
            Console.WriteLine($"[{trimmedGreeting}]"); 

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // Replace String
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            // Upper and Lower case
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
        }
    }
}
