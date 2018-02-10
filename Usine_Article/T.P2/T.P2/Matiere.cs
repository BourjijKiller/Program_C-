using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P2
{
    public class Matiere
    {
        private string nom;
        private double densite;

        public Matiere(string nom, double densite)
        {
            this.nom = nom;
            this.densite = densite;
        }

        public string getMatiere
        {
            get
            {
                return "[" + this.nom + "] --> " + "(" + this.densite + ")";
            }
        }

        public string getNomMatiere
        {
            get
            {
                return this.nom;
            }
        }

        public double getDensiteMatiere
        {
            get
            {
                return this.densite;
            }
        }
  
    }
}
