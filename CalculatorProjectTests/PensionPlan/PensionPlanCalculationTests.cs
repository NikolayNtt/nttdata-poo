using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.PensionPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan.Tests
{
    [TestClass()]
    public class PensionPlanCalculationTests
    {
        [TestMethod()]
        public void DeductionInTreasuryTest()
        {
            var pensionPlan = new PensionPlan(50000f, 1500f, 8500f, "España");
            Assert.IsTrue(PensionPlanCalculation.DeductionInTreasury(pensionPlan) == 3700f);
        }

        [TestMethod()]
        public void CalculatePensionPlanSpainTest()
        {
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanSpain(12539) == 19);
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanSpain(20199f) == 24);
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanSpain(35199f) == 30);
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanSpain(59999f) == 37);
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanSpain(299999f) == 45);
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanSpain(300000f) == 47);
        }

        [TestMethod()]
        public void CalculatePensionPlanAndorraTest()
        {
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanAndorra(23999f) == 0);
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanAndorra(39999f) == 5);
            Assert.IsTrue(PensionPlanCalculation.CalculatePensionPlanAndorra(40000f) == 10);
        }
    }
}