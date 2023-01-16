using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.InterfaceExample
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            //Instanciamos dos clases del tipo ave pasando de parametro el nombre del ave
            Ave canario = new Ave("Canario");
            Ave cuervo = new Ave("Cuervo");
            //Creamos una instancia de nuestra clase principal para llamar el metodo imprimir()
            Principal main = new Principal();
            main.imprimir(canario);
            main.imprimir(cuervo);


            //Polimorfismo de interfaces
            IVehiculo coche = new Coche();
            coche.Arrancar();
            coche.Parar();
            //coche.Clone(); No se puede acceder

            ICloneable cloneable = new Coche();
            cloneable.Clone();

            //Polimorfismo de clases
            Vehiculo vehiculo = new Camion();
            vehiculo.Arrancar();
            vehiculo.Parar();
            vehiculo.Test();

            Console.ReadKey();
        }

        ///

        /// Imprimir the specified ave.
        /// Este metodo imprimira las propiedades de una clase ave.
        ///

        /// Ave.
        public void imprimir(Ave ave)
        {
            //Imprimimos el nombre del ave, el numero de patas y el numero de colas
            Console.WriteLine("Soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
            //Llamamos a nuestros dos metodos de la interface Comer() y Volar()
            Console.WriteLine("Puedo ");
            ave.Comer();
            Console.WriteLine("y tambien puedo ");
            ave.Volar();
        }
    }
}
