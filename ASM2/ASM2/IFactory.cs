using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    interface IFactory
    {
        IItem makeItem(string choice, int quantity, IFactory factory);
    }

    class FoodFactory : IFactory
    {
        IItem item;
        public IItem makeItem(string choice, int quantity, IFactory factory)
        {

            switch (choice)
            {
                case "Chicken Wing":
                    item = new ChickenWing(quantity);
                    break;
                case "Chicken Drum":
                    item = new ChickenDrum(quantity);
                    break;
                case "Chicken Nugget":
                    item = new ChickenNugget(quantity);
                    break;
                default:
                    Console.WriteLine("Changing factory to DrinkFactory");
                    factory = new DrinkFactory();
                    item = factory.makeItem(choice, quantity, factory);
                    break;
            }
            return item;
        }
    }
    class DrinkFactory : IFactory
    {
        IItem item;
        public IItem makeItem(string choice, int quantity, IFactory factory)
        {
            switch (choice)
            {
                case "Soda":
                    item = new Soda(quantity);
                    break;
                case "Coke":
                    item = new Coke(quantity);
                    break;
                case "Pepsi":
                    item = new Pepsi(quantity);
                    break;
            }
            return item;
        }
    }
}
