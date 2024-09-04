using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            switch(argOperation){
                case "add":
                case ""+"":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "minus":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;

                case "modulus":
                case "%":
                    result = argFirstNumber % argSecondNumber;
                    break;
            }
            

            return result;
        }
    }
}
