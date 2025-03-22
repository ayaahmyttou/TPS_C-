using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Client
    {
        private String _nom;
        private String _prenom;
        
        public String nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public String prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        
        //constructeur
        public Programmeur(String nom, String prenom)
        {
            this._nom = nom;
            this._prenom = prenom
        }

        


    }
}
