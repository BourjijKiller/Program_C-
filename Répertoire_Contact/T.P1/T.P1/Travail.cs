using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P1
{
    class Travail : Personne
    {
        private string numeroBureau;

        public Travail(string nom, string prenom, string adresse, string telephone, string numeroBureau) : base(nom, prenom, adresse, telephone, "Travail")
        {
            this.numeroBureau = numeroBureau;
        }
    }
}
