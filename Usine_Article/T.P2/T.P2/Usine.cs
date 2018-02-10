using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P2
{
    public class Usine
    {
        private BindingList<Article> usineAArticle;
        private BindingList<Matiere> usineMatiere;

        public Usine()
        {
            usineAArticle = new BindingList<Article>();
            usineMatiere = new BindingList<Matiere>();
        }

        public void addArticle(Article article)
        {
            this.usineAArticle.Add(article);
        }

        public void addMatiere(Matiere matiere)
        {
            this.usineMatiere.Add(matiere);
        }

        public void deleteArticle(Article article)
        {
            this.usineAArticle.Remove(article);
        }

        public void deleteMatiere(Matiere matiere)
        {
            this.usineMatiere.Remove(matiere);
        }

        public BindingList<Article> contenuArticle()
        {
            return this.usineAArticle;
        }

        public BindingList<Matiere> contenuMatiere()
        {
            return this.usineMatiere;
        }
    }
}