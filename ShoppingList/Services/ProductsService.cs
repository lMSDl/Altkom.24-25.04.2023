using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    public class ProductsService
    {
        private readonly List<Product> products = new List<Product>();
    
        public void Show()
        {
            for (int i = 0; i < products.Count; i++) {
                Product? product = products[i];
                Console.WriteLine($"{i+1}. {product.Name} x{product.Quantity}");
            }
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(int position) 
        { 
            products.RemoveAt(position);
        }
    }
}
