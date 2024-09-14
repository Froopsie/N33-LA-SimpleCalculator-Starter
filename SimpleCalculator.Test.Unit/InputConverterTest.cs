﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        
        //private readonly InputConverter _inputConverter = new InputConverter();

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
