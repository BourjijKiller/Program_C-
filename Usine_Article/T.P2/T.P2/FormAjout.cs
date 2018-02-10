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
    public partial class FormAjout : Form
    {
        // Label pour densite avec club de golf
        Label label_numero = new Label();

        // Numeric pour densite avec club de golf
        NumericUpDown numericUpDown_numero = new NumericUpDown();

        Usine usine;
        Usine usine2 = new Usine();
        Usine usine3 = new Usine();

        public FormAjout(Usine usine)
        {
            InitializeComponent();
            this.rdButton_Foot.CheckedChanged += new EventHandler(rdButton_Foot_CheckedChanged);
            this.rdButton_Golf.CheckedChanged += new EventHandler(rdButton_Foot_CheckedChanged);
            this.rdButton_Voile.CheckedChanged += new EventHandler(rdButton_Foot_CheckedChanged);
            this.usine = usine;
            updateComboBox();
            disabledControls();
        }

        /**
         * Méthode permettant de cloner les matières pour les listes box
         */
        public void usineMatiereCloner()
        {
            foreach (Matiere matiere in this.usine.contenuMatiere())
            {
                if(!this.usine2.contenuMatiere().Contains(matiere))
                    usine2.addMatiere(matiere);
                if (!this.usine3.contenuMatiere().Contains(matiere))
                    usine3.addMatiere(matiere);
            }
        }

        /**
         * Méthode permettant de vider les champs après ajout d'un article
         */
        public void clearForm()
        {
            foreach(Control c in this.Controls)
            {
                if(c.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }

                if(c.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown n = (NumericUpDown)c;
                    if (n.Visible == true)
                        n.Value = 0;
                }

                clearControls();
                disabledControls();
            }
        }

        
        /*
         * Méthode permettant de mettre à jour le contenu des ComboBox matière en fonction des ajouts
        */
        private void updateComboBox()
        {
            usineMatiereCloner();
            foreach (Control c in this.Controls)
            {
                if(c.GetType() == typeof(ComboBox))
                {
                    ComboBox comboBox = (ComboBox)c;
                    if (comboBox.Name.StartsWith("comboBox"))
                    {
                        if(comboBox.Name.EndsWith("re"))
                        {
                            comboBox.DisplayMember = "getMatiere";
                            comboBox.DataSource = usine.contenuMatiere();
                        }

                        else if (comboBox.Name.EndsWith("2"))
                        {
                            comboBox.DisplayMember = "getMatiere";
                            comboBox.DataSource = usine2.contenuMatiere();
                        }

                        else
                        {
                            comboBox.DisplayMember = "getMatiere";
                            comboBox.DataSource = usine3.contenuMatiere();
                        }
                    }
                }
            }
        }

        /*
         * Fonction permettant de cacher les contrôles dynamiques
        */

        private void clearControls()
        {
            foreach(Object ctrl in this.Controls)
            {
                if(ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    if (comboBox.Name.StartsWith("comboBox_dyn_"))
                        comboBox.Visible = false;
                }

                if(ctrl.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown numericUpDown = (NumericUpDown)ctrl;
                    if (numericUpDown.Name.StartsWith("numericUpDown_dyn_"))
                        numericUpDown.Visible = false;
                }

                if(ctrl.GetType() == typeof(Label))
                {
                    Label label = (Label)ctrl;
                    if (label.Name.StartsWith("label_dyn_"))
                        label.Visible = false;
                }
            }
        }

        /*
         * Désactive le verouillage des contrôles du formulaire
        */
        private void disabledControls()
        {
            foreach(Control control in this.Controls)
            {
                if (control.GetType() != typeof(Label) && control.GetType() != typeof(GroupBox))
                    control.Enabled = false;
            }

            foreach (Control control in groupBox_matiere.Controls)
            {
                if (control.GetType() != typeof(Label))
                    control.Enabled = false;
            }
        }

        /*
         * Verouille les contrôles du formulaire si aucun bouton radio n'est sélectionné
        */

        private void enabledControls()
        {
            foreach(Control control in this.Controls)
                control.Enabled = true;

            foreach (Control control in groupBox_matiere.Controls)
                control.Enabled = true;
        }

        private void rdButton_Foot_CheckedChanged(object sender, EventArgs e)
        {
            if(rdButton_Foot.Checked == true)
            {
                clearControls();
                enabledControls();
                this.comboBox_dyn_matiere2.Visible = true;
            }

            else if(rdButton_Golf.Checked == true)
            {
                clearControls();
                enabledControls();
                label_numero.Name = "label_dyn_numero";
                label_numero.Text = "Numéro de l'article";
                label_numero.Size = new Size(244, 28);
                label_numero.Font = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Italic);
                label_numero.ForeColor = System.Drawing.Color.White;
                label_numero.Location = new Point(23, 453);
                label_numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label_numero.Visible = true;
                this.Controls.Add(label_numero);

                numericUpDown_numero.Name = "numericUpDown_dyn_densite";
                numericUpDown_numero.Size = new Size(294, 28);
                numericUpDown_numero.Location = new Point(308, 453);
                numericUpDown_numero.Visible = true;
                numericUpDown_numero.Maximum = 5000000;
                numericUpDown_numero.DecimalPlaces = 2;
                this.Controls.Add(numericUpDown_numero);
            }

            else if(rdButton_Voile.Checked == true)
            {
                clearControls();
                enabledControls();
                this.comboBox_dyn_matiere2.Visible = true;
                this.comboBox_dyn_matiere3.Visible = true;
            }
        }

        /*
         * Ajout d'une matière
        */

        private void Btn_AjoutMatiere_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("Ajouter la matière " + this.textBox_matiereSaisie.Text + " ?", "Confirmation matière", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (rep)
            {
                case DialogResult.Yes:
                    if (!String.IsNullOrEmpty(this.textBox_matiereSaisie.Text) && this.numericUpDown_densite != null)
                    {
                        usine.addMatiere(new Matiere(this.textBox_matiereSaisie.Text, (double)this.numericUpDown_densite.Value));
                        MessageBox.Show("Matière ajoutée ! ", "Succès ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.textBox_matiereSaisie.Clear();
                        this.numericUpDown_densite.Value = 0;
                        updateComboBox();
                    }

                    else
                        MessageBox.Show("Erreur ! \r\n" +
                            "Merci de remplir tout les champs ! ", "Erreur validation matière", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        /**
         * Ajoute l'article dans l'usine
         */
        private void button_AjoutMat_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("Ajouter l'article " + this.textBox_Nom.Text + " d'id [" + this.textBox_id.Text + "] ?", "Confirmation d'ajout dans l'usine", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (rep)
            {
                case DialogResult.Yes:
                    if(verifyFields())
                    {
                        Matiere mat1 = (Matiere)this.comboBox_matiere.SelectedItem;
                        Matiere mat2 = (Matiere)this.comboBox_dyn_matiere2.SelectedItem;
                        Matiere mat3 = (Matiere)this.comboBox_dyn_matiere3.SelectedItem;

                        if (this.rdButton_Foot.Checked)
                            usine.addArticle(new BallonFoot(Convert.ToInt16(this.textBox_id.Text), this.textBox_Nom.Text, this.textBox_forme.Text, new Matiere(mat1.getNomMatiere, Convert.ToDouble(mat1.getDensiteMatiere)), new Matiere(mat2.getNomMatiere, Convert.ToDouble(mat2.getDensiteMatiere))));
                        else if (this.rdButton_Golf.Checked)
                            usine.addArticle(new ClubGolf(Convert.ToInt16(this.textBox_id.Text), this.textBox_Nom.Text, this.textBox_forme.Text, new Matiere(mat1.getNomMatiere, Convert.ToDouble(mat1.getDensiteMatiere)), Convert.ToInt16(this.numericUpDown_numero.Value)));
                        else
                            usine.addArticle(new PlancheVoile(Convert.ToInt16(this.textBox_id.Text), this.textBox_Nom.Text, this.textBox_forme.Text, new Matiere(mat1.getNomMatiere, Convert.ToDouble(mat2.getDensiteMatiere)), new Matiere(mat2.getNomMatiere, Convert.ToDouble(mat2.getDensiteMatiere)), new Matiere(mat3.getNomMatiere, Convert.ToDouble(mat3.getDensiteMatiere))));
                        MessageBox.Show("L'article a bien été ajouté ! ", "Succès ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.rdButton_Foot.Checked = false;
                        this.rdButton_Golf.Checked = false;
                        this.rdButton_Voile.Checked = false;
                        clearForm();
                    }

                    else
                        MessageBox.Show("Merci de renseigner tout les champs !!!", "ERREUR FORM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        /**
         * Méthode vérifiant que tout les champs nécessaires à l'ajout d'un article sont bien renseignés
         */
        private Boolean verifyFields()
        {
            Boolean isOk = false;
            foreach(Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)c;
                    if (textBox.Visible == true && !String.IsNullOrEmpty(textBox.Text))
                        isOk = true;
                    else
                        isOk = false;
                }
                   
                else if (c.GetType() == typeof(ComboBox))
                {
                    ComboBox comboBox = (ComboBox)c;
                    if (comboBox.Visible == true && !String.IsNullOrEmpty(comboBox.Text))
                        isOk = true;
                    else
                        isOk = false;
                }
            }

            return isOk;
        }
    }
}