using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX2
{
    internal class Biblio
    {
        private List<Document> _documents;
        public List<Document> documents
        {
            get { return _documents; }
            set { _documents = value; }
        }
        public Biblio()
        {
            _documents = new List<Document>();
        }
        public void ajouterDocument(Document doc)
        {
            _documents.Add(doc);
        }
        //calculer nbre de livres
        public int nbreLivre()
        {
            int nbre = 0;
            foreach (Document doc in _documents)
            {
                if (doc is Livre)
                {
                    nbre++;
                }
            }
            return nbre;
        }
        //afficher les dictionnaires
        public void afficherDictionnaires()
        {
            foreach (Document doc in _documents)
            {
                if (doc is Dictionnaire)
                {
                    Dictionnaire d = (Dictionnaire)doc;
                    d.afficher();
                }

            }
        }
        //afficher la liste des numéros des documents avec son auteur
        public void tousLesAuteurs()
        {
            foreach (Document doc in _documents )
            {
                if (doc is Livre)
                {
                    Livre l = (Livre)doc;
                    Console.WriteLine("Titre: " + l.titre + " Auteur: " + l.auteur);
                }
                
            }
        }
        //affiche les descriptions de tous les documents
        public void afficherTousDescriptions()
        {
            foreach (Document doc in _documents)
            {
                doc.description();
            }
        }
    }

}
