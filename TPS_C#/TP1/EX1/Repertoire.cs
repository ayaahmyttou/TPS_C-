using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Repertoire
    {
        private String _nom;
        private  int _nbr_fichiers;
        private Fichier[] _fichiers;
        //ou bien si on a pas précisé nbre de fichier
        //public List<Fichier> fichiers;

        //déclarer les propriétés
        public String nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int nbr_fichiers
        {
            get { return _nbr_fichiers; }
            set { nbr_fichiers = value; }
        }
        public Fichier[] fichiers
        {
            get { return fichiers; }
            set { fichiers = value; }
        }

        //constructeur
        public Repertoire (String nom)
        {
            _nom = nom;
            //On initialise un tableau à 30 cases puisque notre répertoire ne peut contenir que 30 fichiers
            _fichiers = new Fichier[30];
            nbr_fichiers++; //Au début il n'y a aucun fichier
        }
        
        //Déclaration des méthodes 

        //méthode 1: Afficher le nom du répertoire et la liste de ces fichiers
        public void afficher()
        {
            Console.WriteLine($"Répertoire : {nom}");
            for (int i = 0; i<_nbr_fichiers; i++)
            {
                Console.WriteLine($"Fichiers : {_fichiers[i].nom}, {_fichiers[i].taille}, {_fichiers[i].extension}");
            }
        }
        //méthode 2: Rechercher un fichier en utilisant son nom
        public int rechercher(string nom_fichier)
        {
            for (int i = 0; i <_nbr_fichiers; i++)
            {
                if (fichiers[i].nom == nom_fichier)
                {
                    return i;
                }
                return -1;
            }
        }

        //méthode 3: Insérer un fichier à la fin du tableau
        public void ajouter(Fichier fich)
        {
            if (nbr_fichiers < 30)
            {
                fichiers[_nbr_fichiers] = fich;
                _nbr_fichiers++;
                Console.WriteLine($"fichier ajouté avec succès");
            }
            else
            {
                Console.WriteLine($"vous avez atteint la taille max du répertoire");
            }
        }

        //méthode 4: affiche les fichiers qui portent l’extension pdf
        public void afficher_pdf()
        {
            for (int i = 0; i < _nbr_fichiers; i++)
            {
                if (_fichiers[i].extension = "pdf")
                {
                    Console.WriteLine($"{fichiers[i].nom}.pdf");
                }
                else
                {
                    Console.WriteLine($"Aucun fichier pdf trouvé");

                }
            }

        }

        //méthode 5: enlève un fichier du tableau en utilisant son nom
        public void supprimer (string nom_fich)
        {
            for (int i= 0; i< _nbr_fichiers; i++)
            {
                if (fichiers[i].nom == nom_fich)
                {
                    Fichier[i] == null;
                    _nbr_fichiers--;
                }
            }
        }

        //méthode 6: Modifie le nom d’un fichier.
        public void modifier_nom (string old_nom, string new_nom)
        {
            for (int i = 0; i < _nbr_fichiers; i++)
            {
                if (fichiers[i].nom == old_nom)
                {
                    Fichier[i].nom == new_nom;
                    Console.WriteLine($"nom modifié avec succès!");
                }
            }
        }
        //méthode 7: modifier la taille d'un fichier
        public void modifier_taille(string nom_fich, float taille)
        {
            for (int i = 0; i < _nbr_fichiers; i++)
            {
                if (fichiers[i].nom == nom_fich)
                {
                    Fichier[i].taille == taille;
                    Console.WriteLine($"taille modifié avec succès!");
                }
                else
                {
                    Console.WriteLine("fichier introuvable");
                }
            }
        }

        //méthode 8: fournit la taille d’un répertoire en méga octets (MO).
        public void afficher_taille()
        {
            float taille_repertoire = 0;
            for (int i = 0; i < _nbr_fichiers; i++)
            {
                taille_repertoire += _fichiers[i].taille
            }
            //convertir en MO
            taille_repertoire = taille_repertoire /= 1024;
            Console.WriteLine($"taille de répertire en MO: {taille_repertoire}  MO"
        }
    }
}
