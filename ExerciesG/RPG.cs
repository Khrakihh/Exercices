using System;

namespace ExerciesG
{
    class RPG
    {
        private Personnage personnage;
        public void CreerPersonnage(string nom, string classe)
        {
            personnage = new Personnage(nom, classe);
        }

        public void AjouterArme(int choix)
        {
            Arme arme;

            switch (choix)
            {
                case 0:
                    personnage.SetArme(null); break;

                case 1:
                    arme = new Arme("epe", 3);
                    personnage.SetArme(arme); break;

                case 2:
                    arme = new Arme("hache", 5);
                    personnage.SetArme(arme); break;
            }
        }

        public void AjouterHaume()
        {
            Heaume haume = new Heaume("casque", 3);
            personnage.SetHaume(haume);
        }

        public void EnleverHaume()
        {
            personnage.SetHaume(null);
        }

        public void AjouterEquipement(string type, string nom, int ind)
        {
            Equipement equipement;

            switch (ind)
            {
                case 0:
                    equipement = new Equipement(type, nom);
                    personnage.SetEquipement0(equipement); break;

                case 1:
                    equipement = new Equipement(type, nom);
                    personnage.SetEquipement1(equipement); break;

                case 2:
                    equipement = new Equipement(type, nom);
                    personnage.SetEquipement2(equipement); break;
            }
        }

        public void EnleverEquipement(int ind)
        {
            switch (ind)
            {
                case 0:
                    personnage.SetEquipement0(null); break;

                case 1:
                    personnage.SetEquipement1(null); break;

                case 2:
                    personnage.SetEquipement2(null); break;
            }
        }
        public void AjouterArmure(int choix)
        {
            Armure armure;

            switch (choix)
            {
                case 0:
                    personnage.SetArmure(null); break;

                case 1:
                    armure = new Armure("cuir", 3);
                    personnage.SetArmure(armure); break;

                case 2:
                    armure = new Armure("metal", 5);
                    personnage.SetArmure(armure); break;
            }
        }

        public void AjouterBouclier(int choix)
        {
            Bouclier bouclier;

            switch (choix)
            {
                case 0:
                    personnage.SetBouclier(null); break;

                case 1:
                    bouclier = new Bouclier("petit", 3);
                    personnage.SetBouclier(bouclier); break;

                case 2:
                    bouclier = new Bouclier("grand", 5);
                    personnage.SetBouclier(bouclier); break;
            }
        }

        public int GetTotalProtection()
        {
            return personnage.GetTotalProtection();
        }

        public string getInfoPersonnage()
        {
            if (personnage != null)
            { 
                return "PERSONNAGE { \n" +
                "         NOM         : " + personnage.GetNom() + "\n" +
                "         CLASSE      : " + personnage.GetClasse() + "\n" +
                "         PV          : " + personnage.GetPv() + "\n" +
                "         ARME        : { " + personnage.GetArme() + " } \n" +
                "         ARMURE      : { " + personnage.GetArmure() + " } \n" +
                "         BOUCLIER    : { " + personnage.GetBouclier() + " } \n" +
                "         HAUME       : { " + personnage.GetHeaume() + " } \n" +
                "         EQUIPEMENT  : { {" + personnage.GetEquipement(0) + " } {" + personnage.GetEquipement(1) + " } {" + personnage.GetEquipement(2) + " } }";
            }
            else
            {
                return "aucun personnage ";
            }
        }

        
    }
}
