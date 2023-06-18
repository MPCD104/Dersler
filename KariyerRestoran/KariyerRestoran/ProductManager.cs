using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerRestoran
{
    public class ProductManager : IProductManager
    {
        public List<Product> Products { get; set; }
        public ProductManager()
        {
            if (Products == null)
            {
                Products = new List<Product>();
            }
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            Products.Remove(Products.FirstOrDefault(x => x.Id == product.Id));
        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public void UpdateProduct(Product product)
        {
            foreach (Product item in Products)
            {
                if (item.Id == product.Id)
                {
                    item.Name = product.Name;
                    item.Price = product.Price;
                    MessageBox.Show("Ürün başarı ile güncellendi.");
                    return;
                }
            }
            MessageBox.Show("Ürün bulunamadı.");
        }
    }
}
