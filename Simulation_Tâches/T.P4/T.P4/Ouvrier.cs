using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P4
{
    class Ouvrier : Personne
    {

        /// <summary>
        /// Création d'une personne de type Ouvrier
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Ouvrier(string nom, string prenom) : base(nom, prenom)
        {

        }

        /// <summary>
        /// Détermine la tâche 1 dans une TextBox
        /// </summary>
        /// <param name="textBox"></param>
        public override void tache1(TextBox textBox)
        {
            textBox.Text += "Ouvrier : Assembler " + this.nom + " " + this.prenom + "\r\n";
        }

        /// <summary>
        /// Détermine la tâche 2 dans une TextBox
        /// </summary>
        /// <param name="textBox"></param>
        public override void tache2(TextBox textBox)
        {
            textBox.Text += "Ouvrier : Désassembler " + this.nom + " " + this.prenom + "\r\n";
        }

        /// <summary>
        /// Définit le type de la personne créée à Ouvrier
        /// </summary>
        /// <returns></returns>
        public override string getType()
        {
            return "Ouvrier";
        }
    }
}
