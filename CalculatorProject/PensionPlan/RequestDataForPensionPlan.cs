using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    public class RequestDataForPensionPlan
    {
        public static void RequestDataToUserForPensionPlan()
        {
            var pensionPlan = new PensionPlan();

            Console.WriteLine("1.¿Cuál es tu base imponible?");
            pensionPlan.taxBase = float.Parse(Console.ReadLine());

            Console.WriteLine("2.¿Cuál es la aportación a tu plan de pensiones de persona física?");
            pensionPlan.individualPensionPlanContribution = float.Parse(Console.ReadLine());

            Console.WriteLine("3.¿Cuál es la aportación a tu plan de pensiones de empresa?");
            pensionPlan.companyPensionPlanContribution = float.Parse(Console.ReadLine());

            Console.WriteLine("4.¿Cuál es tu país de residencia? (España/Andorra)");
            pensionPlan.countryOfResidence = Console.ReadLine();

            PensionPlanCalculation.DeductionInTreasury(pensionPlan);
        }
    }
}
