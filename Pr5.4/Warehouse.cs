using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected5
{
    class Warehouse : IComparable<Warehouse>
    {
        private string Manufacturer { get; set; }
        private string TypeOfItem { get; set; }
        private double Price { get; set; }
        private double Dimension { get; set; }
      
        public void InputProduct()
        {
           
            Console.Write("Enter manufacturer of product: ");
            Manufacturer = Console.ReadLine();
                
            Console.Write("Enter type of item: ");
              TypeOfItem = Console.ReadLine();

            Console.Write("Enter price: ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Dimension: ");
            Dimension = Convert.ToDouble(Console.ReadLine());
        }

        public void OutputProduct()
        {
            Console.WriteLine($"Manufacturer is {Manufacturer}");
            Console.WriteLine($"Type of item is {TypeOfItem}");
            Console.WriteLine($"Price is {Price}");
            Console.WriteLine($"Dimension is {Dimension}");
        }

        public static void FindProduct(Warehouse[] products)
        {
            Console.WriteLine("You want to find product by price, type or dimension?:");
            string searchValue = Console.ReadLine();
            switch (searchValue)
            {
                case "price":
                    SearchByPrice(products);
                    break;
                case "type":
                    SearchByType(products);
                    break;
                case "dimension":
                    SearchByDimension(products);
                    break;
                default:
                    Console.WriteLine("Wrong value!");
                    break;
            }
        }

        private static void SearchByPrice(Warehouse[] products)
        {
            bool someImportantValue = true;
            Console.Write("Enter searched price: ");
            double searchedPrice= Convert.ToDouble(Console.ReadLine());
            
            foreach (var product in products)
            {
                if(product.Price == searchedPrice)
                {
                    product.OutputProduct();
                    someImportantValue = false;
                }
            }
            if (someImportantValue)
            {
                Console.WriteLine("There is no such products");
            }
        }

        private static void SearchByType(Warehouse[] products)
        {
            bool someImportantValue = true;
            Console.Write("Enter searched type: ");
            string searchedType = Console.ReadLine();

            foreach (var product in products)
            {
                if (product.TypeOfItem == searchedType)
                {
                    product.OutputProduct();
                    someImportantValue = false;
                }
            }
            if (someImportantValue)
            {
                Console.WriteLine("There is no such products");
            }
        }
        
       
        private static void SearchByDimension(Warehouse[] products)
        {
            bool someImportantValue = true;
            Console.Write("Enter searched dimension: ");
            double searchedDimension= Convert.ToDouble(Console.ReadLine());


            foreach (var product in products)
            {
                if (product.Dimension == searchedDimension)
                {
                    product.OutputProduct();
                    someImportantValue = false;
                }
            }
            if (someImportantValue)
            {
                Console.WriteLine("There is no such products");
            }
        }

        public int CompareTo(Warehouse temp)
        {
            return this.Price.CompareTo(temp.Price);
        }
    }
}
