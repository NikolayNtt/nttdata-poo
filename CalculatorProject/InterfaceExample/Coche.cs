using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.InterfaceExample
{
    internal class Coche : IVehiculo, ICloneable
    {
        public void Arrancar()
        {
            Console.WriteLine("Arrancar Coche");
        }

        public object Clone()
        {
            return new Coche();
        }

        public void Parar()
        {
            Console.WriteLine("Parar Coche");
        }
    }
}
