using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesG
{
    class Heaume
    {
        private string type;
        private int protection;
        private Random random = new Random();

        public Heaume(string type, int protection)
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
