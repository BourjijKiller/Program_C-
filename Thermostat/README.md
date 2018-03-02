# GESTION DE TEMPÉRATURE VIA UTILISATION DES ÉVÉNEMENTS

-------------------------------------------------------------------------

## DESCRIPTION

Réalisation d'une petite application de type _WindowsForm_ en langage C# sous **visual studio 2017** permettant de simuler, en fonction de la température saisie par l'utilisateur, un démarrage ou un arrêt du chauffage ou de la climatisation. Cependant, ces actions, utilisant le principe **des délégués (Delegate)**, sont déclenchées par l'utilisation des événements [_**Handler**_](https://docs.microsoft.com/fr-fr/dotnet/standard/events/) qui représente l'écoute d'un événement.
Il existe 2 types de scénarios :
1. Si la température saisie par l'utilisateur est strictement inférieure à _20 degrés_
	* Le radiateur, représenté par une classe, se met en route. Cet événement est indiqué à l'utilisateur dans une zone de texte réservée.
2. Si la température saisie par l'utilisateur est supérieure ou égale à _20 degrés_
	* La climatisation, représentée par une classe, se met en route. Cet événement est indiqué à l'utilisateur dans une zone de texte réservée.

L'appel de la méthode qui affiche le démarrage de la climatisation, respectivement de la classe **Climatisation**, ou du radiateur, respectivement de la classe **Radiateur**, ne se fait pas classiquement, en testant la valeur saisie par l'utilisateur et, en fonction de cette saisie, affiche le résultat. A la place, on utilise **le déclenchement d'événements (définition d'une fonction qui lancera effectivement l'événement)**.

Au chargement de l'application, les deux classes citées ci-dessus vont s'abonner à l'événement :

```cs
Thermostat thermostat = new Thermostat();
Climatisation climatisation = new Climatisation();
Radiateur radiateur = new Radiateur();

thermostat.onTemperatureChange += radiateur.onTemperatureChanged;
thermostat.onTemperatureChange += climatisation.onTemperatureChanged;
```

**OnTemperatureChange est l’événement**

-------------------------------------------------------------------------

## OPÉRATIONS POSSIBLES

L'utilisateur lance l'interface homme-machine représentée ci-dessous :

![](https://image.noelshack.com/fichiers/2018/09/5/1520024887-cap1.png)

En fonction de la température saisie, l'application lui indique si le radiateur ou la climatisation se met en route, par le déclenchement des événements.

![](https://image.noelshack.com/fichiers/2018/09/5/1520024887-cap2.png)

-------------------------------------------------------------------------

## NOTIONS UTILISÉES

* _Héritage_
* _Concepts objet_
* _Interface .NET_
* _Type [delegate](https://www.dotnetdojo.com/delegates-csharp/) (ou pointeur de fonctions)_
* _Handlers_

-------------------------------------------------------------------------

## LANCEMENT

Exécuter le projet avec l'IDE `Visual Studio`