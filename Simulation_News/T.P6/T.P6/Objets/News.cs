using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6.Objets
{
    class News
    {
        private Topic topic;
        private String contenu;

		/// <summary>
        /// Création d'une news en fonction d'un topic et du contenu
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="contenu"></param>
		public News(Topic topic, String contenu)
        {
            this.topic = topic;
            this.contenu = contenu;
        }

		/// <summary>
        /// Récupère le contenu de la news
        /// </summary>
		public String getContenu
        {
			get
            {
                return this.contenu;
            }
        }

		/// <summary>
        /// Description de la news sous forme textuelle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.topic + " --> " + this.contenu;
        }
    }
}
