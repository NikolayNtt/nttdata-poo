using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class RequestData
    {
        public static List<Student> students = new List<Student>();

        public static void RequestDataToUser()
        {
            Console.WriteLine("Indique su nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indique su apellido: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Indique su cumpleaños (dd/mm/aaaa): ");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Indique su calle: ");
            string street = Console.ReadLine();
            Console.WriteLine("Indique su ciudad: ");
            string city = Console.ReadLine();
            Console.WriteLine("Indique su region: ");
            string region = Console.ReadLine();

            var address = new Address(street, city, region);

            var student = new Student(name, surname, birthday, address);

            students.Add(student);
        }

        public static List<Student> FindStudentsGreaterThan30LiveMadridNameStartsS(List<Student> listOfGenericStudents) 
        {
            var  listOFoundStudents = new List<Student>();

            var queryOfFoundStudents =
                from student in listOfGenericStudents
                where student.age > 30d && student.address.city.Equals("Madrid") && student.name.StartsWith("S")
                select student;

            listOFoundStudents = queryOfFoundStudents.ToList();
            return listOFoundStudents;
        }

    }
}
