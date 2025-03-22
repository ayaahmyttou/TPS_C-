using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Programmeur
    {
        private String _nom;
        private String _prenom;
        private int _bureau;
        public String nom { 
            get { return _nom; }
            set { _nom = value; } 
        }
        public String prenom {
            get { return _prenom; }
            set {  _prenom = value; }
        }    
        public int bureau { 
            get { return _bureau; }
            set { _bureau = value; }
        }
        //constructeur
        public Programmeur (String nom, String prenom, int bureau)
        {
            this._nom = nom;
            this._prenom = prenom; 
            this._bureau = bureau;
        }

        //Afficher les informations du programmeur
        public void afficher()
        {
            Console.WriteLine($"Nom : {nom}, Prénom : {prenom}, Bureau : {bureau}");
        }

        //Changer bureau d'un programmeur
        public void changer_bureau(int no_bureau_nv)
        {
            bureau = no_bureau_nv;
        }


    }
}
