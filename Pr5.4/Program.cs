using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected5
{
    class Program 
    {
        static void Main(string[] args)
        {
            Warehouse[] warehouses = new Warehouse[2];
            for (int i = 0; i < warehouses.Length; i++)
            {
                warehouses[i] = new Warehouse();
                warehouses[i].InputProduct();
            }
            Warehouse.FindProduct(warehouses);
            Console.ReadLine();
        }
    }
}
