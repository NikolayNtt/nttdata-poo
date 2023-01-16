using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    public class PensionPlan
    {
        public float taxBase;
        public float individualPensionPlanContribution;
        public float companyPensionPlanContribution;
        public string countryOfResidence;

        public PensionPlan() { }
        public PensionPlan(float taxBase, float individualPensionPlanContribution, float companyPensionPlanContribution, string countryOfResidence)
        {
            this.taxBase = taxBase;
            this.individualPensionPlanContribution = individualPensionPlanContribution;
            this.companyPensionPlanContribution = companyPensionPlanContribution;
            this.countryOfResidence = countryOfResidence;
        }
    }
}
