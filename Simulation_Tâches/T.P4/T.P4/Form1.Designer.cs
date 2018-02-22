namespace T.P4
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxTypesPersonnes = new System.Windows.Forms.GroupBox();
            this.radioButton_Ouvrier = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.button_Creation = new System.Windows.Forms.Button();
            this.button_Exec = new System.Windows.Forms.Button();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.checkBox_tache1 = new System.Windows.Forms.CheckBox();
            this.checkBox_tache2 = new System.Windows.Forms.CheckBox();
            this.comboBox_Personnes = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxTypesPersonnes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTypesPersonnes
            // 
            this.groupBoxTypesPersonnes.Controls.Add(this.radioButton_Ouvrier);
            this.groupBoxTypesPersonnes.Controls.Add(this.radioButton_admin);
            this.groupBoxTypesPersonnes.Location = new System.Drawing.Point(38, 34);
            this.groupBoxTypesPersonnes.Name = "groupBoxTypesPersonnes";
            this.groupBoxTypesPersonnes.Size = new System.Drawing.Size(383, 65);
            this.groupBoxTypesPersonnes.TabIndex = 0;
            this.groupBoxTypesPersonnes.TabStop = false;
            // 
            // radioButton_Ouvrier
            // 
            this.radioButton_Ouvrier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Ouvrier.Location = new System.Drawing.Point(248, 21);
            this.radioButton_Ouvrier.Name = "radioButton_Ouvrier";
            this.radioButton_Ouvrier.Size = new System.Drawing.Size(99, 24);
            this.radioButton_Ouvrier.TabIndex = 1;
            this.radioButton_Ouvrier.TabStop = true;
            this.radioButton_Ouvrier.Text = "Ouvrier";
            this.radioButton_Ouvrier.UseVisualStyleBackColor = true;
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_admin.Location = new System.Drawing.Point(15, 21);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(161, 24);
            this.radioButton_admin.TabIndex = 0;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "Administrateur";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            // 
            // button_Creation
            // 
            this.button_Creation.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Creation.Location = new System.Drawing.Point(481, 34);
            this.button_Creation.Name = "button_Creation";
            this.button_Creation.Size = new System.Drawing.Size(122, 65);
            this.button_Creation.TabIndex = 1;
            this.button_Creation.Text = "Création";
            this.button_Creation.UseVisualStyleBackColor = true;
            this.button_Creation.Click += new System.EventHandler(this.button_Creation_Click);
            // 
            // button_Exec
            // 
            this.button_Exec.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exec.Location = new System.Drawing.Point(196, 228);
            this.button_Exec.Name = "button_Exec";
            this.button_Exec.Size = new System.Drawing.Size(254, 65);
            this.button_Exec.TabIndex = 3;
            this.button_Exec.Text = "Exécuter";
            this.button_Exec.UseVisualStyleBackColor = true;
            this.button_Exec.Click += new System.EventHandler(this.button_Exec_Click);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(27, 316);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(576, 144);
            this.richTextBox_Result.TabIndex = 4;
            this.richTextBox_Result.Text = "";
            // 
            // checkBox_tache1
            // 
            this.checkBox_tache1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tache1.Location = new System.Drawing.Point(53, 151);
            this.checkBox_tache1.Name = "checkBox_tache1";
            this.checkBox_tache1.Size = new System.Drawing.Size(124, 42);
            this.checkBox_tache1.TabIndex = 5;
            this.checkBox_tache1.Text = "Tâche 1";
            this.checkBox_tache1.UseVisualStyleBackColor = true;
            this.checkBox_tache1.CheckedChanged += new System.EventHandler(this.checkBox_tache1_CheckedChanged);
            // 
            // checkBox_tache2
            // 
            this.checkBox_tache2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tache2.Location = new System.Drawing.Point(196, 151);
            this.checkBox_tache2.Name = "checkBox_tache2";
            this.checkBox_tache2.Size = new System.Drawing.Size(124, 42);
            this.checkBox_tache2.TabIndex = 6;
            this.checkBox_tache2.Text = "Tâche 2";
            this.checkBox_tache2.UseVisualStyleBackColor = true;
            this.checkBox_tache2.CheckedChanged += new System.EventHandler(this.checkBox_tache2_CheckedChanged);
            // 
            // comboBox_Personnes
            // 
            this.comboBox_Personnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personnes.FormattingEnabled = true;
            this.comboBox_Personnes.Location = new System.Drawing.Point(337, 163);
            this.comboBox_Personnes.Name = "comboBox_Personnes";
            this.comboBox_Personnes.Size = new System.Drawing.Size(252, 24);
            this.comboBox_Personnes.TabIndex = 7;
            this.comboBox_Personnes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Personnes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(626, 472);
            this.Controls.Add(this.comboBox_Personnes);
            this.Controls.Add(this.checkBox_tache2);
            this.Controls.Add(this.checkBox_tache1);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.button_Exec);
            this.Controls.Add(this.button_Creation);
            this.Controls.Add(this.groupBoxTypesPersonnes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation de tâches";
            this.groupBoxTypesPersonnes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypesPersonnes;
        private System.Windows.Forms.RadioButton radioButton_Ouvrier;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.Button button_Creation;
        private System.Windows.Forms.Button button_Exec;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.CheckBox checkBox_tache1;
        private System.Windows.Forms.CheckBox checkBox_tache2;
        private System.Windows.Forms.ComboBox comboBox_Personnes;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

