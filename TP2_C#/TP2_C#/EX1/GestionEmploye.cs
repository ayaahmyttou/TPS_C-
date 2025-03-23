using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX1
{
    internal class GestionEmploye
    {
        private List<Employe> _employes_list;
        List<Employe> employes_list
        {
            get { return _employes_list; }
            set { _employes_list = value; }
        }

        //constructeur
        public GestionEmploye()
        {
            _employes_list = new List<Employe>();
        }
        //1-Ajouter un employe
        public void ajouterEmploye(Employe emp)
        {
            _employes_list.Add(emp);
        }


        //2- supprimer un employé
        public void supprimerEmploye(Employe emp)
        {
            foreach (Employe employe in _employes_list)
            {
                if (employe == emp)
                {
                    _employes_list.Remove(emp);
                    break;
                }
            }
        }

        //3- calculer salaire total de l'entreprise
        public float salaireTotal()
        {
            float total = 0;
            foreach (Employe employe in _employes_list) {
                total += employe.salaire;
            }
            return total;

        }

        //4- calculer salaire moyen de chaque employé
        public float CalculerSalaireMoyen()
        {
            float total = 0;
            foreach (Employe employe in _employes_list)
            {
                total += employe.salaire;
            }
            return total / _employes_list.Count;
        }
    }
}
