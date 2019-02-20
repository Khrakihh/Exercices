using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_5
{
    class AntMan : SuperHero
    {
        public AntMan() : base("AntMan", "(Changement de taille)")
        {
            Console.WriteLine("Constructeur : AntMan ");
        }
    }
}
