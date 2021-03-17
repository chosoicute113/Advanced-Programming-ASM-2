using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    interface IAdaptor
    {
        void inputOrder(List<Product> list);
    }

    class DriveThruAdaptor: IAdaptor
    {
        public KFCStore store;

        public DriveThruAdaptor(KFCStore store)
        {
            this.store = store;
        }

        public void inputOrder(List<Product> list)
        {
            foreach(Product item in list)
            {
                switch (item.item)
                {
                    case 1:
                        store.addItem("Chicken Wing",item.quantity);
                        break;
                    case 2:
                        store.addItem("Chicken Drum", item.quantity);
                        break;
                    case 3:
                        store.addItem("Chicken Nugget", item.quantity);
                        break;
                    case 4:
                        store.addItem("Soda", item.quantity);
                        break;
                    case 5:
                        store.addItem("Coke", item.quantity);
                        break;
                    case 6:
                        store.addItem("Pepsi", item.quantity);
                        break;
                }
            }
            
        }
    }
}
