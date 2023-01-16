using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class PrintProduct
    {
        private static List<Product> products = new List<Product>();

        public static void CreateListProduct()
        {
            var potatoes = new Product
            {
                Id = 1,
                Name = "Tomates",
                Price = 24.56f
            };
            products.Add(potatoes);

            var oil = new Product
            {
                Id = 2,
                Name = "Aceite",
                Price = 35.27f
            };
            products.Add(oil);

            var game = new Product
            {
                Id = 3,
                Name = "Juego",
                Price = 45.99f
            };
            products.Add(game);

            var shoes = new Product(4, "Zapatos", 20.99f);
            products.Add(shoes);

            Console.WriteLine(shoes.ToString());
        }

        public static List<Product> GetProductGreaterThan30WithFor()
        {
            var productGreaterThan30WithFor = new List<Product>();
            for (int positionOfTheList = 0; positionOfTheList <= 2; positionOfTheList++)
            {
                if (products[positionOfTheList].Price > 30)
                {
                    productGreaterThan30WithFor.Add(products[positionOfTheList]);
                }
            }

            return productGreaterThan30WithFor;
        }

        public static List<Product> GetProductGreaterThan30WithForeach()
        {
            var productGreaterThan30WithForeach = new List<Product>();
            foreach (var selectedProduct in products)
            {
                if (selectedProduct.Price > 30)
                {
                    productGreaterThan30WithForeach.Add(selectedProduct);
                }
            }
            return productGreaterThan30WithForeach;
        }

        public static List<Product> GetProductGreaterThan30WithForWhile()
        {
            var productGreaterThan30WithForWhile = new List<Product>();

            var lap = 0;
            while (lap < products.Count)
            {
                if (products[lap].Price > 30)
                {
                    productGreaterThan30WithForWhile.Add(products[lap]);
                }
                lap++;
            }
            return productGreaterThan30WithForWhile;
        }

        public static List<Product> GetProductGreaterThan30WithLinq()
        {
            var queryproductsGreaterThan30 = 
                from product in products
                where product.Price > 30
                select product;
            
            return queryproductsGreaterThan30.ToList(); ;
        }
    }
}
