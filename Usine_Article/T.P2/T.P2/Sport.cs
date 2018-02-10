using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P2
{
    public partial class Sport : Form
    {
        private Usine usine;

        public Sport()
        {
            InitializeComponent();
            usine = new Usine();
            usine.addArticle(new BallonFoot(541, "Ballon", "rond", new Matiere("Plastique", 50), new Matiere("Fer", 120)));
            usine.addArticle(new ClubGolf(894, "Club de golf", "Carotte", new Matiere("Fer", 120), 41));
            usine.addArticle(new PlancheVoile(412, "Planche à voile", "Rectangulaire", new Matiere("Plastique", 50), new Matiere("Caoutchouc", 45), new Matiere("Placo", 568)));
            this.listBox_Article.DisplayMember = "getArticle";
            this.listBox_Article.DataSource = usine.contenuArticle();
            this.listBox_Article.FormattingEnabled = true;
            this.listBox_Article.HorizontalScrollbar = true;
            this.listBox_Article.ScrollAlwaysVisible = true;
            this.listBox_Article.MultiColumn = false;
        }

        /**
         * Ouvre le formulaire d'ajout d'article de sport et de matière
         */
        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            Form FormAjout = new FormAjout(usine);
            FormAjout.Show();
        }

        /**
         * Permet de supprimer une matière
         */
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Article article = (Article)this.listBox_Article.SelectedItem;
                DialogResult rep = MessageBox.Show("Supprimer l'article [" + article.getNom + "] ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    usine.deleteArticle(article);
                    MessageBox.Show("Article supprimé avec succès ! ", "SUCCES DE SUPPRESSION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Suppression annulé", "ÉCHEC SUPPRESSION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch(NullReferenceException ex)
            {
                MessageBox.Show("Impossible de supprimer \r\n" +
                    "L'usine est vide et ne contient aucun objet ! \r\n" +
                    ex.Message, "EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        /**
         * Affiche les détails de l'article
         */
        private void listBox_Article_DoubleClick(object sender, EventArgs e)
        {
            Article article = (Article)this.listBox_Article.SelectedItem;
            DialogResult rep = MessageBox.Show("Afficher les détails pour l'article [" + article.getNom + "] ?", "Confirmation détails article ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rep == DialogResult.Yes)
            {
                if(article.action() == "Roule")
                {
                    MessageBox.Show("ID de l'article --> " + article.getID + "\r\n" +
                   "Nom de l'article --> " + article.getNom + "\r\n" +
                   "Forme de l'article --> " + article.getForme + "\r\n" +
                   "Action de l'article --> " + article.action() + "\r\n" +
                   "Matière 1 --> " + article.recupMatiere()[0].getMatiere + " \r\n" + 
                   "Matière 2 --> " + article.recupMatiere()[1].getMatiere, "Article " + article.getID, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if(article.action() == "Tape")
                {
                    MessageBox.Show("ID de l'article --> " + article.getID + "\r\n" +
                  "Nom de l'article --> " + article.getNom + "\r\n" +
                  "Forme de l'article --> " + article.getForme + "\r\n" +
                  "Action de l'article --> " + article.action() + "\r\n" +
                  "Matière de l'article --> " + article.recupMatiere()[0].getMatiere + " \r\n" +
                  "Numéro de l'article --> " + ((ClubGolf)article).getNumero, "Article " + article.getID, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("ID de l'article --> " + article.getID + "\r\n" +
                  "Nom de l'article --> " + article.getNom + "\r\n" +
                  "Forme de l'article --> " + article.getForme + "\r\n" +
                  "Action de l'article --> " + article.action() + "\r\n" +
                  "Matière 1 --> " + article.recupMatiere()[0].getMatiere + "\r\n" +
                  "Matière 2 --> " + article.recupMatiere()[1].getMatiere + "\r\n" + 
                  "Matière 3 --> " + article.recupMatiere()[2].getMatiere, "Article " + article.getID, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {

            }

        }
    }
}
