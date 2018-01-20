namespace T.P2
{
    partial class Sport
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
            this.label_titre = new System.Windows.Forms.Label();
            this.label_typeArticle = new System.Windows.Forms.Label();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.listBox_Article = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titre.ForeColor = System.Drawing.Color.LawnGreen;
            this.label_titre.Location = new System.Drawing.Point(97, 18);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(364, 36);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "Usine d\'article de sport";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_typeArticle
            // 
            this.label_typeArticle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_typeArticle.ForeColor = System.Drawing.SystemColors.Control;
            this.label_typeArticle.Location = new System.Drawing.Point(12, 171);
            this.label_typeArticle.Name = "label_typeArticle";
            this.label_typeArticle.Size = new System.Drawing.Size(244, 28);
            this.label_typeArticle.TabIndex = 1;
            this.label_typeArticle.Text = "Contenu de l\'usine à article";
            this.label_typeArticle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.BackColor = System.Drawing.Color.Ivory;
            this.Btn_Ajout.FlatAppearance.BorderSize = 5;
            this.Btn_Ajout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout.Location = new System.Drawing.Point(34, 296);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(167, 59);
            this.Btn_Ajout.TabIndex = 3;
            this.Btn_Ajout.Text = "Ajouter un article";
            this.Btn_Ajout.UseVisualStyleBackColor = false;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Ivory;
            this.Btn_Delete.FlatAppearance.BorderSize = 5;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(350, 296);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(167, 59);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "Supprimer un article";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // listBox_Article
            // 
            this.listBox_Article.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox_Article.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Article.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_Article.FormattingEnabled = true;
            this.listBox_Article.ItemHeight = 23;
            this.listBox_Article.Location = new System.Drawing.Point(272, 95);
            this.listBox_Article.MultiColumn = true;
            this.listBox_Article.Name = "listBox_Article";
            this.listBox_Article.Size = new System.Drawing.Size(256, 165);
            this.listBox_Article.TabIndex = 2;
            this.listBox_Article.DoubleClick += new System.EventHandler(this.listBox_Article_DoubleClick);
            // 
            // Sport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(553, 394);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Ajout);
            this.Controls.Add(this.listBox_Article);
            this.Controls.Add(this.label_typeArticle);
            this.Controls.Add(this.label_titre);
            this.MaximumSize = new System.Drawing.Size(571, 441);
            this.MinimumSize = new System.Drawing.Size(571, 441);
            this.Name = "Sport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usine d\'articles de sport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_typeArticle;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.ListBox listBox_Article;
    }
}

