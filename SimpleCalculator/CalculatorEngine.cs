using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            bool flag = false;
            while (!flag)
            {
                switch (argOperation)
                {
                    case "add":
                    case "+":
                        result = argFirstNumber + argSecondNumber;
                        flag = true;
                        break;

                    case "minus":
                    case "-":
                        result = argFirstNumber - argSecondNumber;
                        flag = true;
                        break;

                    case "multiply":
                    case "*":
                        result = argFirstNumber * argSecondNumber;
                        flag = true;
                        break;

                    case "divide":
                    case "/":
                        result = argFirstNumber / argSecondNumber;
                        flag = true;
                        break;

                    case "modulus":
                    case "%":
                        result = argFirstNumber % argSecondNumber;
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input : (+, -, \\, *, % or add, minus, multiply, divide, modulus)");
                        break;
                }

                argOperation = Console.ReadLine();
            }
            return result;
        }
    }
}