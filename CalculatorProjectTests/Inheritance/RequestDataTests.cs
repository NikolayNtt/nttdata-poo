using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance.Tests
{
    [TestClass()]
    public class RequestDataTests
    {
        [TestMethod()]
        public void FindStudentsGreaterThan30LiveMadridNameStartsSTest()
        {
            var list = new List<Student>();

            var student_1 = new Student("Sergio", "Pérez", DateTime.ParseExact("12/04/1980", "dd/MM/yyyy", null), new Address("Av. América", "Madrid", "Comunidad de Madrid"));
            list.Add(student_1);

            var student_2 = new Student("Sandra", "Jiménez", DateTime.ParseExact("27/01/1999", "dd/MM/yyyy", null), new Address("Calle Alcala", "Madrid", "Comunidad de Madrid"));
            list.Add(student_2);

            var student_3 = new Student("Pedro", "Cano", DateTime.ParseExact("02/02/2000", "dd/MM/yyyy", null), new Address("Gran Vía", "Madrid", "Comunidad de Madrid"));
            list.Add(student_3);

            var student_4 = new Student("Samuel", "Sánchez", DateTime.ParseExact("19/12/1970", "dd/MM/yyyy", null), new Address("La Rambla", "Barcelona", "Cataluña"));
            list.Add(student_4);

            Assert.IsTrue(RequestData.FindStudentsGreaterThan30LiveMadridNameStartsS(list).Count == 1);
            Assert.IsTrue(RequestData.FindStudentsGreaterThan30LiveMadridNameStartsS(list)[0].name.Equals("Sergio"));
            Assert.IsTrue(RequestData.FindStudentsGreaterThan30LiveMadridNameStartsS(list)[0].age > 30);
            Assert.IsTrue(RequestData.FindStudentsGreaterThan30LiveMadridNameStartsS(list)[0].address.city.Equals("Madrid"));
        }
    }
}