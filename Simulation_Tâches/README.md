# SIMULATION DE TÂCHES PAR DIVERS TYPES DE PERSONNES

---------------------------------------------------------

## DESCRIPTION

Réalisation d'une application de type _WindowsForm_ en langage C# sous **visual studio 2017** permettant de simuler l'exécution de tâches par des personnes, que l'utilisateur peut créer, en utilisant les pointeurs de fonctions, ou plus communément appellé _**Delegage (Délégués)**_.
Chaque personne créé possède un nom et un prénom.
Dans cette application, l'utilisateur peut créer 2 types de personne :
* **Les administrateurs**
* **Les ouvriers**

Chaque personne, que ce soit les administrateurs ou les ouvriers, peuvent effectuer des tâches :
1. _Les ouvriers peuvent effectuer la tâche d’assembler (tâche 1) et celle de désassembler (tâche 2)_
2. _Les administrateurs peuvent classer (tâche 1) et contacter (tâche 2)_

L'application contient une unique interface permettant à l'utilisateur de créer autant d'ouvriers que d'administrateurs que possibles, puis de choisir une personne présente et lui affecter les tâches pour renvoyer le résultat sous forme d'une chaîne de caractères dans une [TextBox](https://en.wikipedia.org/wiki/Text_box).

Une personne est créée par l'intermédiaire d'une classe Personne, mais dans cette application, l'utilisateur peut créer soit un **Ouvrier**, soit un **Administrateur**. Il y aura donc une classe Ouvrier et une classe Administrateur, qui, avec le principe de _**l'héritage**_, hériteront de toutes les méthodes et attributs de la classe **Personne**.

---------------------------------------------------------

## OPÉRATIONS POSSIBLES

L'utilisateur lance l'interface homme-machine représentée ci-dessous :

![](https://image.noelshack.com/fichiers/2018/08/4/1519310388-capture1.png)

Il peut donc :
* Créer autant d'ouvriers que d'administrateurs, qui seront affichés par la suite dans une ComboBox.
* Afficher les tâches selon la personne sélectionnée dans la ComboBox

![](https://image.noelshack.com/fichiers/2018/08/4/1519310388-capture2.png)

**La gestion en mémoire se fait par une liste de personnes [BindingList](https://msdn.microsoft.com/fr-fr/library/ms132679(v=vs.110).aspx)**

--------------------------------------

## NOTIONS UTILISÉES

* _Héritage_
* _Concepts objet_
* _Interface .NET_
* _Type [delegate](https://www.dotnetdojo.com/delegates-csharp/) (ou pointeur de fonctions)_
* _Classe et méthodes abstraite_

--------------------------------------

## LANCEMENT

Exécuter le projet avec l'IDE `Visual Studio`