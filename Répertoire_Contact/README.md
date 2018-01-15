# GESTION D'UN REPERTOIRE DE CONTACT

--------------------------------------

## DESCRIPTION

Réalisation d'un programme C# sous visual studio permettant de gérer une liste de contact, le but étant de ce familiariser avec :
* L'interface de développement
* Les notions du langage **C#**
* Le développement d'interface en **.NET**

Création d'un répertoire gérant des données sur des personnes. Une personne possède un nom, un prénom, une adresse et un numéro de téléphone.

Il peut y avoir plusieurs types de personne :
1. Amis, avec une propriété supplémentaire --> _**Note**_
2. Travail, avec une propriété supplémentaire --> _**Numéro de bureau**_
3. Famille, avec une propriété supplémentaire --> _**Relation familiale**_

--------------------------------------

## OPÉRATIONS POSSIBLES

* Affichage d'une personne choisie dans une liste déroulante qui affiche seulement les informations de base d'une personne dans une boite de dialogue, ainsi que le type de contact (Personne normale, Amis, Travail ou Famille).

* Ajout d'une personne
* Suppression d'une personne choisie dans la liste déroulante

**La gestion en mémoire se fait par une liste de personnes [BindingList](https://msdn.microsoft.com/fr-fr/library/ms132679(v=vs.110).aspx)**

L'interface au démarrage de l'application contient donc :
* La liste déroulante contenant les contacts déjà stockés dans la liste (aucun au démarrage).
* Un bouton d'ajout de contacts, permettant d'être redirigé vers un nouveau formulaire pour l'ajout.
* Un bouton de suppression permettant de supprimer le contact, étant actif dans la liste déroulante.

--------------------------------------

## NOTIONS UTILISÉES

* _Héritage_
* _Concepts objet_
* _Interface .NET_

--------------------------------------

## LANCEMENT

Exécuter le projet avec l'IDE `Visual Studio`