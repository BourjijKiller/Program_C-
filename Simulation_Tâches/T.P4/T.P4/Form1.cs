using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P4
{
    public partial class Form1 : Form
    {
        PersonneFactory personneFactory = new PersonneFactory();
        TextBox textBox = new TextBox();
        private int index;

        public Form1()
        {
            InitializeComponent();
            verifPersonnes();
        }

        /// <summary>
        /// Méthode permettant de générer une chaine de caractères aléatoire selon une taille passée en paramètre
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private static string genererChaine(int length)
        {
            const string pool = "abcdefghijklmnopqrstuvwxyz";
            var builder = new StringBuilder();
            Random rand = new Random();
            for(var i = 0; i < length; i++)
            {
                var c = pool[rand.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Ajout de personnes aléatoires dans la liste de personnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Creation_Click(object sender, EventArgs e)
        {
            if (this.radioButton_admin.Checked)
                this.personneFactory.ajouterPersonnes(new Administrateur(genererChaine(12), genererChaine(8)));
            else
                this.personneFactory.ajouterPersonnes(new Ouvrier(genererChaine(12), genererChaine(8)));
            MessageBox.Show("Création de " + this.personneFactory.recupNom(index) + " (" + this.personneFactory.recupType(index) + ")", "Confirmation d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            index++;
            verifPersonnes();
            updateComboBox();
        }

        /// <summary>
        /// Événément renvoyant les résultats des pointeurs de fonctions dans le richTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Exec_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            if(this.personneFactory.taches != null)
            {
                this.personneFactory.taches(textBox);
                this.richTextBox_Result.Text = textBox.Text;
            }

            else
            {
                MessageBox.Show("Merci de cocher au moins 1 tâche ! ", "ERREUR VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier s'il existe au moins 1 personne dans la liste pour continuer
        /// </summary>
        public void verifPersonnes()
        {
            if (personneFactory.tailleListePersonnes() == 0)
                this.button_Exec.Enabled = false;
            else
                this.button_Exec.Enabled = true;
        }

        /// <summary>
        /// Ajoute la méthode tache1 dans le pointeur de fonction, selon la checkBox cochée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_tache1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Personne personne = (Personne)this.comboBox_Personnes.SelectedItem;
                CheckBox c = (CheckBox)sender;
                if (c.Checked)
                    this.personneFactory.taches += personne.tache1;
                else
                    this.personneFactory.taches -= personne.tache1;
            }

            catch(NullReferenceException ex)
            {
                MessageBox.Show("Merci de choisir une personne avant de choisir les tâches ! \r\n" +
                   ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.checkBox_tache1.Checked = false;
            }
           
        }

        /// <summary>
        /// Ajoute la méthode tache2 dans le pointeur de fonction, selon la checkBox cochée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_tache2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Personne personne = (Personne)this.comboBox_Personnes.SelectedItem;
                CheckBox c = (CheckBox)sender;
                if (c.Checked)
                    this.personneFactory.taches += personne.tache2;
                else
                    this.personneFactory.taches -= personne.tache2;
            }

            catch(NullReferenceException ex)
            {
                MessageBox.Show("Merci de choisir une personne avant de choisir les tâches ! \r\n" +
                    ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.checkBox_tache2.Checked = false;
            }
        }

        /// <summary>
        /// Remplis et mets à jour la comboBox de personnes
        /// </summary>
        private void updateComboBox()
        {
            this.comboBox_Personnes.DataSource = this.personneFactory.contenuPersonne();
            this.comboBox_Personnes.DisplayMember = "identite";
        }

        /// <summary>
        /// Met à jour le pointeur de fonction 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Personnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkBox_tache1.Checked = false;
            this.checkBox_tache2.Checked = false;
            this.personneFactory.taches = null;
        }
    }
}
