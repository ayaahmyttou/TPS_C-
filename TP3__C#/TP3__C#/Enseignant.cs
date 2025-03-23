using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3__C_
{
    internal class Enseignant : Personnel
    {
        private float heure_sup;
        private string grade;
        private int volume_horaire;
        private Dictionary<string, List<Etudiant>> groupes;
        //List<Groupe> groupes;
        public void AffecterGroupe(Groupe grp)
        {
            groupes.Add(grp.Nom_groupe, grp.Etudiants);
            
        }
        //propriétés
        public float Heure_sup
        {
            get { return this.heure_sup; }
            set { heure_sup = value; }
        }
        public string Grade
        {
            get { return this.grade; }
            set { grade = value; }
        }
        public int Volume_horaire
        {
            get { return this.volume_horaire; }
            set { volume_horaire = value; }
        }
        public List<Groupe> Groupes
        {
            get { return this.groupes; }
            set { groupes = value; }
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Heure sup: " + heure_sup);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Volume horaire: " + volume_horaire);
            Console.WriteLine("Groupes: "+ grou);
        }



        public Enseignant(double salaire, string bureau, double prime, float heure_sup, string grade, int volume_horaire ): base(heure_sup, grade, volume_horaire)
        { 
            this.heure_sup = heure_sup;
            this.grade = grade;
            this.volume_horaire = volume_horaire;
            //etudiants = new Dictionary<string, List<Etudiant>> { };
            groupes = new List<Groupe> { };
        }
        public override double CalculerSalaire()
        {
            int taux_horaire = 0;
            switch (grade)
            {
                case "PA":
                    taux_horaire = 300; break;
                case "PH":
                    taux_horaire = 350; break;
                case "PES":
                    taux_horaire = 400; break;
            }
            return Salaire + (heure_sup * taux_horaire)+ prime;
        }
        
    }

    

}
