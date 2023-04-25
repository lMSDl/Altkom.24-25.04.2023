using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    public interface IProductsService
    {
        public void Show();

        public void Add(Product product);

        public void Remove(int position);
    }
}
