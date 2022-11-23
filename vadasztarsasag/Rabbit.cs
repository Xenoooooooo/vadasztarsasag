using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    internal class Rabbit : Animal
    {
        const int basePrice = 100000;
        protected double ar;
        public double Ar
        {
            get { return ar; }
            set
            {
                double rabbitFactor = 0.3;
                ar = basePrice * rabbitFactor;
            }
        }
        public override int getPrice()
        {
            Ar = ar;
            return Convert.ToInt32(ar);
        }
    }
}
