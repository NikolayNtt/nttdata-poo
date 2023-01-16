using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    public class PensionPlanCalculation
    {
        public static float DeductionInTreasury(PensionPlan pensionPlan)
        {
            var deductionPercentage = 0;

            if (pensionPlan.countryOfResidence.Equals("España"))
            {
                deductionPercentage = CalculatePensionPlanSpain(pensionPlan.taxBase);
            } 
            else if (pensionPlan.countryOfResidence.Equals("Andorra"))
            {
                deductionPercentage = CalculatePensionPlanAndorra(pensionPlan.taxBase);
            } 
            else
            {
                Console.WriteLine("El país introducido no esta en la lista o es incorrecto");
                RequestDataForPensionPlan.RequestDataToUserForPensionPlan();
            }

            Console.WriteLine("Usted se desgrava un " + deductionPercentage + "% lo cual sería/n " + 
                (pensionPlan.individualPensionPlanContribution + pensionPlan.companyPensionPlanContribution) * (deductionPercentage / 100f) + " euros.");
            return (pensionPlan.individualPensionPlanContribution + pensionPlan.companyPensionPlanContribution) * (deductionPercentage / 100f) ;
        }


        public static int CalculatePensionPlanSpain(float taxBase)
        {
            var deductionPercentageForTheTaxBaseInSpain = 0;

            if (taxBase < 12540f)
            {
                deductionPercentageForTheTaxBaseInSpain = 19;
            }
            else if (taxBase < 20200f)
            {
                deductionPercentageForTheTaxBaseInSpain = 24;
            }
            else if (taxBase < 35200f)
            {
                deductionPercentageForTheTaxBaseInSpain = 30;
            }
            else if (taxBase < 60000f)
            {
                deductionPercentageForTheTaxBaseInSpain = 37;
            }
            else if (taxBase < 300000f)
            {
                deductionPercentageForTheTaxBaseInSpain = 45;
            }
            else if(taxBase >= 300000f)
            {
                deductionPercentageForTheTaxBaseInSpain = 47;
            } else
            {
                Console.WriteLine("El valor introducido es incorrecto");
            }

            return deductionPercentageForTheTaxBaseInSpain;
        }

        public static int CalculatePensionPlanAndorra(float taxBase)
        {
            var deductionPercentageForTheTaxBaseInAndorra = 0;

            if (taxBase < 24000f)
            {
                deductionPercentageForTheTaxBaseInAndorra = 0;
            } else if (taxBase < 40000f)
            {
                deductionPercentageForTheTaxBaseInAndorra = 5;
            } else if (taxBase >= 40000)
            {
                deductionPercentageForTheTaxBaseInAndorra = 10;
            } else
            {
                Console.WriteLine("El valor introducido es incorrecto");
            }

            return deductionPercentageForTheTaxBaseInAndorra;
        }
    }
}
