using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    internal class PolarBear : Animal
    {
        const int basePrice = 100000;
        protected double ar;
        public double Ar
        {
            get { return ar; }
            set
            {
                double PolarBearFactor = 2.4;
                ar = basePrice * PolarBearFactor;
            }
        }
        public override int getPrice()
        {
            Ar = ar;
            return Convert.ToInt32(ar);
        }
    }
}
