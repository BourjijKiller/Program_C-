using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.P6.Args;
using T.P6.Objets;

namespace T.P6
{
    class Topic
    {
        public event EventHandler<ArgsAbo<News>> onEnvoyerNews;
        private string nom;

        /// <summary>
        /// Créé un topic avec un nom en paramètre
        /// </summary>
        /// <param name="nom"></param>
        public Topic(string nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Permet de récupérer et de modifier le nom du topic
        /// </summary>
        public string topic
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public override string ToString()
        {
            return this.nom;
        }

        /// <summary>
        /// Permet de créer une news et de déclencher l'événement d'ajout de news
        /// </summary>
        /// <param name="contenu"></param>
        public void envoyerNews(String contenu)
        {
            if(onEnvoyerNews != null)
            {
                News uneNew = new News(this, contenu);
                ArgsAbo<News> args = new ArgsAbo<News>(uneNew);
                onEnvoyerNews(this, args);
            }
        }
    }
}
