-using System;
using System.Collections.Generic;
using System.Text;

namespace Batman
{
    class Batman
    {
        private List<BatGadgetCape> listeBadGadgetVehicule;

        public Batman()
        {
            Console.WriteLine("Constructeur : Batman");
            listeBadGadgetVehicule= new List<BatGadgetCape>();
        }

        public void SetBatGadget(BatGadgetCape batGadgetCape)
        {
            listeBadGadgetVehicule.Add(batGadgetCape);
        }

    }
}
