using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX2
{
    internal class Livre : Document
    {
        private string _auteur;
        private int _nbPages;
        public string auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
        public int nbPages
        {
            get { return _nbPages; }
            set { _nbPages = value; }
        }
        public Livre(string titre, string auteur, int nbPages) : base(titre)
        {
            _auteur = auteur;
            _nbPages = nbPages;
        }
        //description
        public override void description() {
            base.description();
            Console.WriteLine("Auteur: " + auteur);
            Console.WriteLine("Nombre de pages: " + nbPages);
        }

    }
}
