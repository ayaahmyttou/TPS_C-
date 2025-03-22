using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Consom_cafe
    {
        private int no_semaine;
        private int nbr_tasses;
        private List<Programmeur> programmeurs;
        public int no_semaine
        {
            get { return no_semaine; }
            set { no_semaine = value; }
        }
        public int nbr_tasses
        {
            get { return nbr_tasses; }
            set { nbr_tasses = value; }
        }
        public List<Programmeur> programmeurs
        {
            get { return programmeurs; }
            set { programmeurs = value; }
        }
        //constructeur
        public Consom_cafe(int no_semaine, int nb_tasses, List<Programmeur> programmeurs)
        {
            this.no_semaine = no_semaine;
            this.nbr_tasses = nb_tasses;
            this.programmeurs = programmeurs;
        }

        //méthode ajouer consommation de café pour un programmeur
        public void ajouter_consom_cafe(string nom, int nb_tasses)
        {
            foreach (Programmeur p in programmeurs)
            {
                if (p.nom == nom)
                {
                    p.nb_tasses += nb_tasses;
                }
            }
        }


    }
}
