using MyFinance.Domain.Entities;
using MyFinance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product() { DateProd=DateTime.Now,
                                        Name="Anzass",
                                        Price=3.250,
                                        Quantity=15};
            ServiceProduct sp = new ServiceProduct();
            //sp.AddProduct(p);
            //sp.Commit();
            System.Console.WriteLine("aa");
            sp.Add(p);
            sp.Commit();

        }
    }
}
