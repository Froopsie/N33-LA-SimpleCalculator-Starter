using System;
using CalcLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                bool worked;
                double firstNumber= 0;
                double secondNumber = 0;

                while (true)
                {
                    Console.WriteLine("Enter Your First Number:");
                    firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine(), out worked);
                    if (worked)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry. Please try again.");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter Your Second Number");
                    secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine(), out worked);
                    if (worked)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's incorrect. Please try again");
                    }
                }
                string operation;
              
                try
                {
                    Console.WriteLine("Enter Your Operation Sign of Choice. (+, -, \\, *, % or add, minus, multiply, divide, modulus)");
                    operation = Console.ReadLine().ToLower();

                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                    Console.WriteLine("The final answer is: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter a Valid Operation Sign.");
                    Console.WriteLine(ex.Message);
                }
            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
