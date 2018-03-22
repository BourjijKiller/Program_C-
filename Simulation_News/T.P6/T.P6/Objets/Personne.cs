using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.P6.Args;
using T.P6.Objets;

namespace T.P6.Objets
{
    class Personne
    {
        private string nom;
        private List<News> news;

        /// <summary>
        /// Créé une personne avec un nom en paramètre
        /// </summary>
        /// <param name="nom"></param>
        public Personne(string nom)
        {
            this.nom = nom;
            this.news = new List<News>();
        }

        /// <summary>
        /// Permet de récupérer et de modifier le nom de la personne
        /// </summary>
        public string personne
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

        /// <summary>
        /// Ajoute une news dans la liste de news
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void receiveNews(Object sender, ArgsAbo<News> args)
        {
            this.news.Add(args.get());
        }

        /// <summary>
        /// Permet d'afficher les news
        /// </summary>
        /// <returns></returns>
        public String getNews()
        {
            string retour = "------ NEWS ------" + Environment.NewLine;
            int counter = 0;
            foreach (News uneNews in this.news)
            {
                retour += uneNews.ToString() + Environment.NewLine;
                counter++;
            }
            if (counter == 0)
            {
                retour += "Aucune news reçue" + Environment.NewLine;
            }
            return retour;
        }
    }
}
