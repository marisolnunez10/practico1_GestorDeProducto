using System.Collections.Generic;
using System.Linq;

namespace practico1_GestorDeProducto
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository() 
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "HP Laptop", Price = 10.99m, Category = "Technology", IsActive = true },
                new Product { Id = 2, Name = "iPad", Price = 30.99m, Category = "Technology", IsActive = true },
                new Product { Id = 3, Name = "Mario Bros Wonder", Price = 59.99m, Category = "Gamer", IsActive = true },
                new Product { Id = 4, Name = "Hollow Knight", Price = 69.99m, Category = "Gamer", IsActive = true },
            };
        }
        public void Add(Product product)
        { 
           _products.Add(product);
        }
        public List<Product> GetAll()
        { 
            return _products.ToList();
        }
        public Product GetById(int id)
        { 
            return _products.FirstOrDefault(p => p.Id == id);
        }   
        public List<Product> FilterByCategory(string category)
        { 
            return _products.Where(p => p.Category.ToLower() == category.ToLower()).ToList();
        }
    }       
}

