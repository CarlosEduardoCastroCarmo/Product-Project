using System;
using System.Collections.Generic;
using Product.Entities;
using System.Globalization;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.WriteLine("Common, used or imported: ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(type == 'c' || type == 'C')
                {
                    Products p = new Products(name, price);

                    list.Add(p);
                }

                else if(type == 'u'|| type == 'U')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YY): ");
                    DateTime manufactueDate = DateTime.Parse(Console.ReadLine());

                    Products usedProd = new UsedProduct(name, price, manufactueDate);

                    list.Add(usedProd);
                }
                else
                {
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Products importedProd = new ImportedProduct(name, price, customsFee);

                    list.Add(importedProd);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tag´s: ");

            foreach (Products prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
