using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops.Tests
{
    [TestClass()]
    public class PrintProductTests
    {
        [ClassInitialize]
        public static void ClassInitilize(TestContext context)
        {
            PrintProduct.CreateListProduct();
        }

        [TestMethod()]
        public void GetProductGreaterThan30WithForTest()
        {
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithFor().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithFor()[0].Name.Equals("Aceite"));
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithFor()[1].Name.Equals("Juego"));
        }

        [TestMethod()]
        public void GetProductGreaterThan30WithForeachTest()
        {
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithForeach().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithForeach()[0].Name.Equals("Aceite"));
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithForeach()[1].Name.Equals("Juego"));
        }

        [TestMethod()]
        public void GetProductGreaterThan30WithForWhileTest()
        {
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithForWhile().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithForWhile()[0].Name.Equals("Aceite"));
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithForWhile()[1].Name.Equals("Juego"));
        }

        [TestMethod()]
        public void GetProductGreaterThan30WithLinqTest()
        {
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithLinq().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithLinq()[0].Name.Equals("Aceite"));
            Assert.IsTrue(PrintProduct.GetProductGreaterThan30WithLinq()[1].Name.Equals("Juego"));
        }
    }
}