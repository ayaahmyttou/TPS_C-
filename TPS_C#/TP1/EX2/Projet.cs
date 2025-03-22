using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Projet
    {
        private String _code;
        private String _nom;
        private String _sujet;
        private String _duree;
        private int _nbre_programmeurs;
        //liste des programmeurs
        List<Programmeurs> _programmeurs ;

        //propriétés
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public String Duree
        {
            get { return _duree; }
            set { _duree = value; }
        }

        public int Nbre_programmeurs
        {
            get { return _nbre_programmeurs; }
            set { _nbre_programmeurs = value; }
        }

        public String Sujet
        {
            get { return _sujet; }
            set { _sujet = value; }
        }

        //constructeur
        public Projet(String code, String nom, String duree, int nbre_programmeurs, string sujet)
        {
            _code = code;
            _nom = nom;
            _duree = duree;
            _nbre_programmeurs = nbre_programmeurs;
            _sujet = sujet;
        }

        //méthode 1: Ajouter un programmeur
        public void AjouterProgrammeur(Programmeurs programmeur)
        {
            _programmeurs.Add(programmeur);
        }

        //méthode 2: Rechercher un programmeur
        public int RechercherProgrammeur(string nom)
        {
            for int i = 0; i < _programmeurs.Count; i++)
            {
                if (_programmeurs[i].Nom == nom)
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("programmeur introuvable :(");
                }
            }
        }
        //méthode 3: Afficher programmeur
        public void AfficherProgrammeur(string nom_prog)
        {
            foreach (Programmeur programmeur in _programmeurs)
            {
                if (programmeur.Nom == nom_prog)
                {
                    programmeur.afficher();
                }
                else
                {
                    Console.WriteLine("programmeur introuvable :(");
                }
            }
        }
        //méthode 4: Aficher tous les programmeurs programmeur
        public void AfficherTousProgrammeur()
        {
            foreach (Programmeur programmeur in _programmeurs)
            {
                programmeur.afficher();
            }
        }

        //méthode 5: Supprimer un programmeur
        public void SupprimerProgrammeur(string nom_prog)
        {
            foreach (Programmeur programmeur in _programmeurs)
            {
                if (programmeur.Nom == nom_prog)
                {
                    _programmeurs.Remove(programmeur);
                }
                else
                {
                    Console.WriteLine("programmeur introuvable :(");
                }
            }
        }

        //méthode 6: Afficher consommation de café pour tous les programmeurs
        public voif AfficherConsomCafe()
        {
            int consom_total = 0;
            foreach(Programmeur programmeur in Nbre_programmeurs)
            {
                consom_total += programmeur.Nbr_tasses;
            }
            Console.WriteLine($"Consommation totale de café : {consom_total}");
        }









    }
}
