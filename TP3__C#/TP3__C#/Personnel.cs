using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3__C_
{
    internal abstract class Personnel: Personne
    {
        protected double salaire;
        protected string bureau;
        protected double prime;

        //propriétés
        public string Bureau
        {
            get { return this.bureau; }
            set { bureau = value; }
        }
        public double Prime
        {
            get { return this.prime; }
            set { prime = value; }
        }
        public double Salaire
        {
            get { return this.salaire; }
            set { salaire = value; }
        

        protected Personnel(double salaire, string bureau, double prime, int code, string nom, string prenom): base(code, nom, prenom)
        {
            this.salaire = salaire;
            this.bureau = bureau;
            this.prime = prime;
        }

        public double Salaire
        {
            get { return this.salaire; }
            set { salaire = value; }
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Salaire: " + salaire);
            Console.WriteLine("Bureau: " + bureau);
            Console.WriteLine("Prime: " + prime);
        }

        public abstract double calculer_salaire();




        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract double CalculerSalaire();
    }
}
