using System;

namespace Batman
{
    public class BatGadgetVehicule : BatGadget
    {
        public BatGadgetVehicule(string nom) : base(nom)
        {
            Console.WriteLine("constructeur : batgadegetVéhicule");
        }
    }
}