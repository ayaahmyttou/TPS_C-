using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Fichier
    {
        private String _nom;
        private String _extension;
        private float _taille;
        public String nom { 
            get { return _nom; }
            set { _nom = value; } 
        }
        public String extension {
            get { return _extension; }
            set {  _extension = value; }
        }    
        public float taille { 
            get { return _taille; }
            set { _taille = value; }
        }
        //constructeur
        public Fichier (String nom, String extension, float taille)
        {
            this._nom = nom;
            this._extension = extension; 
            this._taille = taille;
        }


    }
}
