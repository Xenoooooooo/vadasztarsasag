using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit nyul = new Rabbit();
            Squirrel mokus = new Squirrel();
            PolarBear balazs = new PolarBear();
            Animal[] allatok = { nyul, mokus, balazs };
            foreach (Animal allat in allatok)
            {
                Console.WriteLine(allat.getPrice());
            }
        }
    }
}
