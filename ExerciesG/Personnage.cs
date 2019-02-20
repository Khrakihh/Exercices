using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesG
{
    class Personnage
    {
        private string nom;
        private Arme arme;
        private string classe;
        private Bouclier bouclier;
        private Armure armure;
        private Equipement equipement0;
        private Heaume heaume;
        private Equipement equipement1;
        private Equipement equipement2;
        private int pv;
        private Random random = new Random();

        public Personnage(string nom, string classe)
        {
            this.nom = nom;
            this.classe = classe;
            pv = random.Next(6, 11);
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetClasse()
        {
            return classe;
        }

        public int GetPv()
        {
            return pv;
        }

        public string GetArme()
        {
            if (arme != null)
                return "TYPE:" + arme.GetType() + "/FORCE : " + arme.GetForce();
            else
                return "";
        }

        public string GetArmure()
        {
            if (armure != null)
                return ("TYPE:" + armure.GetType() + "/PROTECTION : " + armure.GetProtection());
            else
                return "";
        }

        public string GetBouclier()
        {
            if (bouclier != null)
                return ("TYPE:" + bouclier.GetType() + "/PROTECTION : " + bouclier.GetProtection());
            else
                return "";
        }

        public string GetHeaume()
        {
            if (heaume != null)
                return ("TYPE:" + heaume.GetType() + "/PROTECTION : " + heaume.GetProtection());
            else
                return "";
        }

        public string GetEquipement(int ind)
        {
            string equip="";

            switch (ind)
            {
                case 0:
                    if (equipement0 != null)
                        equip = "TYPE: " + equipement0.GetType() + " / DESCRIPTION : " + equipement0.GetProtection();
                    else
                        equip = "";
                    break;

                case 1:
                    if (equipement1 != null)
                        equip = "TYPE: " + equipement1.GetType() + " / DESCRIPTION: " + equipement1.GetProtection();
                    else
                        equip = "";
                    break;

                case 2:
                    if (equipement2 != null)
                        equip = "TYPE: " + equipement2.GetType() + " / DESCRIPTION : " + equipement2.GetProtection();
                    else
                        equip = "";
                    break;
            }
            return equip;
        }

        public void SetArme(Arme _arme)
        {
            arme = _arme;
        }

        public void SetHaume(Heaume _heaume)
        {
            heaume = _heaume;
        }

        public void SetArmure(Armure _armure)
        {
            armure = _armure;
        }

        public void SetBouclier(Bouclier _bouclier)
        {
            bouclier = _bouclier;
        }

        public void SetEquipement1(Equipement _equipement)
        {
            equipement1 = _equipement;
        }

        public void SetEquipement0(Equipement _equipement)
        {
            equipement0 = _equipement;
        }

        public void SetEquipement2(Equipement _equipement)
        {
            equipement2 = _equipement;
        }

        public int GetTotalProtection()
        {
            int total = 0;

            if (armure != null)
                total += armure.GetProtection();
            if (heaume != null)
                total += heaume.GetProtection();
            if (bouclier != null)
                total += bouclier.GetProtection();

            return total;
        }
    }
}
