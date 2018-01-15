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
    public partial class FormAjout : Form
    {
        // Note pour amis
        Label label_note = new Label();

        // Numéro bureau pour Travail
        Label label_numeroBureau = new Label();

        // Relation familliale pour famille
        Label label_relationFamilliale = new Label();

        // Note pour amis
        TextBox textBox_note = new TextBox();

        // Numéro bureau pour Travail
        TextBox textBox_numeroBureau = new TextBox();

        // Relation familliale pour famille
        TextBox textBox_relationFamilliale = new TextBox();

        Repertoire annuaire;

        public FormAjout(Repertoire annuaire)
        {
            InitializeComponent();
            this.RdBtn_Normal.CheckedChanged += new EventHandler(RdBtn_Normal_CheckedChanged);
            this.RdBtn_Travail.CheckedChanged += new EventHandler(RdBtn_Normal_CheckedChanged);
            this.RdBtn_Amis.CheckedChanged += new EventHandler(RdBtn_Normal_CheckedChanged);
            this.RdBtn_Famille.CheckedChanged += new EventHandler(RdBtn_Normal_CheckedChanged);
            this.annuaire = annuaire;
        }

        private void clearControls()
        {
            foreach (object ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Label))
                {
                    Label label = (Label)ctrl;
                    if (label.Name.StartsWith("label_dyn_"))
                        label.Visible = false;
                }

                if (ctrl.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)ctrl;
                    if (textBox.Name.StartsWith("textBox_dyn_"))
                        textBox.Visible = false;
                }
            }
        }

        private void RdBtn_Normal_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBtn_Normal.Checked == true)
            {
                clearControls();
            }

            else if(RdBtn_Amis.Checked == true)
            {
                clearControls();

                label_note.Name = "label_dyn_note";
                label_note.Text = "Note";
                label_note.Size = new Size(100, 23);
                label_note.Font = new Font("Tahoma", 10, FontStyle.Bold);
                label_note.Location = new Point(33, 466);
                label_note.Visible = true;
                this.Controls.Add(label_note);

                textBox_note.Name = "textBox_dyn_note";
                textBox_note.Size = new Size(332, 22);
                textBox_note.Location = new Point(153, 466);
                textBox_note.Visible = true;
                this.Controls.Add(textBox_note);
            }

            else if(RdBtn_Travail.Checked == true)
            {
                clearControls();

                label_numeroBureau.Name = "label_dyn_numeroBureau";
                label_numeroBureau.Text = "Numéro de bureau";
                label_numeroBureau.Size = new Size(100, 89);
                label_numeroBureau.Font = new Font("Tahoma", 10, FontStyle.Bold);
                label_numeroBureau.Location = new Point(33, 451);
                label_numeroBureau.AutoSize = false;
                label_numeroBureau.TextAlign = ContentAlignment.MiddleCenter;
                label_numeroBureau.Visible = true;
                this.Controls.Add(label_numeroBureau);

                textBox_numeroBureau.Name = "textBox_dyn_numeroBureau";
                textBox_numeroBureau.Size = new Size(332, 22);
                textBox_numeroBureau.Location = new Point(153, 486);
                textBox_numeroBureau.Visible = true;
                this.Controls.Add(textBox_numeroBureau);
            }

            else if(RdBtn_Famille.Checked == true)
            {
                clearControls();

                label_relationFamilliale.Name = "label_dyn_relationFamilliale";
                label_relationFamilliale.Text = "Relation familliale";
                label_relationFamilliale.Size = new Size(100, 89);
                label_relationFamilliale.Font = new Font("Tahoma", 10, FontStyle.Bold);
                label_relationFamilliale.Location = new Point(33, 451);
                label_relationFamilliale.AutoSize = false;
                label_relationFamilliale.TextAlign = ContentAlignment.MiddleCenter;
                label_relationFamilliale.Visible = true;
                this.Controls.Add(label_relationFamilliale);

                textBox_relationFamilliale.Name = "textBox_dyn_relationFamilliale";
                textBox_relationFamilliale.Size = new Size(332, 22);
                textBox_relationFamilliale.Location = new Point(153, 486);
                textBox_relationFamilliale.Visible = true;
                this.Controls.Add(textBox_relationFamilliale);
            }
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez-vous vraiment quitter ? ", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
                this.Close();
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("Réinitialiser tout les champs du formulaire ?", "Confirmation d'annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rep == DialogResult.Yes)
            {
                foreach(Control control in this.Controls)
                {
                    if (control is TextBox)
                        control.Text = String.Empty;
                }

                RdBtn_Normal.Checked = true;
                clearControls();
            }
        }

        private Boolean champsVide()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox && control.Visible == true)
                {
                    if (String.IsNullOrEmpty((control as TextBox).Text))
                        return false;
                }
            }

            return true;
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nom.Text))
            {
                DialogResult rep = MessageBox.Show("Enregistrer l'utilisateur " + nom.Text + " ?", "Confirmation d'enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rep == DialogResult.Yes)
                {
                    if (champsVide())
                    {
                        RadioButton r = null;
                        foreach(Control control in groupBox1.Controls)
                        {
                            if(control is RadioButton && (control as RadioButton).Checked)
                            {
                                r = (RadioButton)control;
                                break;
                            }
                        }

                        switch (r.Name)
                        {
                            case "RdBtn_Normal":
                                Personne personne = new Personne(nom.Text, prenom.Text, adresse.Text, telephone.Text, "Normal");
                                annuaire.addPersonne(personne);
                                break;
                            case "RdBtn_Amis":
                                Amis amis = new Amis(nom.Text, prenom.Text, adresse.Text, telephone.Text, textBox_note.Text);
                                annuaire.addPersonne(amis);
                                break;
                            case "RdBtn_Famille":
                                Famille famille = new Famille(nom.Text, prenom.Text, adresse.Text, telephone.Text, textBox_relationFamilliale.Text);
                                annuaire.addPersonne(famille);
                                break;
                            case "RdBtn_Travail":
                                Travail travail = new Travail(nom.Text, prenom.Text, adresse.Text, telephone.Text, textBox_numeroBureau.Text);
                                annuaire.addPersonne(travail);
                                break;
                        }

                        MessageBox.Show("Contact ajouté avec succès ! ", "Succès d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Tout les champs sont obligatoires ! \r\n" +
                            "Merci de remplir tout les champs demandés", "Erreur Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
                MessageBox.Show("Merci de saisir le nom de la personne !", "Erreur Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
