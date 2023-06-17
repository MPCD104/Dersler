using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerRestoran
{
    public interface IProductManager
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product); 
        List<Product> GetAllProducts();
    }
}
