using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            bool worked;
            string inputNumber = "5";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber, out worked);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            bool worked;
            string inputNumber = "*";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber, out worked);
            Assert.AreEqual(2, convertedNumber);
        }
    }
}
