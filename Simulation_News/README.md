# SIMULATION DE NEWS VIA UTILISATION DES ÉVÉNEMENTS

---------------------------------------------------------------

## DESCRIPTION

Réalisation d'une application de type _WindowsForm_ en langage C# sous **visual studio 2017** permettant de simuler des news, représentées par des Topics que l'utilisateur peut créer.
L'utilisateur peut ainsi créer et supprimer deux types d'objets :
* Les **Topics**, représenté par un nom
* Les **Personnes**, représentée égalemment par un nom

Les topics et les personnes créés par l'utilisateur sont ajoutés, respectivement dans une **TopicFactory** et une **PersonneFactory**, avec l'utilisation des [**Listes**](https://msdn.microsoft.com/fr-fr/library/6sh2ey19(v=vs.110).aspx) pour la gestion en mémoire.

* A chaque fois que l'utilisateur ajoute un **Topic** dans la TopicFactory, ou une **Personne** dans la PersonneFactory, des **événements** vont se lancer et informer toutes les **ComboBox** associées soit à l'objet **Personne**, soit à l'objet **Topic**,  écoutants cet événement (les ComboBox possède un [**handler**](https://docs.microsoft.com/fr-fr/dotnet/standard/events/) pour s'abonner à l'événement) de la création du topic. Par le biais de cet événement, les **ComboBox** se mettront à jour automatiquement.

Pour un topic précis, sélectionné à travers une **ComboBox**, l'utilisateur peut écrire une news dans une zone de texte réservée a cet effet, et valider avec un bouton. Ceci permet d'ajouter la news au topic via un événement.

Par la suite, au travers de la _PersonneFactory_ et de la _TopicFactory_, l'utilisateur peut sélectionner une personne, et l'associée à un topic quelconque. C'est comme cela que la personne recevra toutes les news concernant le topic sélectionné.

Durant tout le temps d'exécution du programme, les ComboBox seront abonnées aux différents événements des différentes Factory :

1. **_TopicFactory_**

```cs
TopicFactory tf = new TopicFactory();
tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Delete).ajouterData;
tf.onAjouterTopic += ((ComboBoxHandler)comboBox_topicAbo).ajouterData;
tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).ajouterData;
tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_topicAbo).supprimerData;
tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Delete).supprimerData;
tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).supprimerData;
```

`onAjouterTopic` représente **l'événement** d'ajout d'un topic dans la liste **l**

`onSupprimerTopic` représente **l'événement** de suppression d'un topic de la liste **l**

`ajouterData` représente **l'écouteur**, associé aux ComboBox, d'ajout d'une donnée **d**

`supprimerData` représente **l'écouteur**, associé aux ComboBox, de suppression d'une donnée **d**

---------------------------------------------------------------

## OPÉRATIONS POSSIBLES

L'utilisateur lance l'interface homme-machine représentée ci-dessous :

![](https://image.noelshack.com/fichiers/2018/10/3/1520442953-capture.png)

1. Création d'un topic
2. Création d'une personne
3. Suppression d'un topic sélectionné dans la liste déroulante associée
4. Suppression d'une personne sélectionnée dans la liste déroulante associée
5. Associé des news à un topic
6. Associé un topic à une personne (principe de l'abonnement)
7. Afficher les news en fonction de la personne sélectionné dans la liste déroulante associée

---------------------------------------------------------------

## NOTIONS UTILISÉES

* _Héritage_
* _Concepts objets_
* _Interface .NET_
* _Handlers_

---------------------------------------------------------------

## LANCEMENT

Exécuter le projet avec l'IDE `Visual Studio`

---------------------------------------------------------------

## AVANCEMENT

| **Date** | **Version** | **% d'avancement** |
|:---:|:---:|:---:|
| _07/03/2018_ | **[0.0] DEV** | **50** |

Dernière modification le _07/03/2018, 18h00_