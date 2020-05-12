using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Gestion_Masse_Horaire
{
    class Personne
    {
        #region Attributs
        private string nom;
        private ArrayList prenoms;
        private DateTime dateNaissance;
        #endregion
        #region les accesseurs
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public ArrayList Prenoms
        {
            get { return this.prenoms; }
            set { this.prenoms = value; }
        }
        public DateTime DateNaissance
        {
            get { return this.dateNaissance; }
            set { this.dateNaissance = value; }
        }
        #endregion
        #region Constructeur
       
        public Personne(string noms,ArrayList prenom, DateTime dn) 
        {
            this.nom = noms;
            this.prenoms=prenom;
            this.dateNaissance = dn;

        }
        #endregion
        #region méthodeequals()
        public override bool Equals(object obj)
        {
            Personne personne = (Personne)obj;
            if (personne != null)
            {
                return this.nom == personne.nom && this.prenoms == personne.prenoms;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region méthodetoString()
        public override string ToString()
        {
            string str = string.Empty;
            string prenom1 = "";
           foreach(var prenom in prenoms)
            {
                prenom1 += prenom +" ";
            }
            str += "Prenom: " + prenom1 + "\n";
            str += "Nom: " + this.nom + "\n";
         
            str += "date Naissance : " + this.dateNaissance + "\n";
            return str;
        }
        #endregion
       

    }
}
