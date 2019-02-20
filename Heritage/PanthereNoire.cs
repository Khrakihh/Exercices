using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_5
{
    class PanthereNoire : SuperHero
    {
        public PanthereNoire() : base("Panthere Noire", "(Roi du Wakanda)")
        {
            Console.WriteLine("Constructeur : PanthereNoire");
        }
    }
}
