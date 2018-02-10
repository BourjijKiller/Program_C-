using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P3
{
    /**
     * Définition d'un délégué qui permet de référencer des méthodes de la classe calcul, ayant la même signature que notre fonction ci-dessous
     */

    delegate void fonction(double nbKm, double nbPersonne);
    class Calcul
    {
        /**
         * Initialisation du délégué à NULL
         */

        public fonction exec = null;
        private double temps;
        private double grammeCO2;
        private String resultat;

        /**
         * Constructeur de la classe Calcul
         */
        public Calcul()
        {
            this.temps = 0;
            this.grammeCO2 = 0.0;
        }

        /**
         * Temps de parcours et taux de CO2 envoyé dans l’atmosphère à pieds
         */
        public void calculPied(double nbKm, double nbPersonne)
        {
            this.grammeCO2 = 0.0;
            this.temps = nbKm / 5;
            this.resultat += "A pied, je vais mettre " + Math.Round(this.temps, 2) + " heure(s), je produit 0g de CO2 \r\n";

        }

        /**
         * Temps de parcours et taux de C02 envoyé dans l'atmosphère en voiture
         */
        public void calculVoiture(double nbKm, double nbPersonne)
        {
            this.grammeCO2 = 130.0;
            double nbVoiture = (nbPersonne / 5);
            this.temps = nbKm / 130;
            double C02Result = 1.3 * nbVoiture * nbKm;
            this.resultat += "En voiture, je vais mettre " + Math.Round(this.temps, 2) + " heure(s), je produit " + Math.Ceiling(C02Result) +" g de CO2 \r\n";
        }

        /**
         * Temps de parcours et taux de C02 envoyé dans l'atmosphère en car
         */
        public void calculCar(double nbKm, double nbPersonne)
        {
            this.grammeCO2 = 100.0;
            double nbBus = (nbPersonne / 40);
            this.temps = nbKm / 110;
            double C02Result = 1 * nbBus * nbKm;
            this.resultat += "En bus, je vais mettre " + Math.Round(this.temps, 2) + " heure(s), je produit " + Math.Ceiling(C02Result) + " g de CO2 \r\n";
        }

        /**
         * Méthode permettant de récupérer le résultat sous forme d'une chaine de caractères
         */
        public string toString
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
