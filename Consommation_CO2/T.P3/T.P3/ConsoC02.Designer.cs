namespace T.P3
{
    partial class ConsoC02
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
            this.checkBox_pied = new System.Windows.Forms.CheckBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.button_Valid = new System.Windows.Forms.Button();
            this.label_nbKm = new System.Windows.Forms.Label();
            this.label_nbPers = new System.Windows.Forms.Label();
            this.checkBox_voiture = new System.Windows.Forms.CheckBox();
            this.checkBox_car = new System.Windows.Forms.CheckBox();
            this.numericUpDown_nbKm = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nbPersonne = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_pied
            // 
            this.checkBox_pied.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_pied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_pied.Location = new System.Drawing.Point(66, 148);
            this.checkBox_pied.Name = "checkBox_pied";
            this.checkBox_pied.Size = new System.Drawing.Size(104, 24);
            this.checkBox_pied.TabIndex = 4;
            this.checkBox_pied.Text = "A pied";
            this.checkBox_pied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_pied.UseVisualStyleBackColor = false;
            this.checkBox_pied.CheckedChanged += new System.EventHandler(this.checkBox_pied_CheckedChanged);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(66, 201);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(540, 132);
            this.richTextBoxResult.TabIndex = 7;
            this.richTextBoxResult.Text = "";
            // 
            // button_Valid
            // 
            this.button_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valid.Location = new System.Drawing.Point(223, 365);
            this.button_Valid.Name = "button_Valid";
            this.button_Valid.Size = new System.Drawing.Size(239, 42);
            this.button_Valid.TabIndex = 8;
            this.button_Valid.Text = "Calculer";
            this.button_Valid.UseVisualStyleBackColor = true;
            this.button_Valid.Click += new System.EventHandler(this.button_Valid_Click);
            // 
            // label_nbKm
            // 
            this.label_nbKm.AutoSize = true;
            this.label_nbKm.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbKm.Location = new System.Drawing.Point(83, 38);
            this.label_nbKm.Name = "label_nbKm";
            this.label_nbKm.Size = new System.Drawing.Size(148, 20);
            this.label_nbKm.TabIndex = 0;
            this.label_nbKm.Text = "Nombre de km";
            this.label_nbKm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nbPers
            // 
            this.label_nbPers.AutoSize = true;
            this.label_nbPers.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbPers.Location = new System.Drawing.Point(371, 38);
            this.label_nbPers.Name = "label_nbPers";
            this.label_nbPers.Size = new System.Drawing.Size(235, 20);
            this.label_nbPers.TabIndex = 2;
            this.label_nbPers.Text = "Nombre de personne(s)";
            this.label_nbPers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_voiture
            // 
            this.checkBox_voiture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_voiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_voiture.Location = new System.Drawing.Point(270, 148);
            this.checkBox_voiture.Name = "checkBox_voiture";
            this.checkBox_voiture.Size = new System.Drawing.Size(135, 24);
            this.checkBox_voiture.TabIndex = 5;
            this.checkBox_voiture.Text = "En voiture";
            this.checkBox_voiture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_voiture.UseVisualStyleBackColor = false;
            this.checkBox_voiture.CheckedChanged += new System.EventHandler(this.checkBox_voiture_CheckedChanged);
            // 
            // checkBox_car
            // 
            this.checkBox_car.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_car.Location = new System.Drawing.Point(502, 148);
            this.checkBox_car.Name = "checkBox_car";
            this.checkBox_car.Size = new System.Drawing.Size(104, 24);
            this.checkBox_car.TabIndex = 6;
            this.checkBox_car.Text = "En bus";
            this.checkBox_car.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_car.UseVisualStyleBackColor = false;
            this.checkBox_car.CheckedChanged += new System.EventHandler(this.checkBox_car_CheckedChanged);
            // 
            // numericUpDown_nbKm
            // 
            this.numericUpDown_nbKm.DecimalPlaces = 2;
            this.numericUpDown_nbKm.Location = new System.Drawing.Point(66, 74);
            this.numericUpDown_nbKm.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown_nbKm.Name = "numericUpDown_nbKm";
            this.numericUpDown_nbKm.Size = new System.Drawing.Size(188, 22);
            this.numericUpDown_nbKm.TabIndex = 9;
            // 
            // numericUpDown_nbPersonne
            // 
            this.numericUpDown_nbPersonne.Location = new System.Drawing.Point(374, 74);
            this.numericUpDown_nbPersonne.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown_nbPersonne.Name = "numericUpDown_nbPersonne";
            this.numericUpDown_nbPersonne.Size = new System.Drawing.Size(232, 22);
            this.numericUpDown_nbPersonne.TabIndex = 10;
            // 
            // ConsoC02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 419);
            this.Controls.Add(this.numericUpDown_nbPersonne);
            this.Controls.Add(this.numericUpDown_nbKm);
            this.Controls.Add(this.checkBox_car);
            this.Controls.Add(this.checkBox_voiture);
            this.Controls.Add(this.label_nbPers);
            this.Controls.Add(this.label_nbKm);
            this.Controls.Add(this.button_Valid);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.checkBox_pied);
            this.MaximumSize = new System.Drawing.Size(713, 466);
            this.MinimumSize = new System.Drawing.Size(606, 466);
            this.Name = "ConsoC02";
            this.Text = "Consommation de CO2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_pied;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button button_Valid;
        private System.Windows.Forms.Label label_nbKm;
        private System.Windows.Forms.Label label_nbPers;
        private System.Windows.Forms.CheckBox checkBox_voiture;
        private System.Windows.Forms.CheckBox checkBox_car;
        private System.Windows.Forms.NumericUpDown numericUpDown_nbKm;
        private System.Windows.Forms.NumericUpDown numericUpDown_nbPersonne;
    }
}

