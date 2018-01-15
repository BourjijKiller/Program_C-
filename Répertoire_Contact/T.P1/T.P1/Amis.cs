using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P1
{
    class Amis : Personne
    {
        private string note;

        public Amis(string nom, string prenom, string adresse, string telephone, string note) : base(nom, prenom, adresse, telephone, "Amis")
        {
            this.note = note;
        }
    }
}
