using System;
using System.Collections.Generic;
using Produtos_comuns_usados_e_importados_.Entities;

namespace Produtos_comuns_usados_e_importados_

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> P_List = new List<Product>();
            Console.Write("Enter the number of products: ");
            int Qty = int.Parse(Console.ReadLine());
            for (int i = 0; i < Qty; i++)
            {
                Console.Write("Common, Used or Imported? (c/u/i): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price =double.Parse(Console.ReadLine());
                

                if (type == 'u')
                {
                    Console.Write("Manufacture Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    P_List.Add(new UsedProduct(name, price, date));
                }
                else if (type == 'i')
                {
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    P_List.Add(new ImProduct(name, price, fee));
                }
                else
                    P_List.Add(new Product(name, price));
            }

            Console.WriteLine("Price Tags");
            foreach(Product p in P_List)
            {
                Console.WriteLine($"{p.PriceTag().ToString()}");
            }
        }
    }
}
