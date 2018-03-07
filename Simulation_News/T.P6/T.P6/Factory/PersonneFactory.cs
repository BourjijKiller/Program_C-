using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6
{
    class PersonneFactory
    {
        private List<Personne> personneFactory;

        /// <summary>
        /// Créé une liste de personnes
        /// </summary>
        public PersonneFactory()
        {
            this.personneFactory = new List<Personne>();
        }
    }
}
