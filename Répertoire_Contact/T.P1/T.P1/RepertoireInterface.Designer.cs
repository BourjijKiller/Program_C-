namespace T.P1
{
    partial class RepertoireInterface
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
            this.List_Contact = new System.Windows.Forms.ComboBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.Btn_Infos = new System.Windows.Forms.Button();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Contact
            // 
            this.List_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Contact.FormattingEnabled = true;
            this.List_Contact.Location = new System.Drawing.Point(12, 49);
            this.List_Contact.Name = "List_Contact";
            this.List_Contact.Size = new System.Drawing.Size(381, 24);
            this.List_Contact.TabIndex = 0;
            this.List_Contact.SelectedIndexChanged += new System.EventHandler(this.List_Contact_SelectedIndexChanged);
            // 
            // label_contact
            // 
            this.label_contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_contact.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.Location = new System.Drawing.Point(80, 9);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(242, 23);
            this.label_contact.TabIndex = 1;
            this.label_contact.Text = "Liste du répertoire";
            this.label_contact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Infos
            // 
            this.Btn_Infos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Infos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Infos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Infos.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Infos.Location = new System.Drawing.Point(84, 170);
            this.Btn_Infos.Name = "Btn_Infos";
            this.Btn_Infos.Size = new System.Drawing.Size(238, 61);
            this.Btn_Infos.TabIndex = 2;
            this.Btn_Infos.Text = "Afficher les informations";
            this.Btn_Infos.UseVisualStyleBackColor = false;
            this.Btn_Infos.Click += new System.EventHandler(this.Btn_Infos_Click);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Ajout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Ajout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Ajout.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout.Location = new System.Drawing.Point(12, 327);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(170, 44);
            this.Btn_Ajout.TabIndex = 3;
            this.Btn_Ajout.Text = "Ajouter contact";
            this.Btn_Ajout.UseVisualStyleBackColor = false;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(217, 327);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(176, 44);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "Supprimer contact";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // RepertoireInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(405, 383);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Ajout);
            this.Controls.Add(this.Btn_Infos);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.List_Contact);
            this.MinimumSize = new System.Drawing.Size(423, 430);
            this.Name = "RepertoireInterface";
            this.Text = "Répertoire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox List_Contact;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Button Btn_Infos;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Button Btn_Delete;
    }
}

