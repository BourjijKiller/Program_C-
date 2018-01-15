namespace T.P1
{
    partial class FormAjout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_titre = new System.Windows.Forms.Label();
            this.label_sousTitre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdBtn_Travail = new System.Windows.Forms.RadioButton();
            this.RdBtn_Famille = new System.Windows.Forms.RadioButton();
            this.RdBtn_Amis = new System.Windows.Forms.RadioButton();
            this.RdBtn_Normal = new System.Windows.Forms.RadioButton();
            this.label_typePersonne = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label_adresse = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label_telephone = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_titre.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titre.Location = new System.Drawing.Point(224, 23);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(338, 36);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "Ajout d\'une personne";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sousTitre
            // 
            this.label_sousTitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sousTitre.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sousTitre.Location = new System.Drawing.Point(33, 104);
            this.label_sousTitre.Name = "label_sousTitre";
            this.label_sousTitre.Size = new System.Drawing.Size(401, 23);
            this.label_sousTitre.TabIndex = 1;
            this.label_sousTitre.Text = "Merci de remplir les informations ci-dessous";
            this.label_sousTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.RdBtn_Travail);
            this.groupBox1.Controls.Add(this.RdBtn_Famille);
            this.groupBox1.Controls.Add(this.RdBtn_Amis);
            this.groupBox1.Controls.Add(this.RdBtn_Normal);
            this.groupBox1.Location = new System.Drawing.Point(265, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // RdBtn_Travail
            // 
            this.RdBtn_Travail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdBtn_Travail.Location = new System.Drawing.Point(336, 16);
            this.RdBtn_Travail.Name = "RdBtn_Travail";
            this.RdBtn_Travail.Size = new System.Drawing.Size(104, 24);
            this.RdBtn_Travail.TabIndex = 3;
            this.RdBtn_Travail.TabStop = true;
            this.RdBtn_Travail.Text = "Travail";
            this.RdBtn_Travail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdBtn_Travail.UseVisualStyleBackColor = true;
            // 
            // RdBtn_Famille
            // 
            this.RdBtn_Famille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdBtn_Famille.Location = new System.Drawing.Point(226, 16);
            this.RdBtn_Famille.Name = "RdBtn_Famille";
            this.RdBtn_Famille.Size = new System.Drawing.Size(104, 24);
            this.RdBtn_Famille.TabIndex = 2;
            this.RdBtn_Famille.TabStop = true;
            this.RdBtn_Famille.Text = "Famille";
            this.RdBtn_Famille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdBtn_Famille.UseVisualStyleBackColor = true;
            // 
            // RdBtn_Amis
            // 
            this.RdBtn_Amis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdBtn_Amis.Location = new System.Drawing.Point(116, 16);
            this.RdBtn_Amis.Name = "RdBtn_Amis";
            this.RdBtn_Amis.Size = new System.Drawing.Size(104, 24);
            this.RdBtn_Amis.TabIndex = 1;
            this.RdBtn_Amis.TabStop = true;
            this.RdBtn_Amis.Text = "Amis";
            this.RdBtn_Amis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdBtn_Amis.UseVisualStyleBackColor = true;
            // 
            // RdBtn_Normal
            // 
            this.RdBtn_Normal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdBtn_Normal.Location = new System.Drawing.Point(6, 16);
            this.RdBtn_Normal.Name = "RdBtn_Normal";
            this.RdBtn_Normal.Size = new System.Drawing.Size(104, 24);
            this.RdBtn_Normal.TabIndex = 0;
            this.RdBtn_Normal.TabStop = true;
            this.RdBtn_Normal.Text = "Normal";
            this.RdBtn_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdBtn_Normal.UseVisualStyleBackColor = true;
            this.RdBtn_Normal.CheckedChanged += new System.EventHandler(this.RdBtn_Normal_CheckedChanged);
            // 
            // label_typePersonne
            // 
            this.label_typePersonne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_typePersonne.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_typePersonne.Location = new System.Drawing.Point(33, 152);
            this.label_typePersonne.Name = "label_typePersonne";
            this.label_typePersonne.Size = new System.Drawing.Size(204, 24);
            this.label_typePersonne.TabIndex = 3;
            this.label_typePersonne.Text = "Type de personne";
            this.label_typePersonne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nom
            // 
            this.nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom.Location = new System.Drawing.Point(153, 239);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(332, 22);
            this.nom.TabIndex = 4;
            // 
            // label_Nom
            // 
            this.label_Nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Nom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nom.Location = new System.Drawing.Point(33, 237);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(100, 23);
            this.label_Nom.TabIndex = 5;
            this.label_Nom.Text = "Nom";
            this.label_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_prenom
            // 
            this.label_prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_prenom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.Location = new System.Drawing.Point(33, 297);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(100, 23);
            this.label_prenom.TabIndex = 7;
            this.label_prenom.Text = "Prénom";
            this.label_prenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prenom
            // 
            this.prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prenom.Location = new System.Drawing.Point(153, 299);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(332, 22);
            this.prenom.TabIndex = 6;
            // 
            // label_adresse
            // 
            this.label_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_adresse.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresse.Location = new System.Drawing.Point(33, 357);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(100, 23);
            this.label_adresse.TabIndex = 9;
            this.label_adresse.Text = "Adresse";
            this.label_adresse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adresse
            // 
            this.adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adresse.Location = new System.Drawing.Point(153, 359);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(332, 22);
            this.adresse.TabIndex = 8;
            // 
            // label_telephone
            // 
            this.label_telephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_telephone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telephone.Location = new System.Drawing.Point(33, 411);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(100, 23);
            this.label_telephone.TabIndex = 11;
            this.label_telephone.Text = "Téléphone";
            this.label_telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telephone
            // 
            this.telephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telephone.Location = new System.Drawing.Point(153, 413);
            this.telephone.Multiline = true;
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(332, 22);
            this.telephone.TabIndex = 10;
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Valider.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Valider.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Valider.Location = new System.Drawing.Point(51, 586);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(170, 44);
            this.Btn_Valider.TabIndex = 12;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = false;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Annuler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Annuler.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Annuler.Location = new System.Drawing.Point(289, 586);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(170, 44);
            this.Btn_Annuler.TabIndex = 13;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = false;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Quitter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Quitter.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quitter.Location = new System.Drawing.Point(535, 586);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(170, 44);
            this.Btn_Quitter.TabIndex = 14;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = false;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // FormAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(744, 665);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_Annuler);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.label_telephone);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label_typePersonne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_sousTitre);
            this.Controls.Add(this.label_titre);
            this.MaximumSize = new System.Drawing.Size(762, 712);
            this.MinimumSize = new System.Drawing.Size(762, 712);
            this.Name = "FormAjout";
            this.Text = "FormAjout";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_sousTitre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_typePersonne;
        private System.Windows.Forms.RadioButton RdBtn_Normal;
        private System.Windows.Forms.RadioButton RdBtn_Amis;
        private System.Windows.Forms.RadioButton RdBtn_Famille;
        private System.Windows.Forms.RadioButton RdBtn_Travail;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Button Btn_Quitter;
    }
}