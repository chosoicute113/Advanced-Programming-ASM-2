using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    interface IDiscount
    {
        double calDiscount(double a);
    }

    class NoDiscount: IDiscount
    {
        public double calDiscount(double number)
        {
            return number;
        }
    }
    class MondayDiscount : IDiscount
    {
        public double calDiscount(double number)
        {
            return number * 0.90;
        }
    }
    class MondayKidDiscount : IDiscount
    {
        public double calDiscount(double number)
        {
            return number * 0.75;
        }
    }
}
