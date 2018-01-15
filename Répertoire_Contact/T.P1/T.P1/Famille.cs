using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P1
{
    class Famille : Personne
    {
        private string relationFamilliale;

        public Famille(string nom, string prenom, string adresse, string telephone, string relationFamilliale) : base(nom, prenom, adresse, telephone, "Famille")
        {
            this.relationFamilliale = relationFamilliale;
        }

    }
}
