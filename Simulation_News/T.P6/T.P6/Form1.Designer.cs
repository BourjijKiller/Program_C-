using System;

namespace T.P6
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Topic = new System.Windows.Forms.GroupBox();
            this.textBox_Topic = new System.Windows.Forms.TextBox();
            this.groupBox_Personne = new System.Windows.Forms.GroupBox();
            this.groupBox_Abonnement = new System.Windows.Forms.GroupBox();
            this.button_CreerTopic = new System.Windows.Forms.Button();
            this.richTextBox_Topic = new System.Windows.Forms.RichTextBox();
            this.comboBox_Topic_Delete = new T.P6.ComboBoxHandler();
            this.button_Supprimer_Topic = new System.Windows.Forms.Button();
            this.comboBox_Topic_Envoyer = new T.P6.ComboBoxHandler();
            this.label_Topic = new System.Windows.Forms.Label();
            this.button_Envoyer_Topic = new System.Windows.Forms.Button();
            this.richTextBox_Personne = new System.Windows.Forms.RichTextBox();
            this.textBox_Personne = new System.Windows.Forms.TextBox();
            this.button_CreerPersonne = new System.Windows.Forms.Button();
            this.comboBox_Personne_Delete = new T.P6.ComboBoxHandler();
            this.button_Supprimer_Personne = new System.Windows.Forms.Button();
            this.button_Envoyer_Personne = new System.Windows.Forms.Button();
            this.label_Personne = new System.Windows.Forms.Label();
            this.comboBox_Personne_Envoyer = new T.P6.ComboBoxHandler();
            this.label_topicAbo = new System.Windows.Forms.Label();
            this.comboBox_topicAbo = new T.P6.ComboBoxHandler();
            this.label_topicPersonne = new System.Windows.Forms.Label();
            this.comboBox_personneAbo = new T.P6.ComboBoxHandler();
            this.button_envoyerAbo = new System.Windows.Forms.Button();
            this.groupBox_Topic.SuspendLayout();
            this.groupBox_Personne.SuspendLayout();
            this.groupBox_Abonnement.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Topic
            // 
            this.groupBox_Topic.Controls.Add(this.button_Envoyer_Topic);
            this.groupBox_Topic.Controls.Add(this.label_Topic);
            this.groupBox_Topic.Controls.Add(this.comboBox_Topic_Envoyer);
            this.groupBox_Topic.Controls.Add(this.button_Supprimer_Topic);
            this.groupBox_Topic.Controls.Add(this.comboBox_Topic_Delete);
            this.groupBox_Topic.Controls.Add(this.richTextBox_Topic);
            this.groupBox_Topic.Controls.Add(this.button_CreerTopic);
            this.groupBox_Topic.Controls.Add(this.textBox_Topic);
            this.groupBox_Topic.Location = new System.Drawing.Point(12, 33);
            this.groupBox_Topic.Name = "groupBox_Topic";
            this.groupBox_Topic.Size = new System.Drawing.Size(518, 353);
            this.groupBox_Topic.TabIndex = 0;
            this.groupBox_Topic.TabStop = false;
            this.groupBox_Topic.Text = "Topic";
            // 
            // textBox_Topic
            // 
            this.textBox_Topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Topic.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Topic.Location = new System.Drawing.Point(31, 41);
            this.textBox_Topic.Name = "textBox_Topic";
            this.textBox_Topic.Size = new System.Drawing.Size(193, 27);
            this.textBox_Topic.TabIndex = 0;
            this.textBox_Topic.Text = "Saisir un topic";
            this.textBox_Topic.Enter += new System.EventHandler(this.textBox_Topic_Enter);
            this.textBox_Topic.Leave += new System.EventHandler(this.textBox_Topic_Leave);
            // 
            // groupBox_Personne
            // 
            this.groupBox_Personne.Controls.Add(this.button_Envoyer_Personne);
            this.groupBox_Personne.Controls.Add(this.label_Personne);
            this.groupBox_Personne.Controls.Add(this.comboBox_Personne_Envoyer);
            this.groupBox_Personne.Controls.Add(this.button_Supprimer_Personne);
            this.groupBox_Personne.Controls.Add(this.comboBox_Personne_Delete);
            this.groupBox_Personne.Controls.Add(this.button_CreerPersonne);
            this.groupBox_Personne.Controls.Add(this.textBox_Personne);
            this.groupBox_Personne.Controls.Add(this.richTextBox_Personne);
            this.groupBox_Personne.Location = new System.Drawing.Point(559, 33);
            this.groupBox_Personne.Name = "groupBox_Personne";
            this.groupBox_Personne.Size = new System.Drawing.Size(516, 353);
            this.groupBox_Personne.TabIndex = 1;
            this.groupBox_Personne.TabStop = false;
            this.groupBox_Personne.Text = "Personne";
            // 
            // groupBox_Abonnement
            // 
            this.groupBox_Abonnement.Controls.Add(this.button_envoyerAbo);
            this.groupBox_Abonnement.Controls.Add(this.label_topicPersonne);
            this.groupBox_Abonnement.Controls.Add(this.comboBox_personneAbo);
            this.groupBox_Abonnement.Controls.Add(this.label_topicAbo);
            this.groupBox_Abonnement.Controls.Add(this.comboBox_topicAbo);
            this.groupBox_Abonnement.Location = new System.Drawing.Point(70, 432);
            this.groupBox_Abonnement.Name = "groupBox_Abonnement";
            this.groupBox_Abonnement.Size = new System.Drawing.Size(921, 87);
            this.groupBox_Abonnement.TabIndex = 2;
            this.groupBox_Abonnement.TabStop = false;
            this.groupBox_Abonnement.Text = "Abonnement";
            // 
            // button_CreerTopic
            // 
            this.button_CreerTopic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreerTopic.Location = new System.Drawing.Point(58, 85);
            this.button_CreerTopic.Name = "button_CreerTopic";
            this.button_CreerTopic.Size = new System.Drawing.Size(126, 40);
            this.button_CreerTopic.TabIndex = 1;
            this.button_CreerTopic.Text = "Créer";
            this.button_CreerTopic.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Topic
            // 
            this.richTextBox_Topic.Location = new System.Drawing.Point(271, 41);
            this.richTextBox_Topic.Name = "richTextBox_Topic";
            this.richTextBox_Topic.Size = new System.Drawing.Size(213, 192);
            this.richTextBox_Topic.TabIndex = 2;
            this.richTextBox_Topic.Text = "";
            // 
            // comboBox_Topic_Delete
            // 
            this.comboBox_Topic_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Topic_Delete.FormattingEnabled = true;
            this.comboBox_Topic_Delete.Location = new System.Drawing.Point(31, 172);
            this.comboBox_Topic_Delete.Name = "comboBox_Topic_Delete";
            this.comboBox_Topic_Delete.Size = new System.Drawing.Size(193, 24);
            this.comboBox_Topic_Delete.TabIndex = 3;
            // 
            // button_Supprimer_Topic
            // 
            this.button_Supprimer_Topic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Supprimer_Topic.Location = new System.Drawing.Point(58, 213);
            this.button_Supprimer_Topic.Name = "button_Supprimer_Topic";
            this.button_Supprimer_Topic.Size = new System.Drawing.Size(126, 44);
            this.button_Supprimer_Topic.TabIndex = 4;
            this.button_Supprimer_Topic.Text = "Supprimer";
            this.button_Supprimer_Topic.UseVisualStyleBackColor = true;
            // 
            // comboBox_Topic_Envoyer
            // 
            this.comboBox_Topic_Envoyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Topic_Envoyer.FormattingEnabled = true;
            this.comboBox_Topic_Envoyer.Location = new System.Drawing.Point(280, 280);
            this.comboBox_Topic_Envoyer.Name = "comboBox_Topic_Envoyer";
            this.comboBox_Topic_Envoyer.Size = new System.Drawing.Size(193, 24);
            this.comboBox_Topic_Envoyer.TabIndex = 5;
            // 
            // label_Topic
            // 
            this.label_Topic.AutoSize = true;
            this.label_Topic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Topic.Location = new System.Drawing.Point(348, 252);
            this.label_Topic.Name = "label_Topic";
            this.label_Topic.Size = new System.Drawing.Size(56, 25);
            this.label_Topic.TabIndex = 6;
            this.label_Topic.Text = "Topic";
            this.label_Topic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Envoyer_Topic
            // 
            this.button_Envoyer_Topic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Envoyer_Topic.Location = new System.Drawing.Point(313, 310);
            this.button_Envoyer_Topic.Name = "button_Envoyer_Topic";
            this.button_Envoyer_Topic.Size = new System.Drawing.Size(126, 37);
            this.button_Envoyer_Topic.TabIndex = 7;
            this.button_Envoyer_Topic.Text = "Envoyer";
            this.button_Envoyer_Topic.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Personne
            // 
            this.richTextBox_Personne.Location = new System.Drawing.Point(30, 41);
            this.richTextBox_Personne.Name = "richTextBox_Personne";
            this.richTextBox_Personne.Size = new System.Drawing.Size(213, 192);
            this.richTextBox_Personne.TabIndex = 3;
            this.richTextBox_Personne.Text = "";
            // 
            // textBox_Personne
            // 
            this.textBox_Personne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personne.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Personne.Location = new System.Drawing.Point(291, 41);
            this.textBox_Personne.Name = "textBox_Personne";
            this.textBox_Personne.Size = new System.Drawing.Size(193, 27);
            this.textBox_Personne.TabIndex = 4;
            this.textBox_Personne.Text = "Saisir une personne";
            this.textBox_Personne.Enter += new System.EventHandler(this.textBox_Personne_Enter);
            this.textBox_Personne.Leave += new System.EventHandler(this.textBox_Personne_Leave);
            // 
            // button_CreerPersonne
            // 
            this.button_CreerPersonne.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreerPersonne.Location = new System.Drawing.Point(326, 85);
            this.button_CreerPersonne.Name = "button_CreerPersonne";
            this.button_CreerPersonne.Size = new System.Drawing.Size(126, 32);
            this.button_CreerPersonne.TabIndex = 5;
            this.button_CreerPersonne.Text = "Créer";
            this.button_CreerPersonne.UseVisualStyleBackColor = true;
            // 
            // comboBox_Personne_Delete
            // 
            this.comboBox_Personne_Delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personne_Delete.FormattingEnabled = true;
            this.comboBox_Personne_Delete.Location = new System.Drawing.Point(291, 172);
            this.comboBox_Personne_Delete.Name = "comboBox_Personne_Delete";
            this.comboBox_Personne_Delete.Size = new System.Drawing.Size(193, 24);
            this.comboBox_Personne_Delete.TabIndex = 6;
            // 
            // button_Supprimer_Personne
            // 
            this.button_Supprimer_Personne.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Supprimer_Personne.Location = new System.Drawing.Point(326, 213);
            this.button_Supprimer_Personne.Name = "button_Supprimer_Personne";
            this.button_Supprimer_Personne.Size = new System.Drawing.Size(126, 44);
            this.button_Supprimer_Personne.TabIndex = 7;
            this.button_Supprimer_Personne.Text = "Supprimer";
            this.button_Supprimer_Personne.UseVisualStyleBackColor = true;
            // 
            // button_Envoyer_Personne
            // 
            this.button_Envoyer_Personne.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Envoyer_Personne.Location = new System.Drawing.Point(74, 310);
            this.button_Envoyer_Personne.Name = "button_Envoyer_Personne";
            this.button_Envoyer_Personne.Size = new System.Drawing.Size(126, 37);
            this.button_Envoyer_Personne.TabIndex = 10;
            this.button_Envoyer_Personne.Text = "Envoyer";
            this.button_Envoyer_Personne.UseVisualStyleBackColor = true;
            // 
            // label_Personne
            // 
            this.label_Personne.AutoSize = true;
            this.label_Personne.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Personne.Location = new System.Drawing.Point(93, 252);
            this.label_Personne.Name = "label_Personne";
            this.label_Personne.Size = new System.Drawing.Size(90, 25);
            this.label_Personne.TabIndex = 9;
            this.label_Personne.Text = "Personne";
            this.label_Personne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Personne_Envoyer
            // 
            this.comboBox_Personne_Envoyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personne_Envoyer.FormattingEnabled = true;
            this.comboBox_Personne_Envoyer.Location = new System.Drawing.Point(41, 280);
            this.comboBox_Personne_Envoyer.Name = "comboBox_Personne_Envoyer";
            this.comboBox_Personne_Envoyer.Size = new System.Drawing.Size(193, 24);
            this.comboBox_Personne_Envoyer.TabIndex = 8;
            // 
            // label_topicAbo
            // 
            this.label_topicAbo.AutoSize = true;
            this.label_topicAbo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_topicAbo.Location = new System.Drawing.Point(188, 19);
            this.label_topicAbo.Name = "label_topicAbo";
            this.label_topicAbo.Size = new System.Drawing.Size(56, 25);
            this.label_topicAbo.TabIndex = 8;
            this.label_topicAbo.Text = "Topic";
            this.label_topicAbo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_topicAbo
            // 
            this.comboBox_topicAbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_topicAbo.FormattingEnabled = true;
            this.comboBox_topicAbo.Location = new System.Drawing.Point(120, 47);
            this.comboBox_topicAbo.Name = "comboBox_topicAbo";
            this.comboBox_topicAbo.Size = new System.Drawing.Size(193, 24);
            this.comboBox_topicAbo.TabIndex = 7;
            // 
            // label_topicPersonne
            // 
            this.label_topicPersonne.AutoSize = true;
            this.label_topicPersonne.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_topicPersonne.Location = new System.Drawing.Point(452, 19);
            this.label_topicPersonne.Name = "label_topicPersonne";
            this.label_topicPersonne.Size = new System.Drawing.Size(90, 25);
            this.label_topicPersonne.TabIndex = 11;
            this.label_topicPersonne.Text = "Personne";
            this.label_topicPersonne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_personneAbo
            // 
            this.comboBox_personneAbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_personneAbo.FormattingEnabled = true;
            this.comboBox_personneAbo.Location = new System.Drawing.Point(400, 47);
            this.comboBox_personneAbo.Name = "comboBox_personneAbo";
            this.comboBox_personneAbo.Size = new System.Drawing.Size(193, 24);
            this.comboBox_personneAbo.TabIndex = 10;
            // 
            // button_envoyerAbo
            // 
            this.button_envoyerAbo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_envoyerAbo.Location = new System.Drawing.Point(688, 34);
            this.button_envoyerAbo.Name = "button_envoyerAbo";
            this.button_envoyerAbo.Size = new System.Drawing.Size(126, 37);
            this.button_envoyerAbo.TabIndex = 12;
            this.button_envoyerAbo.Text = "Abonner";
            this.button_envoyerAbo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1087, 549);
            this.Controls.Add(this.groupBox_Abonnement);
            this.Controls.Add(this.groupBox_Personne);
            this.Controls.Add(this.groupBox_Topic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation de news";
            this.groupBox_Topic.ResumeLayout(false);
            this.groupBox_Topic.PerformLayout();
            this.groupBox_Personne.ResumeLayout(false);
            this.groupBox_Personne.PerformLayout();
            this.groupBox_Abonnement.ResumeLayout(false);
            this.groupBox_Abonnement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Topic;
        private System.Windows.Forms.GroupBox groupBox_Personne;
        private System.Windows.Forms.GroupBox groupBox_Abonnement;
        private System.Windows.Forms.TextBox textBox_Topic;
        private System.Windows.Forms.RichTextBox richTextBox_Topic;
        private System.Windows.Forms.Button button_CreerTopic;
        private System.Windows.Forms.Button button_Supprimer_Topic;
        //private System.Windows.Forms.ComboBox comboBox_Topic_Delete;
        private System.Windows.Forms.Button button_Envoyer_Topic;
        private System.Windows.Forms.Label label_Topic;
        //private System.Windows.Forms.ComboBox comboBox_Topic_Envoyer;
        private System.Windows.Forms.Button button_Envoyer_Personne;
        private System.Windows.Forms.Label label_Personne;
        //private System.Windows.Forms.ComboBox comboBox_Personne_Envoyer;
        private System.Windows.Forms.Button button_Supprimer_Personne;
        //private System.Windows.Forms.ComboBox comboBox_Personne_Delete;
        private System.Windows.Forms.Button button_CreerPersonne;
        private System.Windows.Forms.TextBox textBox_Personne;
        private System.Windows.Forms.RichTextBox richTextBox_Personne;
        private System.Windows.Forms.Button button_envoyerAbo;
        private System.Windows.Forms.Label label_topicPersonne;
        //private System.Windows.Forms.ComboBox comboBox_personneAbo;
        private System.Windows.Forms.Label label_topicAbo;
        //private System.Windows.Forms.ComboBox comboBox_topicAbo;

        private ComboBoxHandler comboBox_Topic_Delete;
        private ComboBoxHandler comboBox_Topic_Envoyer;
        private ComboBoxHandler comboBox_topicAbo;
        private ComboBoxHandler comboBox_Personne_Envoyer;
        private ComboBoxHandler comboBox_Personne_Delete;
        private ComboBoxHandler comboBox_personneAbo;
    }
}

