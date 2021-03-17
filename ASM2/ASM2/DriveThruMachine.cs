using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class DriveThruMachine
    {
        public double totalcost;

        public List<Product> items = new List<Product>();

        public DriveThruMachine()
        {
            Console.WriteLine("Drive thru machine initiated");
        }
        public void addOrder(int product)
        {
            
            foreach (Product item in items)
            {
                if (item.item == product)
                {
                    item.quantity += 1;
                    Console.WriteLine("Drive thru machine: item's quantity added");
                    return;
                }
            }
            items.Add(new Product(product, 1));
            Console.WriteLine("Drive thru machine: item added");
        }
        public void removeProduct(int input)
        {
            foreach(Product item in items)
            {
                if(item.item == input)
                {
                    if (item.quantity == 1)
                    {
                        items.Remove(item);
                        break;
                    }
                    else item.quantity--;
                }
            }
        }
        public List<Product> requestOrders()
        {
            return items;
        }
    }

    class Product
    {
        public int item;
        public int quantity;
        public Product() { }
        public Product(int item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }

    }
}
