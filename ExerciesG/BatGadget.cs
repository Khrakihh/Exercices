using System;

namespace Batman
{
    public class BatGadget
    {
        private string nom;

        public BatGadget(string nom)
        {
            this.nom = nom;
            Console.WriteLine("Cosntructeur : badget");
        }

        public string GetNom()
        {
            return nom;
        }
    }
}