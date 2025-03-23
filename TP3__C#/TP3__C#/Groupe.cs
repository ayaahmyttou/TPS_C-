using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3__C_
{
    internal class Groupe
    {
        string nom_groupe;
        List<Etudiant> etudiants;

        public string Nom_groupe
        {
            get { return this.nom_groupe; }
            set { nom_groupe = value; }
        }

        public List<Etudiant> Etudiants
        {
            get { return this.etudiants; }
            set { etudiants = value; }
        }

        public Groupe(string nom_groupe, List<Etudiant> etudiants)
        {
            this.nom_groupe = nom_groupe;
            this.etudiants = etudiants;
        }
        public void AjouterEtd(Etudiant etd)
        {
            etudiants.Add(etd);
        }
        public void AfficherGrp()
        {
            foreach (Etudiant etd in etudiants)
            {
                etd.Afficher();
            }
        }
    }
}
