using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P2
{
     public class Article : Usine
    {
        private int id;
        private string nom;
        private string forme;
        private Matiere matiere;

        public Article(int id, string nom, string forme, Matiere matiere)
        {
            this.id = id;
            this.nom = nom;
            this.forme = forme;
            this.matiere = matiere;
        }

        public virtual string action()
        {
            return "";
        }

        public int getID
        {
            get
            {
                return this.id;
            }
        }

        public string getNom
        {
            get
            {
                return this.nom;
            }
        }

        public string getForme
        {
            get
            {
                return this.forme;
            }
        }

        public string getArticle
        {
            get
            {
                return "[" + this.id + ", " + this.nom + "]";
            }
        }

        public virtual List<Matiere> recupMatiere()
        {
            List<Matiere> list = new List<Matiere>();
            list.Add(matiere);

            return list;
        }
    }
}
