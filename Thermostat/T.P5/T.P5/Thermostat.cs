using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P5
{
    /// <summary>
    /// Création d'un pointeur de fonction
    /// </summary>
    /// <param name="temp"></param>
    public delegate void TemperatureChangeHandler(float temp);
    public class Thermostat
    {
        /// <summary>
        /// Initialisation du delegate à null
        /// </summary>
        public TemperatureChangeHandler temperatureChangeHandler = null;
        private float currentTemperature;

        /// <summary>
        /// Créé un événement (eventHandler) lorsque l'on change la température par la méthode currentTemp
        /// </summary>
        public event TemperatureChangeHandler onTemperatureChange;

        /// <summary>
        /// Créé un thermostat
        /// </summary>
        public Thermostat()
        {

        }

        /// <summary>
        /// Permet de récupérer et de mettre à jour la température
        /// </summary>
        public float currentTemp
        {
            get
            {
                return this.currentTemperature;
            }

            set
            {
                if(this.currentTemperature != value)
                {
                    this.currentTemperature = value;
                    if (onTemperatureChange != null)
                        onTemperatureChange(currentTemperature);
                }
            }
        }
    }
}
