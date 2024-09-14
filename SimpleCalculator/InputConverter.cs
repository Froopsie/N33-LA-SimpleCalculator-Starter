using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput, out Boolean state )
        {
            try
            {
              double result = double.Parse(argTextInput);
                state = true;
                return result;

            }
            catch
            {
                state = false;
                return double.NaN;
            }
        }
    }
}
