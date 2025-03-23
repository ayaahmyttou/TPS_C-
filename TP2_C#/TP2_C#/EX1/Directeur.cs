using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_C_.EX1
{
    internal class Directeur
    {
        private GestionEmploye _gestionEmploye;
        private static Directeur directeur;
        
        public GestionEmploye GestionEmploye {
            get => _gestionEmploye; 
            set => _gestionEmploye = value; 
        }

        public Directeur()
        {
            _gestionEmploye = new GestionEmploye();
        }
        public void setGestionEmploye(GestionEmploye GE)
        {
            _gestionEmploye = GE;
        }

        public GestionEmploye getGestionEmploye()
        {
            return _gestionEmploye;
        }

        public static Directeur CreateDirecteurSigleton()
        {
            if (directeur == null)
            {
                directeur = new Directeur();
                
            }
            else
            {

                Console.WriteLine("Directeur existe déjà");
            }
            return directeur;

        }
    }
}
