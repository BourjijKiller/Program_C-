namespace T.P2
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
            this.label_ArticleType = new System.Windows.Forms.Label();
            this.groupBox_Type = new System.Windows.Forms.GroupBox();
            this.rdButton_Voile = new System.Windows.Forms.RadioButton();
            this.rdButton_Golf = new System.Windows.Forms.RadioButton();
            this.rdButton_Foot = new System.Windows.Forms.RadioButton();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label_Nom = new System.Windows.Forms.Label();
            this.textBox_forme = new System.Windows.Forms.TextBox();
            this.label_forme = new System.Windows.Forms.Label();
            this.label_matiere = new System.Windows.Forms.Label();
            this.comboBox_matiere = new System.Windows.Forms.ComboBox();
            this.comboBox_dyn_matiere2 = new System.Windows.Forms.ComboBox();
            this.comboBox_dyn_matiere3 = new System.Windows.Forms.ComboBox();
            this.groupBox_matiere = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_densite = new System.Windows.Forms.NumericUpDown();
            this.Btn_AjoutMatiere = new System.Windows.Forms.Button();
            this.textBox_matiereSaisie = new System.Windows.Forms.TextBox();
            this.label_matiereSaisie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Type.SuspendLayout();
            this.groupBox_matiere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_densite)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titre.ForeColor = System.Drawing.Color.LawnGreen;
            this.label_titre.Location = new System.Drawing.Point(234, 22);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(469, 36);
            this.label_titre.TabIndex = 1;
            this.label_titre.Text = "Ajout d\'un article de sport";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_ArticleType
            // 
            this.label_ArticleType.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ArticleType.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ArticleType.Location = new System.Drawing.Point(23, 117);
            this.label_ArticleType.Name = "label_ArticleType";
            this.label_ArticleType.Size = new System.Drawing.Size(244, 28);
            this.label_ArticleType.TabIndex = 2;
            this.label_ArticleType.Text = "Type d\'article à ajouter";
            this.label_ArticleType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Type
            // 
            this.groupBox_Type.Controls.Add(this.rdButton_Voile);
            this.groupBox_Type.Controls.Add(this.rdButton_Golf);
            this.groupBox_Type.Controls.Add(this.rdButton_Foot);
            this.groupBox_Type.Location = new System.Drawing.Point(308, 109);
            this.groupBox_Type.Name = "groupBox_Type";
            this.groupBox_Type.Size = new System.Drawing.Size(462, 43);
            this.groupBox_Type.TabIndex = 3;
            this.groupBox_Type.TabStop = false;
            // 
            // rdButton_Voile
            // 
            this.rdButton_Voile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton_Voile.ForeColor = System.Drawing.Color.White;
            this.rdButton_Voile.Location = new System.Drawing.Point(308, 13);
            this.rdButton_Voile.Name = "rdButton_Voile";
            this.rdButton_Voile.Size = new System.Drawing.Size(152, 24);
            this.rdButton_Voile.TabIndex = 5;
            this.rdButton_Voile.Text = "Planche à voile";
            this.rdButton_Voile.UseVisualStyleBackColor = true;
            // 
            // rdButton_Golf
            // 
            this.rdButton_Golf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton_Golf.ForeColor = System.Drawing.Color.White;
            this.rdButton_Golf.Location = new System.Drawing.Point(161, 13);
            this.rdButton_Golf.Name = "rdButton_Golf";
            this.rdButton_Golf.Size = new System.Drawing.Size(138, 24);
            this.rdButton_Golf.TabIndex = 4;
            this.rdButton_Golf.Text = "Club de golf";
            this.rdButton_Golf.UseVisualStyleBackColor = true;
            // 
            // rdButton_Foot
            // 
            this.rdButton_Foot.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton_Foot.ForeColor = System.Drawing.Color.White;
            this.rdButton_Foot.Location = new System.Drawing.Point(6, 12);
            this.rdButton_Foot.Name = "rdButton_Foot";
            this.rdButton_Foot.Size = new System.Drawing.Size(138, 24);
            this.rdButton_Foot.TabIndex = 0;
            this.rdButton_Foot.Text = "Ballon de foot";
            this.rdButton_Foot.UseVisualStyleBackColor = true;
            this.rdButton_Foot.CheckedChanged += new System.EventHandler(this.rdButton_Foot_CheckedChanged);
            // 
            // label_id
            // 
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.SystemColors.Control;
            this.label_id.Location = new System.Drawing.Point(23, 214);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(244, 28);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "Identifiant de l\'article";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(308, 214);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(294, 27);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nom.Location = new System.Drawing.Point(308, 278);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(294, 27);
            this.textBox_Nom.TabIndex = 7;
            // 
            // label_Nom
            // 
            this.label_Nom.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nom.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Nom.Location = new System.Drawing.Point(23, 277);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(244, 28);
            this.label_Nom.TabIndex = 6;
            this.label_Nom.Text = "Nom de l\'article";
            this.label_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_forme
            // 
            this.textBox_forme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_forme.Location = new System.Drawing.Point(308, 337);
            this.textBox_forme.Name = "textBox_forme";
            this.textBox_forme.Size = new System.Drawing.Size(294, 27);
            this.textBox_forme.TabIndex = 9;
            // 
            // label_forme
            // 
            this.label_forme.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forme.ForeColor = System.Drawing.SystemColors.Control;
            this.label_forme.Location = new System.Drawing.Point(23, 337);
            this.label_forme.Name = "label_forme";
            this.label_forme.Size = new System.Drawing.Size(244, 28);
            this.label_forme.TabIndex = 8;
            this.label_forme.Text = "Forme de l\'article";
            this.label_forme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_matiere
            // 
            this.label_matiere.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matiere.ForeColor = System.Drawing.SystemColors.Control;
            this.label_matiere.Location = new System.Drawing.Point(23, 393);
            this.label_matiere.Name = "label_matiere";
            this.label_matiere.Size = new System.Drawing.Size(244, 28);
            this.label_matiere.TabIndex = 10;
            this.label_matiere.Text = "Matière de l\'article";
            this.label_matiere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_matiere
            // 
            this.comboBox_matiere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_matiere.FormattingEnabled = true;
            this.comboBox_matiere.Location = new System.Drawing.Point(308, 395);
            this.comboBox_matiere.Name = "comboBox_matiere";
            this.comboBox_matiere.Size = new System.Drawing.Size(294, 28);
            this.comboBox_matiere.TabIndex = 11;
            // 
            // comboBox_dyn_matiere2
            // 
            this.comboBox_dyn_matiere2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dyn_matiere2.FormattingEnabled = true;
            this.comboBox_dyn_matiere2.Location = new System.Drawing.Point(308, 453);
            this.comboBox_dyn_matiere2.Name = "comboBox_dyn_matiere2";
            this.comboBox_dyn_matiere2.Size = new System.Drawing.Size(294, 28);
            this.comboBox_dyn_matiere2.TabIndex = 12;
            this.comboBox_dyn_matiere2.Visible = false;
            // 
            // comboBox_dyn_matiere3
            // 
            this.comboBox_dyn_matiere3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dyn_matiere3.FormattingEnabled = true;
            this.comboBox_dyn_matiere3.Location = new System.Drawing.Point(308, 514);
            this.comboBox_dyn_matiere3.Name = "comboBox_dyn_matiere3";
            this.comboBox_dyn_matiere3.Size = new System.Drawing.Size(294, 28);
            this.comboBox_dyn_matiere3.TabIndex = 13;
            this.comboBox_dyn_matiere3.Visible = false;
            // 
            // groupBox_matiere
            // 
            this.groupBox_matiere.Controls.Add(this.label2);
            this.groupBox_matiere.Controls.Add(this.numericUpDown_densite);
            this.groupBox_matiere.Controls.Add(this.Btn_AjoutMatiere);
            this.groupBox_matiere.Controls.Add(this.textBox_matiereSaisie);
            this.groupBox_matiere.Controls.Add(this.label_matiereSaisie);
            this.groupBox_matiere.Controls.Add(this.label1);
            this.groupBox_matiere.Location = new System.Drawing.Point(775, 179);
            this.groupBox_matiere.Name = "groupBox_matiere";
            this.groupBox_matiere.Size = new System.Drawing.Size(297, 332);
            this.groupBox_matiere.TabIndex = 14;
            this.groupBox_matiere.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Densité de la matière";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_densite
            // 
            this.numericUpDown_densite.DecimalPlaces = 2;
            this.numericUpDown_densite.Location = new System.Drawing.Point(29, 202);
            this.numericUpDown_densite.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numericUpDown_densite.Name = "numericUpDown_densite";
            this.numericUpDown_densite.Size = new System.Drawing.Size(246, 22);
            this.numericUpDown_densite.TabIndex = 17;
            // 
            // Btn_AjoutMatiere
            // 
            this.Btn_AjoutMatiere.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AjoutMatiere.Location = new System.Drawing.Point(96, 274);
            this.Btn_AjoutMatiere.Name = "Btn_AjoutMatiere";
            this.Btn_AjoutMatiere.Size = new System.Drawing.Size(123, 44);
            this.Btn_AjoutMatiere.TabIndex = 16;
            this.Btn_AjoutMatiere.Text = "Valider";
            this.Btn_AjoutMatiere.UseVisualStyleBackColor = true;
            this.Btn_AjoutMatiere.Click += new System.EventHandler(this.Btn_AjoutMatiere_Click);
            // 
            // textBox_matiereSaisie
            // 
            this.textBox_matiereSaisie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matiereSaisie.Location = new System.Drawing.Point(29, 115);
            this.textBox_matiereSaisie.Name = "textBox_matiereSaisie";
            this.textBox_matiereSaisie.Size = new System.Drawing.Size(246, 27);
            this.textBox_matiereSaisie.TabIndex = 15;
            // 
            // label_matiereSaisie
            // 
            this.label_matiereSaisie.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matiereSaisie.ForeColor = System.Drawing.SystemColors.Control;
            this.label_matiereSaisie.Location = new System.Drawing.Point(29, 74);
            this.label_matiereSaisie.Name = "label_matiereSaisie";
            this.label_matiereSaisie.Size = new System.Drawing.Size(244, 28);
            this.label_matiereSaisie.TabIndex = 15;
            this.label_matiereSaisie.Text = "Saisir une matière :";
            this.label_matiereSaisie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ajout d\'une matière";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1130, 606);
            this.Controls.Add(this.groupBox_matiere);
            this.Controls.Add(this.comboBox_dyn_matiere3);
            this.Controls.Add(this.comboBox_dyn_matiere2);
            this.Controls.Add(this.comboBox_matiere);
            this.Controls.Add(this.label_matiere);
            this.Controls.Add(this.textBox_forme);
            this.Controls.Add(this.label_forme);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.groupBox_Type);
            this.Controls.Add(this.label_ArticleType);
            this.Controls.Add(this.label_titre);
            this.Name = "FormAjout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un article";
            this.groupBox_Type.ResumeLayout(false);
            this.groupBox_matiere.ResumeLayout(false);
            this.groupBox_matiere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_densite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_ArticleType;
        private System.Windows.Forms.GroupBox groupBox_Type;
        private System.Windows.Forms.RadioButton rdButton_Voile;
        private System.Windows.Forms.RadioButton rdButton_Golf;
        private System.Windows.Forms.RadioButton rdButton_Foot;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.TextBox textBox_forme;
        private System.Windows.Forms.Label label_forme;
        private System.Windows.Forms.Label label_matiere;
        private System.Windows.Forms.ComboBox comboBox_matiere;
        private System.Windows.Forms.ComboBox comboBox_dyn_matiere2;
        private System.Windows.Forms.ComboBox comboBox_dyn_matiere3;
        private System.Windows.Forms.GroupBox groupBox_matiere;
        private System.Windows.Forms.Button Btn_AjoutMatiere;
        private System.Windows.Forms.TextBox textBox_matiereSaisie;
        private System.Windows.Forms.Label label_matiereSaisie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_densite;
    }
}