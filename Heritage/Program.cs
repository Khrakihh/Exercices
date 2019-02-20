using System;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Faction factionCapitaineAmerica = new Faction("Capitaine America");
            factionCapitaineAmerica.AjouterMembre(new CapitaineAmerica());
            factionCapitaineAmerica.AjouterMembre(new BlackWidow());
            factionCapitaineAmerica.AjouterMembre(new AntMan());
            factionCapitaineAmerica.AjouterMembre(new SoldatHiver());

            Console.WriteLine(factionCapitaineAmerica.GetInfoMembres());

            Faction factionIronMan = new Faction("Iron Man");
            factionIronMan.AjouterMembre(new IronMan());
            factionIronMan.AjouterMembre(new SpiderMan());
            factionIronMan.AjouterMembre(new WarMachine());
            factionIronMan.AjouterMembre(new PanthereNoire());

            Console.WriteLine(factionIronMan.GetInfoMembres());

            factionCapitaineAmerica.SupprimerMembre("Black Widow");
            factionCapitaineAmerica.SupprimerMembre("AntMan");
            factionIronMan.SupprimerMembre("War Machine");

            Console.WriteLine(factionCapitaineAmerica.GetInfoMembres());
            Console.WriteLine(factionIronMan.GetInfoMembres());

            Console.ReadKey();

        }
    }
}
