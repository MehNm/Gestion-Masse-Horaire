using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Masse_Horaire
{
    class Module
    {
        #region Attributs
        private int numeroModule;
        private string descriptionModule;
        private int masseHoraire;
        #endregion
        #region Compteur 
        public static int compteur = 0; 
        #endregion
        #region les accesseurs
        public static int Compteur
        {
            get { return compteur; }
            set { compteur = value; }
        }
        public int NumeroModule
        {
            get { return this.numeroModule; }
            set { this.numeroModule = value; }
        }
        public string DescriptionModule
        {
            get { return this.descriptionModule; }
            set { this.descriptionModule = value; }
        }
        public int Massehoraire
        {
            get { return this.Massehoraire; }
            set { this.masseHoraire = value; }
        }
        #endregion
        #region méthode equals()
        public override bool Equals(object obj)
        {
            Module module = (Module)obj;
            if (module != null)
            {
                return this.numeroModule == module.numeroModule;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Constructeur 
        public Module(string descriptionModule, int masseHoraire)
        {
            compteur++;
            this.numeroModule = compteur;
            this.descriptionModule = descriptionModule;
            this.masseHoraire = masseHoraire;

        }
        #endregion
        #region MethodetoString()
        public override string ToString()
        {
            string str = string.Empty;
            str += "Numero Module: " + this.numeroModule + "\n";
            str += "Description Module: " + this.descriptionModule + "\n";
            str += "Masse Horaire: " + this.masseHoraire + "\n";
            return str;
        } 
        #endregion
    }
}
