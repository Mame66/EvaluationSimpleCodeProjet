using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using EvaluationSampleCode;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {

        [TestMethod]
        [DataRow(2, 3, 5)]
        [DataRow(0, 5, 5)]
        [DataRow(-2, 2, 0)]
        public void Add_WithValidNumbers_ShouldReturnSum(int numberOne, int numberTwo, int expectedResult)
        {
          
            var mathOperations = new MathOperations();

            var result = mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(9, 3, 3)]
        public void Divide_WithValidNumbers_ShouldReturnDivision(int numberOne, int numberTwo, float expectedResult)
        {
            var mathOperations = new MathOperations();

            var result = mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Divide_WithSecondParameterEqualZero_ShouldThrowArgumentException()
        {
            var mathOperations = new MathOperations();

            Assert.ThrowsException<ArgumentException>(() =>
                mathOperations.Divide(10, 0)
            );
        }


        [TestMethod]
        public void GetOddNumbers_WithZeroLimit_ShouldReturnEmptyList()
        {
            var mathOperations = new MathOperations();

            var result = mathOperations.GetOddNumbers(0);

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void GetOddNumbers_WithNegativeLimit_ShouldThrowArgumentException()
        {
            var mathOperations = new MathOperations();

            Assert.ThrowsException<ArgumentException>(() =>
                mathOperations.GetOddNumbers(-1)
            );
        }
    }
}
