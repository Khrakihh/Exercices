using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesG
{
    class Armure
    {
        private string type;
        private int protection;
        private Random random = new Random();

        public Armure(string type, int protection)
        {
            this.type = type;
            this.protection = protection;
        }

        public int GetProtection()
        {
            return protection;
        }

        public string GetType()
        {
            return type;
        }
    }
}
