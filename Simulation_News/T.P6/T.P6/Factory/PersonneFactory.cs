using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6
{
    class PersonneFactory
    {
        /// <summary>
        ///  Déclaration des événements pour en informer les ComboBoxs
        /// </summary>
        public event EventHandler<Args> onAjouterPersonne;
        public event EventHandler<Args> onSupprimerPersonne;


        private List<Personne> personneFactory;

        /// <summary>
        /// Créé une liste de personnes
        /// </summary>
        public PersonneFactory()
        {
            this.personneFactory = new List<Personne>();
        }

        /// <summary>
        /// Permet d'ajouter une personne à la liste de personnes. Déclenchement de l'événement d'ajout de personnes
        /// </summary>
        /// <param name="nomPersonne"></param>
        public void ajouterUnePersonne(String nomPersonne)
        {
            Personne personne = new Personne(nomPersonne);
            this.personneFactory.Add(personne);
            Args args = new Args(personne);
            onAjouterPersonne(this, args);
        }

        /// <summary>
        /// Permet de supprimer une personne de la liste. Déclenchement de l'événement de suppression 
        /// </summary>
        /// <param name="personne"></param>
        public void supprimerUnePersonne(Object personne)
        {
            Args args = new Args(personne);
            onSupprimerPersonne(this, args);
            this.personneFactory.Remove((Personne)personne);
        }
    }
}
