using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Address : NttDataBase
    {
        public string street;
        public string city;
        public string region;

        public Address(string street, string city, string region)
        {
            this.street = street;
            this.city = city;
            this.region = region;
        }
    }
}
