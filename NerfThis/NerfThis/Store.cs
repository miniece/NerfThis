using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerfThis
{
    public class Store
    {
        public List<Product> Products { get; set; }
        public Store(List<Product> products)
        {
            Products = products;
        }

        public void PrintInventory()
        {
            for(int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i+1}:  \t{Products[i].Name, -40}  ${Products[i].Price, -10}");    
            }
        }
        public void PrintCart()
        {
            
        }
    }
}
