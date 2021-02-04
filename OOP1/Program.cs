using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            // şöyle de oluşturabiliriz. >>>>> below

            Product product2 = new Product { Id = 2, CategoryId = 5,
                UnitsInStock = 6, ProductName = "Kalem", UnitPrice = 35 };


            //pascalCase   //camelCase
            ProductManager productmanager = new ProductManager();
            productmanager.Add(product1);
            

            int toplam = productmanager.Topla(3, 6);
            Console.WriteLine(toplam*2);  // thanks to return(in topla method)...



        }
    }
}
