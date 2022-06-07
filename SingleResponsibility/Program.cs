using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
    }
    class Product
    {
        //property
        public int Id { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class ProductManager
    {
        //CRUD operations
        public void Add()
        {
            Console.WriteLine("added complete");
        }
        public void Update()
        {
            Console.WriteLine("updated complete");
        }

        public void Delete()
        {
            Console.WriteLine("deleted complete");
        }

        public void List()
        {
            Console.WriteLine("listed complete");
        }
    }
}
