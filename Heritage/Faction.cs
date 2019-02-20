using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_5
{
    class Faction
    {
        List<SuperHero> membres = new List<SuperHero>();
        string nom;

        public Faction(string nom)
        {
            this.nom = nom;
            Console.WriteLine("Création de la faction " + nom);
        }

        public void AjouterMembre(SuperHero membre)
        {       
            membres.Add(membre);   
        }

        public void SupprimerMembre(string nom)
        {
            SuperHero super = null;

            foreach(SuperHero membre in membres)
            {
                if (membre.GetNom() == nom)
                {
                    super = membre;
                }
            }

            if (super != null)
                membres.Remove(super);
        }
        public string GetInfoMembres()
        {
            string info ="";
            foreach (SuperHero membre in membres)
                info += ("\n" + membre.GetNom() + membre.GetSuperPouvoir());
            return info;
            
        }
    }
}