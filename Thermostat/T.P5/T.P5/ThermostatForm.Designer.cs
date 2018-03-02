namespace T.P5
{
    partial class ThermostatForm
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
            this.textBox_Temp = new System.Windows.Forms.TextBox();
            this.button_Temperature = new System.Windows.Forms.Button();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox_Temp
            // 
            this.textBox_Temp.Location = new System.Drawing.Point(93, 40);
            this.textBox_Temp.Name = "textBox_Temp";
            this.textBox_Temp.Size = new System.Drawing.Size(211, 22);
            this.textBox_Temp.TabIndex = 0;
            // 
            // button_Temperature
            // 
            this.button_Temperature.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Temperature.Location = new System.Drawing.Point(129, 79);
            this.button_Temperature.Name = "button_Temperature";
            this.button_Temperature.Size = new System.Drawing.Size(146, 50);
            this.button_Temperature.TabIndex = 1;
            this.button_Temperature.Text = "Température";
            this.button_Temperature.UseVisualStyleBackColor = true;
            this.button_Temperature.Click += new System.EventHandler(this.button_Temperature_Click);
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Location = new System.Drawing.Point(45, 161);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(319, 157);
            this.richTextBox_result.TabIndex = 2;
            this.richTextBox_result.Text = "";
            // 
            // ThermostatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 342);
            this.Controls.Add(this.richTextBox_result);
            this.Controls.Add(this.button_Temperature);
            this.Controls.Add(this.textBox_Temp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThermostatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thermostat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Temp;
        private System.Windows.Forms.Button button_Temperature;
        private System.Windows.Forms.RichTextBox richTextBox_result;
    }
}

