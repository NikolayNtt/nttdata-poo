using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [TestMethod()]
        public void AddTest()
        {
            Assert.IsTrue(calculator.Add(2, 2) == 4);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(calculator.Multiply(2, 2) == 4);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsTrue(calculator.Divide(10, 2) == 5);
        }
    }
}