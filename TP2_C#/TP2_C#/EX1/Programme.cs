using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX1
{
    internal class Programme
    {
        static void Main(string[] args)
        {
            GestionEmploye GE = new GestionEmploye();
            //instanciation des employés
            Employe emp1 = new Employe("Ali", 1000, "Ingénieur", "01/01/2021");
            Employe emp2 = new Employe("Ahmed", 2000, "Ingénieur", "01/01/2021");
            //ajouter employes
            GE.ajouterEmploye(emp1);
            GE.ajouterEmploye(emp2);

            //créer une instance de Directeur
            Directeur directeur = Directeur.CreateDirecteurSigleton();


            //Afficher les infos de entreprise 
            Console.WriteLine("Salaire Total d'employés : " + directeur.GestionEmploye.salaireTotal);
            Console.WriteLine("Salaire moyen d'employés : " + directeur.GestionEmploye.CalculerSalaireMoyen);


        }
    }
}
