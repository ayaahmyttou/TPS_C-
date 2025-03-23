using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX2
{
    internal class Dictionnaire : Document
    {
        private string _langue;
        private int _nbDefinitions;
        public string langue
        {
            get { return _langue; }
            set { _langue = value; }
        }
        public int nbDefinitions
        {
            get { return _nbDefinitions; }
            set { _nbDefinitions = value; }
        }
        public Dictionnaire (string titre, string langue, int nbDefinitions): base(titre)
        {
            _langue = langue;
            _nbDefinitions = nbDefinitions;
        }
        public void afficher()
        {
            Console.WriteLine("Titre: " + titre);
            Console.WriteLine("Langue: " + langue);
            Console.WriteLine("Nombre de definitions: " + nbDefinitions);
        }
        //description
        public override void description()
        {
            base.description();
            Console.WriteLine("Langue: " + langue);
            Console.WriteLine("Nombre de définitions: " + nbDefinitions);
        }
    }
}
