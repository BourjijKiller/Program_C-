using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6
{
    class TopicFactory
    {
        /// <summary>
        /// Déclaration des événements pour en informer les ComboBoxs
        /// </summary>
        public event EventHandler<Args> onAjouterTopic;
        public event EventHandler<Args> onSupprimerTopic;
        
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
            Args args = new Args(topic);
            onAjouterTopic(this, args);
        }

        /// <summary>
        /// Permet de supprimer un topic de la liste. Déclenche l'eventHandler de suppression de topics
        /// </summary>
        /// <param name="topic"></param>
        public void supprimerUnTopic(Topic topic)
        {
            Args args = new Args(topic);
            onSupprimerTopic(this, args);
            this.topicFactory.Remove(topic);
        }
    }
}
