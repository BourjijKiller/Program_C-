using System;
using System.Collections.Generic;
using T.P6.Args;
using T.P6.Objets;

namespace T.P6.Factory
{
    class TopicFactory
    {
        /// <summary>
        /// Déclaration des événements pour en informer les ComboBoxs
        /// </summary>
        public event EventHandler<ArgsCBB> onAjouterTopic;
        public event EventHandler<ArgsCBB> onSupprimerTopic;
        
        private List<Topic> topicFactory;

        /// <summary>
        /// Création d'une liste de topics
        /// </summary>
        public TopicFactory()
        {
            this.topicFactory = new List<Topic>();
        }

        /// <summary>
        /// Permet d'ajouter un topic à une liste. Déclenche l'eventHandler d'ajout de topics
        /// </summary>
        /// <param name="nomTopic"></param>
        public void ajouterUnTopic(string nomTopic)
        {
            Topic topic = new Topic(nomTopic);
            this.topicFactory.Add(topic);
            ArgsCBB args = new ArgsCBB(topic);
            onAjouterTopic(this, args);
        }

        /// <summary>
        /// Permet de supprimer un topic de la liste. Déclenche l'eventHandler de suppression de topics
        /// </summary>
        /// <param name="topic"></param>
        public void supprimerUnTopic(Object topic)
        {
            ArgsCBB args = new ArgsCBB(topic);
            onSupprimerTopic(this, args);
            this.topicFactory.Remove((Topic)topic);
        }

        /// <summary>
        /// Désabonne une personne d'une news
        /// </summary>
        /// <param name="personne"></param>
        public void desabonnerPersonne(Personne personne)
        {
            foreach (Topic topic in this.topicFactory)
                topic.onEnvoyerNews -= personne.receiveNews;
        }
    }
}
