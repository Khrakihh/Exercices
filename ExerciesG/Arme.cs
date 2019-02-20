using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesG
{
    class Arme
    {
        private string type;
        private int degat;
        private Random random = new Random();

        public Arme(string type, int degat)
        {
            this.type = type;
            this.degat = degat;
        }

        public int GetForce()
        {
            return degat;
        }

        public string GetType()
        {
            return type;
        }
    }
}
