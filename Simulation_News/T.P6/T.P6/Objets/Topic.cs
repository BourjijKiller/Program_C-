using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6
{
    class Topic
    {
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
    }
}
