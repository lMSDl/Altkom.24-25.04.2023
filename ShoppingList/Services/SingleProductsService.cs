using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    public class SingleProductsService : IProductsService
    {
        private Product product = null;
    
        public void Show()
        {
            if(product != null)
                Console.WriteLine($"1. {product.Name} x{product.Quantity}");
        }

        public void Add(Product product)
        {
            this.product = product;
        }

        public void Remove(int position) 
        {
            product = null;
        }
    }
}
