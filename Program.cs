using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Calculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstNumber, secondNumber;
                Console.WriteLine("Enter first number:");
                bool result = double.TryParse(Console.ReadLine(), out firstNumber);

                while (!result)
                {
                    Console.WriteLine("Please enter only numbers!");
                    result = double.TryParse(Console.ReadLine(), out firstNumber);
                }

                Console.WriteLine("Enter operation (+,-,/,*,%):");
                string operation = Console.ReadLine();

                Console.WriteLine("Enter second number:");
                result = double.TryParse(Console.ReadLine(), out secondNumber);

                while (!result)
                {
                    Console.WriteLine("Please enter only numbers!");
                    result = double.TryParse(Console.ReadLine(), out secondNumber);
                }

                switch (operation)
                {
                    case "+":
                        {
                            Console.WriteLine(firstNumber + "+" + secondNumber + "=" + (firstNumber + secondNumber));
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine(firstNumber + "-" + secondNumber + "=" + (firstNumber - secondNumber));
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine(firstNumber + "*" + secondNumber + "=" + (firstNumber * secondNumber));
                            break;
                        }
                    case "/":
                        {
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Can't be divided by zero.");
                                break;
                            }
                            Console.WriteLine(firstNumber + "/" + secondNumber + "=" + firstNumber / secondNumber);
                            break;
                        }
                    case "%":
                        {
                            Console.WriteLine(firstNumber + "%" + secondNumber + "=" + (firstNumber * (secondNumber / 100)));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter from these operations (+,-,*,/,%)");
                            break;
                        }
                }
                        Console.WriteLine();
            }
        }
    }
}
