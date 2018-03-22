using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.P6.Args;
using T.P6.Objets;

namespace T.P6.Factory
{
    class PersonneFactory
    {
        /// <summary>
        ///  Déclaration des événements pour en informer les ComboBoxs
        /// </summary>
        public event EventHandler<ArgsCBB> onAjouterPersonne;
        public event EventHandler<ArgsCBB> onSupprimerPersonne;


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
            ArgsCBB args = new ArgsCBB(personne);
            onAjouterPersonne(this, args);
        }

        /// <summary>
        /// Permet de supprimer une personne de la liste. Déclenchement de l'événement de suppression 
        /// </summary>
        /// <param name="personne"></param>
        public void supprimerUnePersonne(Object personne)
        {
            ArgsCBB args = new ArgsCBB(personne);
            onSupprimerPersonne(this, args);
            this.personneFactory.Remove((Personne)personne);
        }
    }
}
