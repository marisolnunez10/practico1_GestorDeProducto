using System.Collections.Generic;

namespace practico1_GestorDeProducto
{
  public interface IProductRepository  
    {
        void Add (Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> FilterByCategory(string category  );
    }
}
