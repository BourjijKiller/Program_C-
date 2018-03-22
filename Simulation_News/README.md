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
// Abonnement des événements sur toute les ComboBox lors de l'ajout de Topics
this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Delete).ajouterData;
this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_topicAbo).ajouterData;
this.tf.onAjouterTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).ajouterData;

// Abonnement des événements sur toute les ComboBox lors de la suppression de Topics
this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_topicAbo).supprimerData;
this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Delete).supprimerData;
this.tf.onSupprimerTopic += ((ComboBoxHandler)comboBox_Topic_Envoyer).supprimerData;
```

`onAjouterTopic` représente **l'événement** d'ajout d'un topic dans la liste **l**

`onSupprimerTopic` représente **l'événement** de suppression d'un topic de la liste **l**

`ajouterData` représente **l'écouteur**, associé aux ComboBox, d'ajout d'une donnée **d**

`supprimerData` représente **l'écouteur**, associé aux ComboBox, de suppression d'une donnée **d**

Afin d'afficher les saisies directement dans les ComboBox, on utilise un getter afin de récupérer le nom du Topic dans la _TopicFactory_ :

```cs
public string topic
{
    get
    {
        return this.nom;
    }

    set
    {
        this.nom = value;
    }
}

this.comboBox_Topic_Delete.DisplayMember = "topic";
this.comboBox_topicAbo.DisplayMember = "topic";
this.comboBox_Topic_Envoyer.DisplayMember = "topic";
```

2. **_PersonneFactory_**

```cs
// Abonnement des événements sur toute les ComboBox lors de l'ajout d'une personne
this.pf.onAjouterPersonne += ((ComboBoxHandler)comboBox_Personne_Delete).ajouterData;
this.pf.onAjouterPersonne += ((ComboBoxHandler)comboBox_personneAbo).ajouterData;
this.pf.onAjouterPersonne += ((ComboBoxHandler)comboBox_Personne_Envoyer).ajouterData;

// Abonnement des événements sur toute les ComboBox lors de la suppression d'une personne
this.pf.onSupprimerPersonne += ((ComboBoxHandler)comboBox_Personne_Delete).supprimerData;
this.pf.onSupprimerPersonne += ((ComboBoxHandler)comboBox_personneAbo).supprimerData;
this.pf.onSupprimerPersonne += ((ComboBoxHandler)comboBox_Topic_Envoyer).supprimerData;
```

`onAjouterPersonne` représente **l'événement** d'ajout d'une personne dans la liste **l**

`onSupprimerPersonne` représente **l'événement** de suppression d'une personne de la liste **l**

Les méthodes `ajouterData` et `supprimerData` ont la même fonction que pour la **TopicFactory**

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

Lorsque l'utilisateur ajoute un topic ou une personne, les ComboBox écoutent et affiche le résultat en fonction de l'événement déclenché :

![](https://image.noelshack.com/fichiers/2018/11/7/1521404451-capture.png)

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
| _18/03/2018_ | **[0.1] DEV** | **70** |
| _22/03/2018_ | **[1.0] PROD** | **100**|

### [TERMINÉ]

Dernière modification le _22/03/2018, 01h08_