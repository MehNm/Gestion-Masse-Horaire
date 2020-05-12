using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Gestion_Masse_Horaire
{
    class Formateur :Personne
    {
        #region Attribut
        private string matricule;
        private ArrayList modules;
        #endregion
        #region Proprite
        public string Matricule
        {
            get { return this.matricule; }
            set { this.matricule = value; }
        }
        public ArrayList Modules
        {
            get { return this.modules; }
            set { this.modules = value; }
        }
        #endregion
        #region Constructor
        public Formateur(string matricule, ArrayList modules, string nom, ArrayList prenom, DateTime dn) : base(nom, prenom, dn)
        {
            this.matricule = matricule;
            this.modules = modules;
        }
        #endregion
        #region method Equals
        public override bool Equals(object obj)
        {
            Formateur formateur = (Formateur)obj;
            if (formateur != null)
            {
                return this.Nom == formateur.Nom && this.Prenoms == formateur.Prenoms && this.matricule == formateur.matricule;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region method Verifier Module
        public int VerifierModule(Module module)
        {
            int p = -1;
            foreach (Module item in modules)
            {
                if (item == module)
                {
                    return modules.IndexOf(item);
                }
            }
            return p;
        }
        #endregion
        #region method AjouterModule
        public void AjouterModule(Module module)
        {
            modules.Add(module);

        }
        #endregion
        #region method Supprimer Module
        public void supprimerModule(Module module)
        {

            if (VerifierModule(module) != -1)
            {
                Modules.RemoveAt(VerifierModule(module));
            }

        }
        #endregion
        #region method totalMH
        public int totalMH()
        {
            int sum = 0;
            foreach (Module item in modules)
            {
                sum += item.Massehoraire;
            }
            return sum;
        }
        #endregion
        #region méthodelisteModules() 
       /* public  ArrayList listeModules()
        {
            return modules;
        }*/

        #endregion
        #region Surcharger la dernière méthode A
       
        public ArrayList listeModules(int seuil_minimal)
        {
            ArrayList lists = new ArrayList();
            foreach(Module item in modules)
            {
                if (item.Massehoraire > seuil_minimal)
                {
                    lists.Add(item);

                }
            }
            return lists;

        }
        #endregion
        #region Surcharger la dernier method B
        public string listeModules()
        {
            string str = string.Empty;
            foreach (Module item in modules)
            {
                str += item.ToString();
            }
            return str;

        } 
        #endregion

    }

}
