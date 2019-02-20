using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_5
{
    class SpiderMan : SuperHero
    {
        public SpiderMan() : base("SpiderMan", "(toile)")
        {
            Console.WriteLine("Constructeur : SpiderMan");
        }
    }
}
