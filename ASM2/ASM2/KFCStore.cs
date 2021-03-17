using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class KFCStore
    {
        public List<IItem> items = new List<IItem>();
        IFactory factory;
        private static KFCStore store;
        private double totalcost;
        IDiscount discount = new NoDiscount();
        private KFCStore() { }

        public void removeItem(string choice, int quantity)
        {
            foreach (IItem item in items)
            {
                if (item.name == choice && item.getQuantity() == quantity)
                {
                    Console.WriteLine(item + " has been removed");
                    items.Remove(item);
                    return;
                }
            }
        }
        public static KFCStore getKFCStore()
        {
            if (store == null)
            {
                Console.WriteLine("No KFCStore instance exist");
                store = new KFCStore();
                Console.WriteLine("KFCStore instance initiated");
            }
            return store;
        }
        public double getTotalCost()
        {
            totalcost = 0;
            foreach (IItem item in items)
            {
                totalcost += item.getCost();
            }
            return discount.calDiscount(totalcost);
        }
        public void addItem(string choice, int quantity)
        {
            factory = new FoodFactory();
            Console.WriteLine("Request for object creation");
            items.Add(factory.makeItem(choice, quantity,factory));
        }
        public IDiscount GetDiscount()
        {
            return discount;
        }
        public void setDiscount(IDiscount discount)
        {
            Console.WriteLine("Discount instance has been set to "+discount);
            this.discount = discount;
        }
        public void reset()
        {
            Console.WriteLine("The KFCStore instance has been resetted");
            store = new KFCStore();
        }
    }
    abstract class IItem
    {
        public string name;
        protected double price;
        protected int quantity;
        public int getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public double getCost()
        {
            return price * quantity;
        }
        public void toString()
        {
            Console.WriteLine("Object[name= " + name + ", price= " + price + ", quantity= " + quantity+"]");
        }
    }

    class ChickenWing : IItem
    {
        public ChickenWing() { }
        public ChickenWing(int amount)
        {
            base.name = "Chicken Wing";
            base.price = 1.99;
            base.quantity = amount;
            toString();
        }
    }
    class ChickenDrum : IItem
    {
        public ChickenDrum() { }
        public ChickenDrum(int amount)
        {
            base.name = "Chicken Drum";
            base.price = 2.50;
            base.quantity = amount;
            toString();
        }
    }
    class ChickenNugget : IItem
    {
        public ChickenNugget() { }
        public ChickenNugget(int amount)
        {
            base.name = "Chicken Nugget";
            base.price = 0.50;
            base.quantity = amount;
            toString();
        }
    }
    class Soda : IItem
    {
        public Soda() { }
        public Soda(int amount)
        {
            base.name = "Soda";
            base.price = 0.99;
            base.quantity = amount;
            toString();
        }
    }
    class Coke : IItem
    {
        public Coke() { }
        public Coke(int amount)
        {
            base.name = "Coke";
            base.price = 0.99;
            base.quantity = amount;
            toString();

        }
    }
    class Pepsi : IItem
    {
        public Pepsi() { }
        public Pepsi(int amount)
        {
            base.name = "Pepsi";
            base.price = 0.99;
            base.quantity = amount;
            toString();
        }
    }
}
