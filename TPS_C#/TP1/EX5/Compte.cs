using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Compte
    {
        private String _num;
        private float _solde;
        private String _titulaire;
        public String num
        {
            get { return _num; }
            set { _num = value; }
        }
        public float solde
        {
            get { return _solde; }
            set { _solde = value; }
        }
        public String titulaire
        {
            get { return _titulaire; }
            set { _titulaire = value; }
        }
        //constructeur
        public Compte(String num, float solde = 0, String titulaire)
        {
            this._num = num;
            this._solde = solde;
            this._titulaire = titulaire;
        }
        //Méthode pour afficher les détails d'un compte
        public void afficher()
        {
            Console.WriteLine($"{_num}, {_solde}, {_titulaire}");
        }
    }
}
