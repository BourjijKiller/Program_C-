using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.P5
{
    public partial class ThermostatForm : Form
    {
        /// <summary>
        /// Instanciation de la classe Thermostat, Climatisation et Radiateur
        /// </summary>
        Thermostat thermostat = new Thermostat();
        Climatisation climatisation = new Climatisation();
        Radiateur radiateur = new Radiateur();

        /// <summary>
        /// Ajoute les méthodes renvoyant le résultats en fonction de la température dans l'eventHandler onTemperatureChange
        /// </summary>
        public ThermostatForm()
        {
            thermostat.onTemperatureChange += radiateur.onTemperatureChanged;
            thermostat.onTemperatureChange += climatisation.onTemperatureChanged;
            InitializeComponent();
        }

        /// <summary>
        /// Événement affichant le résultat dans la richTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Temperature_Click(object sender, EventArgs e)
        {
            this.richTextBox_result.Text = "";
            climatisation.getResultat = "";
            radiateur.getResultat = "";
            float temp = Convert.ToInt16(textBox_Temp.Text);
            thermostat.currentTemp = temp;
            this.richTextBox_result.Text += climatisation.getResultat;
            this.richTextBox_result.Text += radiateur.getResultat;
        }
    }
}
