using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    internal class Squirrel : Animal
    {
        const int basePrice = 100000;
        protected double ar;
        public double Ar
        {
            get { return ar; }
            set
            {
                double squirrelFactor = 1.2;
                ar = basePrice * squirrelFactor;
            }
        }
        public override int getPrice()
        {
            Ar = ar;
            return Convert.ToInt32(ar);
        }
    }
}
