using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_5
{
    class IronMan : SuperHero
    {
        public IronMan() : base("Iron Man", "(Milliardaire)")
        {
           
            Console.WriteLine("Constructeur : IronMan");
        }
    }
}
