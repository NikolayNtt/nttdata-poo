using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorProject.Inheritance
{
    public class Student : NttDataBase
    {
        public string name;
        public string surname;
        public DateTime birthday;
        public double age;
        public Address address;

        public Student(string name, string surname, DateTime birthday, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.age = CalculateAge();
            this.address = address;
        }
        public override string ToString()
        {
            return "Student: " + name + ", " + surname + ", " + birthday + ", " + this.age;
        }

        private double CalculateAge()
        {
            var days = (DateTime.Now - this.birthday).TotalDays;

            return Math.Floor(days / 365);
        }

    }
}
