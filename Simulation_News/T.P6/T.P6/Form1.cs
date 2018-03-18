using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P6
{
    public partial class Form1 : Form
    {
        private TopicFactory tf;
        private PersonneFactory pf;
        public Form1()
        {
            this.tf = new TopicFactory();
            this.pf = new PersonneFactory();
            InitializeComponent();

            this.comboBox_Topic_Delete.DisplayMember = "topic";
            this.comboBox_topicAbo.DisplayMember = "topic";
            this.comboBox_Topic_Envoyer.DisplayMember = "topic";

            this.comboBox_personneAbo.DisplayMember = "personne";
            this.comboBox_Personne_Delete.DisplayMember = "personne";
            this.comboBox_Personne_Envoyer.DisplayMember = "personne";

            // Abonnement des événements sur toute les ComboBox lors de l'ajout de Topics
            this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Delete).ajouterData;
            this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_topicAbo).ajouterData;
            this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).ajouterData;

            // Abonnement des événements sur toute les ComboBox lors de la suppression de Topics
            this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_topicAbo).supprimerData;
            this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Delete).supprimerData;
            this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).supprimerData;

            // Abonnement des événements sur toute les ComboBox lors de l'ajout d'une personne
            this.pf.onAjouterPersonne += ((ComboBoxHandler)comboBox_Personne_Delete).ajouterData;
            this.pf.onAjouterPersonne += ((ComboBoxHandler)comboBox_personneAbo).ajouterData;
            this.pf.onAjouterPersonne += ((ComboBoxHandler)comboBox_Personne_Envoyer).ajouterData;

            // Abonnement des événements sur toute les ComboBox lors de la suppression d'une personne
            this.pf.onSupprimerPersonne += ((ComboBoxHandler)comboBox_Personne_Delete).supprimerData;
            this.pf.onSupprimerPersonne += ((ComboBoxHandler)comboBox_personneAbo).supprimerData;
            this.pf.onSupprimerPersonne += ((ComboBoxHandler)comboBox_Topic_Envoyer).supprimerData;
        }

        /// <summary>
        /// Permet d'effacer le placeholder si l'utilisateur saisie quelque chose dans la ComboBox
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="text"></param>
        private void placeholderEnter(TextBox textBox, String text)
        {
            if(textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Permet de re-générer le placeholder si rien n'est saisie lors de la perte de Focus de la ComboBox
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="text"></param>
        private void placeholderLeave(TextBox textBox, String text)
        {
            if(textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Silver;
                textBox.Font = new Font(this.textBox_Topic.Font, FontStyle.Italic | FontStyle.Bold);
            }
        }

        private void textBox_Topic_Enter(object sender, EventArgs e)
        {
            placeholderEnter(this.textBox_Topic, "Saisir un topic");
        }

        private void textBox_Topic_Leave(object sender, EventArgs e)
        {
            placeholderLeave(this.textBox_Topic, "Saisir un topic");
        }

        private void textBox_Personne_Enter(object sender, EventArgs e)
        {
            placeholderEnter(this.textBox_Personne, "Saisir une personne");
        }

        private void textBox_Personne_Leave(object sender, EventArgs e)
        {
            placeholderLeave(this.textBox_Personne, "Saisir une personne");
        }

        /// <summary>
        /// Création d'un topic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CreerTopic_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox_Topic.Text) || this.textBox_Topic.Text == "Saisir un topic")
                MessageBox.Show("Merci de saisir un topic ! ", "ERREUR AJOUT TOPIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.tf.ajouterUnTopic(this.textBox_Topic.Text);
                MessageBox.Show("Topic " + this.textBox_Topic.Text + " ajouté ! ", "SUCCES AJOUT TOPIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox_Topic.Text = "";
            }
            placeholderLeave(this.textBox_Topic, "Saisir un topic");
        }

        /// <summary>
        /// Suppression d'un topic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Supprimer_Topic_Click(object sender, EventArgs e)
        {
            if(this.comboBox_Topic_Delete.SelectedItem != null)
                this.tf.supprimerUnTopic(this.comboBox_Topic_Delete.SelectedItem);
            else
                MessageBox.Show("Veuillez sélectionner un topic", "ERREUR SUPPR TOPIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Création d'une personne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CreerPersonne_Click(object sender, EventArgs e)
        {
            if (this.textBox_Personne.Text == "Saisir une personne" || String.IsNullOrEmpty(this.textBox_Personne.Text))
                MessageBox.Show("Merci de saisir une personne ! ", "ERREUR AJOUT PERSONNE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.pf.ajouterUnePersonne(this.textBox_Personne.Text);
                MessageBox.Show("Personne " + this.textBox_Personne.Text + " ajouté ! ", "SUCCES AJOUT PERSONNE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox_Personne.Text = "";
            }
            placeholderLeave(this.textBox_Personne, "Saisir une personne");
        }

        /// <summary>
        /// Suppression d'une personne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Supprimer_Personne_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Personne_Delete.SelectedItem != null)
                this.pf.supprimerUnePersonne(this.comboBox_Personne_Delete.SelectedItem);
            else
                MessageBox.Show("Merci de sélectionner une personne !", "ERREUR SUPPR PERSONNE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
