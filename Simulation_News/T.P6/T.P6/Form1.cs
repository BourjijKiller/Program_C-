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
            InitializeComponent();

            // Abonnement des événements sur toute les ComboBox lors de l'ajout de Topics
            this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Delete).ajouterData;
            this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_topicAbo).ajouterData;
            this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).ajouterData;

            //Abonnement des événements sur toute les ComboBox lors de la suppression de Topics
            this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_topicAbo).supprimerData;
            this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Delete).supprimerData;
            this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).supprimerData;
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
    }
}
