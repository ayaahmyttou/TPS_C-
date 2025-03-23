using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX1
{
    internal class Employe
    {
        private string _nom;
        private float _salaire;
        private string _poste;
        private string _date_embauche;
        //Propriétés
        public string nombre { 
            get { return _nom; } 
            set { _nom = value; }
        }         
        public float salaire { 
            get { return _salaire; } 
            set { _salaire = value; } 
        }
        public string poste { 
            get { return _poste; } 
            set { _poste = value; }
        }
        public string date_embauche {
            get { return _date_embauche; }
            set { _date_embauche = value; } 
        }
        //Constructeur 
        public Employe(string nom, float salaire, string poste, string date_embauche)
        {
            _nom = nom;
            _salaire = salaire;
            _poste = poste;
            _date_embauche = date_embauche;
        }
        //

    }
}
