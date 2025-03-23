using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3__C_
{
    internal class Etudiant: Personne
    {
        protected string niveau;
        protected double moyenne;

        public Etudiant(string niveau, double moyenne)
        {
            this.niveau = niveau;
            this.moyenne = moyenne;
        }
        public string Niveau
        {
            get { return this.niveau; }
            set { niveau = value; }
        }
        public double Moyenne
        {
            get { return this.moyenne; }
            set { moyenne = value; }
        }
        //méthode pour afficher les informations de l'étudiant
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Niveau: " + niveau);
            Console.WriteLine("Moyenne: " + moyenne);
        }










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
        public void AfficherEtd()
        {

        }
    }
}
