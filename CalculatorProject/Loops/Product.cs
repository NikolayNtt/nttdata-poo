using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public float Price { get; set; }

        public Guid Guid { get; set; }

        public Product() 
        { 
            Guid= Guid.NewGuid();
        }

        public Product(int id, string name, float price) 
        {
            Name = name;
            Id= id;
            Price = price;
            Guid= Guid.NewGuid();
        }

        public override string ToString()
        {
            return "Product: " + Name + ", " + Id + ", " + Price;
        }
    }
}
