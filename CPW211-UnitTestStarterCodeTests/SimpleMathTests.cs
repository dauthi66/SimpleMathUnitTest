using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [TestCategory("Addition Method")]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {           
            double expectedSum = num1 + num2;
            double actualSum = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(-100, 10)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [TestCategory("Subtraction Method")]
        public void Add_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            double expectedSum = num1 - num2;
            double actualSum = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [TestCategory("Multiplication Method")]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expectedSum = num1 * num2;
            double actualSum = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod()]
        [DataRow(5, 0)]
        [DataRow(-1, 0)]
        [DataRow(0, 0)]
        [TestCategory("Division Method")]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            Assert.ThrowsException<DivideByZeroException>(() => SimpleMath.Divide(num1, num2));
        }

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(-100, 10)]
        [DataRow(-100, -10)]
        [DataRow(0, 1)]
        [TestCategory("Division Method")]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            double expectedSum = num1 / num2;
            double actualSum = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}