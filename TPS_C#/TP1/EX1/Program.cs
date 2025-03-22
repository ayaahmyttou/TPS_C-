using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_C_.TP1.Classes; // Importer le namespace des classes Fichier et Repertoire


namespace TPS_C_.TP1
{
    internal class Program
    {
        static Main()
        {
            //créer Répertoire
            Repertoire rep = new Repertoire("Favoris");

            //Ajouter des fichiers
            rep.Ajouter(new Fichier("rapport", "pdf", 512.3f));
            rep.Ajouter(new Fichier("photo", "jpg", 2048.5f));
            rep.Ajouter(new Fichier("code", "cs", 45.7f));

            //afficher les fichiers
            rep.afficher();

            //rechercher un fichier
            // Rechercher un fichier
            rep.Rechercher("photo"); // Ce fichier existe
            rep.Rechercher("audio"); // Ce fichier n'existe pas

            //modifier la taille d'un fichier
            rep.ModifierTaille("code", 50.0f);
            rep.ModifierTaille("document", 30.0f); // Fichier non existant

            // Supprimer un fichier
            rep.Supprimer("photo");
            rep.Supprimer("video"); // Fichier non existant

            // Afficher après suppression
            Console.WriteLine("\nAprès suppression :");
            rep.Afficher();
        }
    }
}