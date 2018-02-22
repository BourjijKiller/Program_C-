using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P4
{
    class Administrateur : Personne
    {
        /// <summary>
        /// Créer une personne de type administrateur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Administrateur(string nom, string prenom) : base(nom, prenom)
        {

        }

        /// <summary>
        /// Détermine la tâche 1 dans une TextBox
        /// </summary>
        /// <param name="textBox"></param>
        public override void tache1(TextBox textBox)
        {
            textBox.Text += "Administrateur : Classer " + this.nom + " " + this.prenom +  "\r\n";
        }

        /// <summary>
        /// Détermine la tâche 2 dans une TextBox
        /// </summary>
        /// <param name="textBox"></param>
        public override void tache2(TextBox textBox)
        {
            textBox.Text += "Administrateur : Contacter " + this.nom + " " + this.prenom + "\r\n";
        }

        /// <summary>
        /// Définit le type de la personne créée à Administrateur
        /// </summary>
        /// <returns></returns>
        public override string getType()
        {
            return "Administrateur";
        }
    }
}
