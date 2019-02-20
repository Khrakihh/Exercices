using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_5
{
    class SuperHero 
    {
        string nom;
        string superPouvoir;

        protected SuperHero(string nom, string superPouvoir)
        {
            this.nom = nom;
            this.superPouvoir = superPouvoir;
            Console.WriteLine("Constructeur : SuperHéros");
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetSuperPouvoir()
        {
            return superPouvoir;
        }
    }
}
