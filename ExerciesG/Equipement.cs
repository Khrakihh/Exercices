using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesG
{
    class Equipement
    {
        private string nom;
        private string type;
        private int indicateur;

        public Equipement(string nom, string type)
        {
            this.nom = nom;
            this.type = type;
        }

        public string GetProtection()
        {
            return nom;
        }

        public string GetType()
        {
            return type;
        }
    }
}
