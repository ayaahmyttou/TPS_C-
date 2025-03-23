using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX2
{
    internal class Document
    {
        private string _titre;
        public string titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        public Document(string titre)
        {
            _titre = titre;
        }
        //renvoyer une description
        public virtual void description()
        {
            Console.WriteLine("Titre: " + titre);
        }
    }
}
