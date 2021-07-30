using System;

namespace SearchingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "You say goodbye, and I say hello";

            // Checks if a substring exists within a string
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            var result = songLyrics.Contains("goodbye"); 
            Console.WriteLine(result);

            // Checks if the string begins with "goodbye"
            result = songLyrics.StartsWith("goodbye");
            Console.WriteLine(result);

            // Checks if the string begins with "You"
            result = songLyrics.StartsWith("You");
            Console.WriteLine(result);

            // Checks if the string ends with "You"
            result = songLyrics.EndsWith("You");
            Console.WriteLine(result);

            // Checks if the string ends with "hello"
            result = songLyrics.EndsWith("hello");
            Console.WriteLine(result);

        }
    }
}
