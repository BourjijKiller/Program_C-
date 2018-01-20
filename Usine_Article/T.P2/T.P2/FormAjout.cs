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
        
        /*
         * Problème --> Les 3 comboBoxs sont liées car elles pointes toutes sur la même usine (Cloner usine...)
         * Méthode permettant de mettre à jour le contenu des ComboBox matière en fonction des ajouts
        */
        private void updateComboBox()
        {
            foreach(Control c in this.Controls)
            {
                if(c.GetType() == typeof(ComboBox))
                {
                    ComboBox comboBox = (ComboBox)c;
                    if (comboBox.Name.StartsWith("comboBox"))
                    {
                        comboBox.DisplayMember = "getMatiere";
                        comboBox.DataSource = usine.contenuMatiere();
                    }
                }
            }
        }

        /*
         * Fonction permettant de cacher les contrôles dynamiques*
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
                    }

                    else
                        MessageBox.Show("Erreur ! \r\n" +
                            "Merci de remplir tout les champs ! ", "Erreur validation matière", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
