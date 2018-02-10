using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P3
{
    public partial class ConsoC02 : Form
    {
        Calcul calcul = new Calcul();

        public ConsoC02()
        {
            InitializeComponent();
        }

        /**
         * Fonction permettant de vérifier si les saisies sont positifs ou nuls
         */
        private Boolean verifForm()
        {
            Boolean isValid = true;
            if (this.numericUpDown_nbKm.Value < 0 || this.numericUpDown_nbPersonne.Value < 0)
                isValid = false;
            return isValid;
        }

        /**
         * Événement effectuant les calculs et renvoyant les résultats selon les saisies de l'utilisateur
         */
        private void button_Valid_Click(object sender, EventArgs e)
        {
            calcul.toString = "";
            if(calcul.exec != null)
            {
                if(verifForm())
                {
                    calcul.exec(Convert.ToDouble(this.numericUpDown_nbKm.Value), Convert.ToDouble(this.numericUpDown_nbPersonne.Value));
                    this.richTextBoxResult.Text = calcul.toString;
                }

                else
                    MessageBox.Show("Merci de renseigner le nombre de Km et le nombre de personne", "ERREUR VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
                MessageBox.Show("Merci de cocher au moins 1 case !", "ERREUR VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void checkBox_pied_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if(c.Checked == true)
                calcul.exec += calcul.calculPied;
            else
                calcul.exec -= calcul.calculPied;
        }

        private void checkBox_voiture_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if(c.Checked == true)
                calcul.exec += calcul.calculVoiture;
            else
                calcul.exec -= calcul.calculVoiture;
        }

        private void checkBox_car_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
                calcul.exec += calcul.calculCar;
            else
                calcul.exec -= calcul.calculCar;
        }
    }
}
