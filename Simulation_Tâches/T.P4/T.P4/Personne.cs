using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P4
{

    public abstract class Personne
    {
        // Protected pour en avoir l'accès dans les classes filles
        protected string nom;
        protected string prenom;

        /// <summary>
        /// Création d'une personne
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        /// <summary>
        /// Méthode pour la tâche 1 selon la classe
        /// </summary>
        public abstract void tache1(TextBox textBox);

        /// <summary>
        /// Méthode pour la tâche 2 selon la classe
        /// </summary>
        public abstract void tache2(TextBox textBox);

        /// <summary>
        /// Permet de récupérer le type de l'instance créée
        /// </summary>
        /// <returns></returns>
        public abstract string getType();

        /// <summary>
        /// Récupère le type ainsi que le nom pour l'afficher dans une comboBox
        /// </summary>
        public string identite
        {
            get
            {
                return this.getType() + " --> " + this.nom;
            }
        }
        /// <summary>
        /// Récupère le nom pour l'utiliser dans le formulaire
        /// </summary>
        public string getNom
        {
            get
            {
                return this.nom;
            }
        }
    }
}
