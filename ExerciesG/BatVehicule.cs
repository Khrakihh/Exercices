using System;
using System.Collections.Generic;

namespace Batman
{
    public class BatVehicule
    {
        private List<BatGadgetVehicule> listeBadGadgetVehicule;
        private string description;

        public BatVehicule(string description)
        {
            listeBadGadgetVehicule= new List<BatGadgetVehicule>();
            this.description = description;
            Console.WriteLine("Constructeur : BatVéhicule");
        }

        public void SetBatGadget(BatGadgetVehicule batGadgetVehicule)
        {
            listeBadGadgetVehicule.Add(batGadgetVehicule);
        }

        public string GetDescription()
        {
            return description;
        }
    }
}