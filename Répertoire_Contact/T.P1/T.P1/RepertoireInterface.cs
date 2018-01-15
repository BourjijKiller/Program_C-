using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P1
{
    public partial class RepertoireInterface : Form
    {

        /* N'affiche pas la fenêtre, code de retour à -1 alors que sans cette instruction, code 0 ??? */
        private Repertoire annuaire;

        public RepertoireInterface()
        {
            InitializeComponent();
            annuaire = new Repertoire();

        }

        private void Btn_Infos_Click(object sender, EventArgs e)
        {
            Personne personne = (Personne)this.List_Contact.SelectedItem;
            if (this.List_Contact.Items.Count == 0 || personne.ToString() == "")
            {
                MessageBox.Show("Le répertoire est vide ! ", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult rep =  MessageBox.Show("Afficher les informations de " + personne.identite + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rep == DialogResult.Yes)
                {
                    MessageBox.Show("Nom --> " + personne.Nom + "\r\n" +
                   "Prénom --> " + personne.Prenom + "\r\n" +
                   "Adresse --> " + personne.Adresse + "\r\n" +
                   "Téléphone --> " + personne.Telephone + "\r\n" +
                   "Type --> " + personne.Type,
                   "Information pour la personne " + personne.Nom, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if(rep == DialogResult.No)
                {

                }
            }
        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            Form form = new FormAjout(annuaire);
            form.Show();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if(this.List_Contact.SelectedItem.ToString() != "")
            {
                Personne personne = (Personne)this.List_Contact.SelectedItem;
                DialogResult rep = MessageBox.Show("Supprimer définitivement " + personne.identite + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                    annuaire.removePersonne(personne);
            }
        }

        private void List_Contact_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_Contact.DataSource = annuaire.contenu();
            List_Contact.DisplayMember = "identite";
        }
    }
}
