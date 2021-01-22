using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoriyId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitInStock = 3;

            //Diger gösterim 
            Product product2= new Product { Id=2,CategoriyId=5,ProductName=
            "Kalem",UnitPrice=15,UnitInStock=50};

            //Pascal Case   //Camel Case 
            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            Console.WriteLine(product.ProductName);

            /*
            int sayi = 100;
            productManager.DoSomething(sayi);
            Console.WriteLine(sayi);
            */
            // int double bool değer tipler
            // diziler,class ,abstract class, interface referans tip

        }
    }
}
