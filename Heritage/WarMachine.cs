using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_5
{
    class WarMachine : SuperHero
    {
     
        public WarMachine() : base("War Machine", "(Voler)")
        {
            Console.WriteLine("Constructeur : War Machine");
        }
    }
}
