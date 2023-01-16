using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.InterfaceExample
{
    internal class Moto : IVehiculo, ICloneable
    {
        public void Arrancar()
        {
            Console.WriteLine("Arrancar Moto");
        }

        public object Clone()
        {
            return new Moto();
        }

        public void Parar()
        {
            Console.WriteLine("Parar Moto");
        }
    }
}
