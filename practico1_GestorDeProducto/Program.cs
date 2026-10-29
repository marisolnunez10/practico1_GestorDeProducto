using System;
namespace practico1_GestorDeProducto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductRepository repo = new ProductRepository();

            Console.WriteLine("1.FULL LIST");
            foreach (var p in repo.GetAll()) Console.WriteLine(p);

            Console.WriteLine("\n 2. SEARCH BY ID (2)");
            Console.WriteLine(repo.GetById(2));

            Console.WriteLine("\n 3. FILTER BY CATEGORY (Gamer)");
            foreach (var p in repo.FilterByCategory("Gamer")) Console.WriteLine(p);

            Console.WriteLine("\n 3. FILTER BY CATEGORY (Technology)");
            foreach (var p in repo.FilterByCategory("Technology")) Console.WriteLine(p);

            Console.WriteLine("\n 4. ADD NEW PRODUCT");
            repo.Add(new Product { Id = 5, Name = "27 inch Monitor", Category = "Technology", Price = 299.99m, IsActive = true });
            foreach (var p in repo.GetAll()) Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
