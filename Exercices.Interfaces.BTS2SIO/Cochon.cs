using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Interfaces.BTS2SIO
{
    public class Cochon : IAnimal
    {
        public Cochon(string name)
        {
            Name = name;
        }

        public string Name { get ; set; }

        public void Manger()
        {
            Console.WriteLine("Je mange des légumes et des cadavres de la mafia");
        }
    }
}
