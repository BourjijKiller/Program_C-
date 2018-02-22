using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P4
{
    delegate void gestionTaches(TextBox textBox);
    class PersonneFactory
    {
        public gestionTaches taches = null;
        private BindingList<Personne> personnes;

        /// <summary>
        /// Créé une liste de personnes
        /// </summary>
        public PersonneFactory()
        {
            personnes = new BindingList<Personne>();
        }

        /// <summary>
        /// Ajouter une personne dans la liste de personnes
        /// </summary>
        /// <param name="personne"></param>
        public void ajouterPersonnes(Personne personne)
        {
            this.personnes.Add(personne);
        }

        /// <summary>
        /// Récupère la taille de la liste de personnes
        /// </summary>
        /// <returns></returns>
        public int tailleListePersonnes()
        {
            return this.personnes.Count;
        }

        /// <summary>
        /// Méthode retournant la liste de personnes
        /// </summary>
        /// <returns></returns>
        public BindingList<Personne> contenuPersonne()
        {
            return this.personnes;
        }

        /// <summary>
        /// Méthode permettant d'afficher le nom de la personne qui vient d'être créé dans une messageBox, en fonction de l'index de la liste passé en paramètre
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string recupNom(int index)
        {
            return this.personnes[index].getNom;
        }

        /// <summary>
        /// Méthode permettant d'afficher le type de la personne qui vient d'être créé dans une messageBox, en fonction de l'index de la liste passé en paramètre
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string recupType(int index)
        {
            return this.personnes[index].getType();
        }
    }
}
