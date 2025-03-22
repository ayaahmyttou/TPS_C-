using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_C_.TP1
{
    internal class Gestion
    {
        List<Compte> _liste_comptes ;
        List<Client> _liste_clients;

        List<Compte> Liste_comptes
        {
            get { return _liste_comptes; }
            set { _liste_comptes = value; }
        }
        List<Client> Liste_clients
        {
            get { return _liste_clients; }
            set { _liste_clients = value; }
        }
        public Gestion()
        {
            _liste_comptes = new List<Compte>();
            _liste_clients = new List<Client>();
        }
        //1- Créer un compte
        public void creer_compte(String nom, String prenom, int num_cmpt)
        {
            //Créer un client
            Client client = new Client(nom, prenom);
            //Créer un compte
            Compte compte = new Compte(num_cmpt, 0, client);
            //Ajouter le compte à la liste des comptes
            _liste_comptes.Add(compte);
            //Ajouter le client à la liste des clients
            _liste_clients.Add(client);
        }

        //2- Rechercher un compte 
        public void rechercher_compte(int num_cmpt)
        {
            foreach Compte compte in _liste_comptes{
                if ( compte.num == num_cmpt)
                {
                 Console.WriteLine($"{compte.num},{compte.titulaire}, {compte.solde}")   
                }
            }
        }
        //3- Créditer d'un compte
        public void crediter (int num_cmp, float montant)
        {
            foreach Compte compte in _liste_comptes{
                if (compte.num == num_cmp)
                    compte.solde += montant;
            }
        }
        //4- débiter 
        public void debiter (int num_cmp, float montant)
        {
            foreach Compte compte in _liste_comptes{
                if (compte.num == num_cmp & compte.solde>montant)
                {
                    compte.solde -= montant;
                }
            }
        }
        //5- Historique
        public void historique (int num_cmp)
        {

        }
        //6- Transférer l'argent
        public void transferer(int num_cmp_exp, int num_cmp_rec, float montant)
        {
            foreach Compte compte = _liste_comptes{
                if (compte.num == num_cmp_exp)
                {
                    compte.crediter(num_cmp_exp, montant);
                }
                else
                {
                    compte.debiter(num_cmp_rec, montant);
                }
            }
        }
        //7-Afficher tous les comptes
        public void afficherTous()
        {
            foreach Compte compte in _liste_comptes{
                compte.Afficher();
            }
        }
        //8- Supprimer un compte
        public void supprimer(int num_cmp)
        {
            foreach Compte compte in _liste_comptes{
                if (compte.num == num_cmp)
                {
                    _liste_comptes.Remove(compte);
                }
            }
        }

    }
}
