# CALCUL DE LA CONSOMMATION DE CO2 PAR DÉPLACEMENT

---------------------------------------------------------

## DESCRIPTION

Réalisation d'une application de type _WindowsForm_ en langage C# sous **visual studio 2017** permettant de calculer une consommation de [C02](https://www.dictionnaire-environnement.com/dioxyde_de_carbone_c02_ID1160.html) selon le **nombre de Kms parcourus**, le **nombre de personnes** ou encore le moyen de transport sélectionné.
Le moyen de transport choisit peut-être :
* Le bus
* La voiture
* A pied

L'application contient une unique interface permettant à l'utilisateur de renseigner ses informations et de cliquer sur le bouton **Calculer** afin d'afficher sous forme de chaines de caractères les résultats. 

Les calculs seront réalisés dans une classe Calcul, qui comprendra une méthode propre pour un type de transport choisit. L'utilisateur doit obligatoirement renseigner le nombre de kilomètres, le nombre de personnes et un ou plusieurs modes de transport, sous peine d'affichage d'un message d'erreur.

Voici les données utilisées pour les calculs :

1. _**A pied**_ :

	| Nombre de Kms | Nombre de personnes | Temps | C02 consommé
	|:---:|:---:|:---:|:---:|
	| **100** | **10** | _**20 heures**_ | _**0 gramme**_|

2. _**En voiture**_ :

	| Nombre de Kms | Nombre de personnes | Temps | C02 consommé
	|:---:|:---:|:---:|:---:|
	| **100** | **10** | _**0,77 heures**_ | _**260 grammes**_|

3. _**En bus**_ :

	| Nombre de Kms | Nombre de personnes | Temps | C02 consommé
	|:---:|:---:|:---:|:---:|
	| **100** | **10** | _**0,9 heures**_ | _**100 grammes**_|

---------------------------------------------------------

## OPÉRATIONS POSSIBLES

L'utilisateur lance l'interface homme-machine représentée ci-dessous.

![](https://image.noelshack.com/fichiers/2018/06/6/1518287829-capture.png)

* Choix du nombre de kilomètre(s)
* Choix du nombre de personne(s)
* Choix du mode de transport (possibilité de choisir les 3)

![](https://image.noelshack.com/fichiers/2018/06/6/1518288021-capture.png)

--------------------------------------

## NOTIONS UTILISÉES

* _Héritage_
* _Concepts objet_
* _Interface .NET_
* _Type [delegate](https://www.dotnetdojo.com/delegates-csharp/) (ou pointeur de fonctions)_

--------------------------------------

## LANCEMENT

Exécuter le projet avec l'IDE `Visual Studio`