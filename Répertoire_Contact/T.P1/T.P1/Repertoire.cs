using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P1
{
    public class Repertoire : RepertoireInterface
    {
        private BindingList<Personne> personne;

        public Repertoire()
        {
            personne = new BindingList<Personne>();
        }

        public void addPersonne(Personne p)
        {
            this.personne.Add(p);
        }

        public void removePersonne(Personne p)
        {
            this.personne.Remove(p);
        }

        public BindingList<Personne> contenu()
        {
            return this.personne;
        }
    }
}
