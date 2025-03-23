using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3__C_
{
    internal class Personne
    {
        protected int code;
        protected string nom;
        protected string prenom;

        //méthode pour afficher les informations de la personne
        public virtual void Afficher()
        {
            Console.WriteLine("Code: " + code);
            Console.WriteLine("Nom: " + nom);
            Console.WriteLine("Prenom: " + prenom);
        }
    }
}
