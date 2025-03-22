using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Programme
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu principal :");
            Console.WriteLine("==========================");
            Console.WriteLine("1- ajouter un nouveau compte");
            Console.WriteLine("2- rechercher un compte");
            Console.WriteLine("3- supprimer un compte");
            Console.WriteLine("4- operation sur un compte");
            Console.WriteLine("5- afficher tous les comptes");
            Console.WriteLine("6- quitter le programme");
            Console.WriteLine("==========================");
            Console.WriteLine("Entrez votre choix : ");
            int choix = int.Parse(Console.ReadLine());
            Gestion gestion = new Gestion();


            switch (choix)
            {
                case 1:
                    Console.WriteLine("Ajouter un nouveau compte")

                    Console.WriteLine("Entrez le numero du compte : ");
                    Console.WriteLine("Entrez le nom du client : ");
                    Console.WriteLine("Entrez son prenom: ");
                    gestion.creer_compte(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                    Console.WriteLine("Creation de compte effectuee avec succes");

                    break;
                case 2:
                    Console.WriteLine("Rechercher un compte");
                    break;
                case 3:
                    Console.WriteLine("Supprimer un compte");
                    break;
                case 4:
                    Console.WriteLine("Operation sur un compte");
                    break;
                case 5:
                    Console.WriteLine("Afficher tous les comptes");
                    break;
                case 6:
                    Console.WriteLine("Quitter le programme");
                    break;
                default:
                    Console.WriteLine("Choix invalide");
                    break;
            }

        }


    }
}
