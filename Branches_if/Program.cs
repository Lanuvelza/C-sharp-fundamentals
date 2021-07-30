using System;

namespace Branches_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional if statement
            int a = 5;
            int b = 6; 
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10."); 

            b = 3; 
            if (a + b > 10) 
                Console.WriteLine("The answer is greater than 10."); //this line will not be executed.

            b = 6; 
            bool something = a + b > 10; 
            if (something)
                Console.WriteLine("The answer is greater than 10."); 

            // with else statement
            b = 3; 
            if (a + b > 10) 
                Console.WriteLine("The answer is greater than than 10."); 
            else    
                Console.WriteLine("The answer is not greater than 10.");

            // without curly braces, an if statement will execute the first statement after it 
            // we can also do with curly braces for mutiple executions inside if statements.
            if (a + b > 10) {
                Console.WriteLine("The answer is greater than 10.");
            }
            else {
                Console.WriteLine("The answer is not greater than 10.");
            }

            int c = 4;
            // AND statement
            if ((a + b + c > 10) && (a == b)) {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first number is equal to the second number"); 
            }
            else {
                Console.WriteLine("The answer is not greater than 10."); 
                Console.WriteLine("Or the first number is not equal to the second numbers");
            }

            // OR statement
            if ((a + b + c > 10) || (a == b)) {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("Or the first number is equal to the second number"); 
            }
            else {
                Console.WriteLine("The answer is not greater than 10."); 
                Console.WriteLine("And the first number is not equal to the second numbers");
            }
        }
    }
}
