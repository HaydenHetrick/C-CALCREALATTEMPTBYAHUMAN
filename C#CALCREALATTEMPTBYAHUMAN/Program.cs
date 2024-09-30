using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CALCREALATTEMPTBYAHUMAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 100% Human Written Calculator! Errors and All! \n");

            Console.WriteLine("What type of math would you like to do?: ");
            Console.WriteLine("1. Subtract");
            Console.WriteLine("2. Multiply");
            Console.WriteLine("3. Divide");

            Console.WriteLine("Enter the number of the operation you would like to do: ");
            string userChoice = Console.ReadLine();

            Console.WriteLine("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            if (userChoice == "1")
            {
                result = firstNumber - secondNumber;
            }
            else if (userChoice == "2") 
            {
                result = firstNumber * secondNumber;
            }
            else if (userChoice == "3") 
            {
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                }
                else
                {
                    validOperation = false; 
                }
            }
            else
            {
                validOperation = false;
            }

            if (validOperation)
            {
                Console.WriteLine($"The result is: {result}");
            }
            else 
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadLine();
        }
    }
}
