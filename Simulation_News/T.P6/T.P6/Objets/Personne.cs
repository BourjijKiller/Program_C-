using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6
{
    class Personne
    {
        private string nom;

        /// <summary>
        /// Créé une personne avec un nom en paramètre
        /// </summary>
        /// <param name="nom"></param>
        public Personne(string nom)
        {
            this.nom = nom;
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
    }
}
