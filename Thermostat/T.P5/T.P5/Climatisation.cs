using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P5
{
    class Climatisation
    {
        private float temperature;
        private string resultat;

        /// <summary>
        /// Création d'une climatisation
        /// </summary>
        public Climatisation()
        {

        }

        /// <summary>
        /// Met à jour le résultat en fonction de la température
        /// </summary>
        /// <param name="temp"></param>
        public void onTemperatureChanged(float temp)
        {
            this.temperature = temp;
            if(this.temperature >= 20)
            {
                this.resultat = "La température est de " + this.temperature + "\r\n" +
                    "La climatisation se met en route";
            }
        }

        /// <summary>
        /// Récupère le résultat / change le résultat
        /// </summary>
        public string getResultat
        {
            get
            {
                return this.resultat;
            }

            set
            {
                this.resultat = value;
            }
        }
    }
}
