using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
first number = input from user ~ if number is not numeric -> Warning
second number = input from user ~ if number is not numeric -> Warning 
operation = input from user ~ lower case the operation name (case insensivity) ~~ if operation symbol is not recognized -> Warning
*/
/*
VARIABLES
 - string = text
 - int = numbers
 - double = number with parts
 - bool = boolean true/false
 - var = implicit type of variable
*/
namespace Calculator
{
    class Program
    {
        public static void ExitApp(int exitCode)
        {
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
            Environment.Exit(exitCode);
        }

        public static string ChooseOperation()
        {
            Console.WriteLine("\nPlease input the operation type [ h - help ]");
            string input = Console.ReadLine();
            return input.ToLower();
        }

        public static int InputValue(string message)
        {
            Console.WriteLine(message);
            string val = Console.ReadLine();
            if (!(int.TryParse(val, out int valInt)))
            {
                Console.WriteLine("\nIncorrect number");
                ExitApp(1);
            }
            
            return valInt;
        }

        static void Main()
        {
            int firstValInt = InputValue("Please input the first number:");
            int secondValInt = InputValue("\nPlease input the second number:");
            string operation = ChooseOperation();
            Person person1 = new Person();
            
            if (operation == "h")
            {
                do
                {
                    Console.WriteLine("\nPossible choices:\n - addition ('+' or 'add')\n - subtraction ('-' or 'sub')\n - multiplication ('*' or 'multi')\n - division ('/' or 'div')\n");
                    operation = ChooseOperation();
                }
                while (operation == "h");
            }

            Console.WriteLine(Environment.NewLine);
            if (operation == "+" || operation == "addition" || operation == "add")
            {
                Console.WriteLine(firstValInt + secondValInt);
            }
            else if (operation == "-" || operation == "subtraction" || operation == "sub")
            {
                Console.WriteLine(firstValInt - secondValInt);
            }
            else if (operation == "*" || operation == "multiplication" || operation == "multi")
            {
                Console.WriteLine(firstValInt * secondValInt);
            }
            else if (operation == "/" || operation == "division" || operation == "div")
            {
                Console.WriteLine(firstValInt / secondValInt);
            }
            else
            {
                Console.WriteLine("Unsupported operation type");
            }

            ExitApp(0);
        }
    }
}
