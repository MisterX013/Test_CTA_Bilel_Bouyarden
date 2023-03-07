//Qu'est-ce qu'un VCS ?

//VCS est l'acronyme de "Version Control System" (système de contrôle de version en français). 
//Il s'agit d'un outil logiciel qui permet de gérer les modifications apportées à un ensemble de fichiers au fil du temps.
//Les VCS permettent aux développeurs de travailler ensemble sur un même projet en permettant de stocker et de gérer différentes versions des fichiers.
// Ils offrent également des fonctionnalités pour suivre l'historique des modifications, fusionner des versions et collaborer efficacement sur des projets de développement logiciel.
//Les VCS sont largement utilisés dans l'industrie du développement de logiciels pour aider les équipes à gérer leur code source de manière efficace et à collaborer sur des projets de grande envergure.
// Certains des VCS les plus populaires sont Git, SVN, Mercurial et Perforce.


//Pourquoi est-il important d'utiliser un VSC ?

//Dans l'ensemble, l'utilisation d'un VCS peut améliorer l'efficacité, la collaboration et la sécurité de l'équipe de développement,
//tout en permettant une meilleure gestion des versions et un suivi de l'historique des modifications.


//Quel VCS utilisez-vous habituellement ?
//GitHub


//Quel workflow auriez-vous dans une équipe de 5 programmeurs ?

/* Il existe plusieurs workflows possibles dans une équipe de 5 programmeurs. 
Le choix dépendra en grande partie des préférences et des exigences de l'équipe. 
Cependant, voici un exemple de workflow communément utilisé dans les équipes de développement :

Création d'une branche principale (main branch) : Cette branche contiendra la version la plus récente et la plus stable du code.

Création de branches de fonctionnalités (feature branches) : 
Chaque développeur créera une branche de fonctionnalités pour travailler sur une fonctionnalité spécifique du projet. Les branches de fonctionnalités sont créées à partir de la branche principale.

Travailler sur les branches de fonctionnalités :
Chaque développeur travaille sur sa propre branche de fonctionnalités, en faisant régulièrement des commits pour enregistrer les modifications apportées.

Fusionner les branches de fonctionnalités : 
Une fois qu'une fonctionnalité est terminée et testée, le développeur crée une demande de fusion (pull request)
 pour demander à l'équipe de revoir et d'approuver ses modifications. Une fois que la demande de fusion est approuvée, la branche de fonctionnalités est fusionnée avec la branche principale.

Intégration continue (Continuous Integration) : 
Les modifications apportées aux branches de fonctionnalités sont régulièrement intégrées à la branche principale. Cette étape permet de vérifier
 que les modifications apportées ne causent pas de conflits ou de problèmes dans le code.

Déploiement : Une fois que la branche principale a été testée et validée, elle est déployée en production.

Ce workflow permet à chaque développeur de travailler sur sa propre branche de fonctionnalités tout en assurant que le code reste stable et cohérent. 
La revue de code et l'intégration continue permettent également de détecter rapidement les problèmes et de les résoudre avant qu'ils ne deviennent trop importants. */




// nous supposerons que Git est notre VCS. Comment éviter les commits de fusion et conserver un historique linéaire ?

//Pour éviter les commits de fusion et conserver un historique linéaire avec Git, 
//vous pouvez utiliser la méthode de rebasage (rebase en anglais). 
//Le rebasage consiste à prendre une branche et à la "remonter" sur une autre branche, en modifiant l'historique des commits
// pour que la branche rebasée semble être issue directement de la branche cible.



// Pourquoi est-il important d'avoir un historique linéaire et dans quel cas êtes-vous autorisé à le casser (et donc à avoir un commit de fusion) ?

/* Un historique linéaire est important pour plusieurs raisons :
Il est plus facile à comprendre : un historique linéaire montre clairement l'ordre dans lequel les modifications ont été apportées, ce qui facilite la compréhension de l'historique du projet.
Il facilite la recherche de bugs : avec un historique linéaire, il est plus facile de retracer les modifications qui ont introduit un bug.
Il facilite le travail en équipe : un historique linéaire permet aux développeurs de travailler sur des branches différentes sans avoir à fusionner leur travail, ce qui peut causer des conflits.
Cependant, il peut être nécessaire de casser l'historique linéaire et de créer un commit de fusion dans certaines situations, par exemple :
Lorsqu'une branche a été abandonnée pendant un certain temps et que de nombreux commits ont été effectués sur une autre branche : dans ce cas, 
il peut être plus facile de fusionner les deux branches, même si cela crée un commit de fusion.
Lorsque plusieurs développeurs ont travaillé sur la même partie du code en même temps et que leurs modifications doivent être fusionnées : dans ce cas, 
il peut être nécessaire de créer un commit de fusion pour rassembler toutes les modifications.
Lorsque vous fusionnez une branche de fonctionnalités avec une branche principale et que vous souhaitez conserver
 l'historique de la branche de fonctionnalités tout en la fusionnant avec la branche principale :
 dans ce cas, un commit de fusion peut être utilisé pour indiquer que la branche de fonctionnalités a été fusionnée avec la branche principale.
En général, il est préférable d'éviter les commits de fusion autant que possible pour maintenir un historique linéaire clair.
 Cependant, dans certaines situations, un commit de fusion peut être nécessaire pour fusionner les modifications de plusieurs branches.
 */



//Qu'est-ce que la cueillette des cerises ?


/* La cueillette des cerises (cherry-picking en anglais) est une technique utilisée dans les systèmes de contrôle de version pour sélectionner des commits spécifiques
 à partir d'une branche et les appliquer à une autre branche.
En utilisant la cueillette des cerises, vous pouvez appliquer des modifications spécifiques à une branche sans avoir à fusionner l'ensemble de la branche. 
Cette technique est utile dans les situations où vous avez besoin de certaines modifications, mais pas de toutes les modifications d'une branche.
La cueillette des cerises est effectuée en identifiant les commits que vous souhaitez récupérer et en les appliquant à la branche cible. 
Pour ce faire, vous pouvez utiliser la commande git cherry-pick suivi de l'identifiant du commit que vous souhaitez récupérer. Cette commande applique les modifications
 du commit sélectionné sur la branche actuelle.
Il est important de noter que la cueillette des cerises peut causer des conflits si les modifications que vous essayez de récupérer dépendent d'autres modifications
 qui ne sont pas présentes dans la branche cible. Dans ce cas,
vous devrez résoudre les conflits manuellement en apportant les modifications nécessaires.
La cueillette des cerises peut être utilisée pour appliquer des corrections de bugs spécifiques ou des modifications de fonctionnalités à une branche sans avoir à fusionner l'ensemble de la branche. 
Cela permet aux développeurs de travailler de manière plus efficace en n'appliquant que les modifications nécessaires à chaque branche
 */



//Qu'est-ce qu'un rebasage ? Quelle est la différence entre un rebase entre deux branches et un pull-rebase ?


/* Le rebasage (rebase en anglais) est une technique utilisée dans les systèmes de contrôle de version pour réécrire l'historique d'une branche en la basant sur une autre branche.
Lorsque vous effectuez un rebasage, Git prend tous les commits de la branche que vous voulez rebaser et les applique à la branche cible, en les plaçant à la fin de l'historique de la branche cible.
 Cela crée un historique linéaire et facilite la compréhension de l'historique du projet.
La principale différence entre un rebase entre deux branches et un pull-rebase est le moment où le rebasage est effectué.
 Avec un rebase entre deux branches, vous réécrivez l'historique de la branche en fonction de la branche cible avant de fusionner les deux branches. 
 Avec un pull-rebase, vous récupérez d'abord les modifications de la branche cible et vous réécrivez ensuite l'historique de votre branche en fonction de la branche cible.
En d'autres termes, lors d'un pull-rebase, vous récupérez d'abord les modifications de la branche cible en effectuant un "pull" (récupération des modifications)
 puis vous effectuez un rebasage pour réécrire l'historique de votre branche en fonction de la branche cible. Cela permet de maintenir un historique linéaire
  tout en intégrant les modifications de la branche cible.
En résumé, la principale différence entre un rebase entre deux branches et un pull-rebase est le moment où le rebasage est effectué.
 Dans les deux cas, le but est de maintenir un historique linéaire et de faciliter la compréhension de l'historique du projet.
 */


//Qu'est-ce qu'une poussée de force ? Quand faut-il l'utiliser ou non ? Quelles sont les conséquences?

 
/* Une poussée de force (force push en anglais) est une commande Git qui permet d'écraser les modifications existantes sur une branche distante 
avec des modifications locales. Cela signifie que toutes les modifications sur la branche distante seront perdues et remplacées par les modifications locales.
La poussée de force doit être utilisée avec précaution, car elle peut causer des pertes de données si elle est mal utilisée. En général, il est déconseillé
 d'utiliser une poussée de force dans les situations suivantes :
Lorsque vous travaillez sur une branche partagée avec d'autres collaborateurs, car cela peut entraîner la perte de leurs modifications.
Lorsque vous travaillez sur une branche principale (comme master ou main), car cela peut entraîner la perte de toutes les modifications précédentes et perturber l'historique du projet.
Cependant, il y a des situations où l'utilisation d'une poussée de force est appropriée, comme par exemple :
Lorsque vous avez créé une branche de travail pour vous-même et que vous êtes le seul à travailler dessus.
Lorsque vous avez accidentellement poussé des modifications erronées sur une branche distante et que vous souhaitez les corriger.
Les conséquences d'une poussée de force sont potentiellement graves. En effet, toutes les modifications sur la branche distante seront remplacées
 par les modifications locales, ce qui peut causer la perte de données. De plus, cela peut perturber l'historique du projet et rendre difficile la compréhension de l'évolution du code.
En résumé, la poussée de force est une commande à utiliser avec précaution et uniquement dans des situations spécifiques. Il est 
important de comprendre les conséquences de cette commande avant de l'utiliser et de prendre les précautions nécessaires pour éviter la perte de données ou la perturbation de l'historique du projet.

 */



//Qu'est-ce que LF et CRLF ? Que devez-vous utiliser et pourquoi ?

/* LF (Line Feed) et CRLF (Carriage Return + Line Feed) sont des caractères utilisés pour représenter la fin de ligne dans les fichiers texte.
LF est utilisé dans les systèmes basés sur Unix (comme Linux et macOS), tandis que CRLF est utilisé dans les systèmes basés sur Windows.
Le choix entre LF et CRLF peut avoir des conséquences lors du partage de fichiers texte entre des systèmes différents. Si un fichier
 texte contenant des LF est ouvert dans un éditeur de texte sur un système Windows, il peut apparaître comme une seule ligne, 
 car les retours à la ligne ne sont pas correctement interprétés. De même, si un fichier texte contenant des CRLF est ouvert dans un éditeur de texte sur un système basé sur Unix, 
 il peut apparaître avec des caractères supplémentaires à la fin de chaque ligne.
Le choix entre LF et CRLF dépend donc des conventions du système sur lequel vous travaillez et du contexte dans lequel
 vous partagez vos fichiers texte. Si vous travaillez sur un système basé sur Unix, il est recommandé d'utiliser LF. Si vous travaillez sur un système basé sur Windows, 
 il est recommandé d'utiliser CRLF.
Cependant, de plus en plus d'outils et de technologies prennent en charge les deux types de caractères de fin de ligne, ce qui réduit les problèmes d'incompatibilité. 
Par exemple, Git prend en charge les deux types de caractères de fin de ligne et peut les convertir automatiquement en fonction de la configuration du système.
En résumé, le choix entre LF et CRLF dépend des conventions du système sur lequel vous travaillez et du contexte dans lequel vous partagez vos fichiers texte. 
Il est important de comprendre les différences entre les deux types de caractères et de prendre en compte les problèmes d'incompatibilité potentiels lors de la collaboration sur des fichiers texte.

 */



//Quels caractères (y compris la casse) recommandez-vous dans votre convention de dénomination ?


/* La convention de dénomination utilisée dépend généralement de l'environnement et des préférences de l'équipe de développement. Cependant, 
il est important d'utiliser une convention cohérente et facilement compréhensible par tous les membres de l'équipe.
Voici quelques recommandations générales pour la convention de dénomination :
Utiliser des noms significatifs et descriptifs pour les fichiers, les dossiers, les variables et les fonctions.
Utiliser une casse cohérente pour les noms de fichiers et de dossiers. Par exemple, certains préfèrent la convention 
camelCase (première lettre en minuscule, les mots suivants en majuscule) tandis que d'autres préfèrent snake_case (tous les mots en minuscule, séparés par des underscores).
Utiliser des noms en minuscules pour les fichiers et les dossiers, car certains systèmes de fichiers sont sensibles à la casse.
Éviter les noms trop longs qui peuvent devenir difficiles à lire ou à écrire.
Éviter les caractères spéciaux, les espaces ou les accents dans les noms de fichiers et de dossiers, car ils peuvent causer des problèmes lors de la saisie ou du partage de fichiers.
En résumé, il est important d'utiliser une convention de dénomination cohérente et facilement compréhensible par tous les membres de l'équipe. 
Les recommandations générales incluent l'utilisation de noms significatifs et descriptifs, une casse cohérente, des noms en minuscules et l'évitement de caractères spéciaux
ou d'espaces dans les noms de fichiers et de dossiers.
 */





//                                       VI - Divers


//Comment gérez-vous vos identifiants ?

//Vérification a 2 facteurs
//Utilisation des mots de passe forts et uniques pour chaque compte
//Utilisation d'un gestionnaire de mots de passe pour stocker les identifiants de manière sécurisée


//Utilisez-vous des variables d'environnement et pourquoi ?

/* En résumé, les variables d'environnement sont un outil utile pour stocker des informations spécifiques à l'environnement 
d'exécution et sont couramment utilisées dans le développement logiciel pour stocker des données sensibles, configurer l'environnement et simplifier
la gestion des pipelines d'intégration continue/déploiement continu.
 */


//Comment vous assurez-vous que votre projet est suffisamment petit pour être déployé sur des magasins et suffisamment léger pour fonctionner sur des appareils bas de gamme ?

/* Utiliser des outils d'analyse de code pour identifier les parties du code qui sont volumineuses ou qui pourraient être optimisées. 
Des outils comme SonarQube ou CodeClimate peuvent aider à identifier les zones du code qui sont les plus volumineuses et les plus complexes.
Éviter d'inclure des bibliothèques et des dépendances inutiles dans le projet. Chaque bibliothèque ou dépendance incluse peut augmenter la taille de l'application et la rendre plus complexe à gérer.
Optimiser les images, les fichiers CSS et JS pour réduire leur taille. Des outils tels que ImageOptim ou TinyPNG peuvent aider à réduire la taille des images, 
tandis que des outils tels que Gulp ou Grunt peuvent aider à minimiser les fichiers CSS et JS.
Éviter les fonctionnalités lourdes qui pourraient ralentir l'application sur les appareils bas de gamme. 
Par exemple, éviter les animations complexes ou les fonctionnalités qui nécessitent beaucoup de ressources.
Tester régulièrement l'application sur une variété d'appareils et de navigateurs pour identifier les problèmes de performance et d'optimisation. 
Les tests de performance doivent être effectués sur une variété de périphériques, y compris les appareils bas de gamme, pour identifier les problèmes potentiels.
En résumé, pour assurer que le projet est suffisamment petit pour être déployé sur des magasins et suffisamment léger pour fonctionner sur des appareils bas de gamme, 
il est important d'utiliser des outils d'analyse de code, d'éviter les bibliothèques et les dépendances inutiles, d'optimiser les images et les fichiers CSS et JS, 
d'éviter les fonctionnalités lourdes et de tester régulièrement l'application sur une variété d'appareils et de navigateurs.
 */


//Qu'est-ce que MVC ? Comment l'implémenteriez-vous dans votre projet Unity ?

/* MVC (Modèle-Vue-Contrôleur) est un modèle d'architecture logicielle qui est couramment utilisé dans le développement de logiciels. 
Il permet de séparer les préoccupations en divisant une application en trois parties : le modèle, la vue et le contrôleur.

Le modèle contient la logique métier et les données de l'application.
La vue représente l'interface utilisateur de l'application.
Le contrôleur fait le lien entre le modèle et la vue, en gérant les entrées de l'utilisateur et les interactions avec le modèle.
Dans un projet Unity, l'architecture MVC peut être implémentée de la manière suivante :
Le modèle : Les classes de données et de logique métier sont regroupées dans cette partie de l'architecture. 
Elles sont souvent stockées dans des scripts C# qui peuvent être placés dans un dossier spécifique du projet. 
Par exemple, vous pouvez stocker les scripts de données telles que les caractéristiques du joueur ou les informations de niveau dans cette partie.
La vue : Les éléments visuels tels que les menus, les boutons et les images de l'interface utilisateur sont regroupés dans cette partie de l'architecture. 
Ils peuvent être placés dans des scènes Unity ou des préfabs. Par exemple, vous pouvez stocker les éléments visuels de votre menu principal dans cette partie.
Le contrôleur : Cette partie de l'architecture Unity est responsable de gérer les interactions entre le modèle et la vue. 
Les scripts de contrôleurs sont souvent liés à des objets de jeu ou des préfabs et ils sont responsables de recevoir les entrées de l'utilisateur et de mettre à jour le modèle en conséquence. 
Par exemple, vous pouvez stocker les scripts qui gèrent les interactions du joueur avec le menu principal dans cette partie.
En implémentant l'architecture MVC dans un projet Unity, vous pouvez améliorer la maintenabilité et la flexibilité de votre code. 
Les modifications peuvent être apportées facilement à chaque partie sans avoir à toucher aux autres parties de l'application. Cela permet également de faciliter les tests unitaires et l'optimisation des performances.
 */



//Qu'est-ce que l'injection de dépendance ? L'avez-vous déjà utilisé et comment ?

/* L'injection de dépendance est un concept clé en programmation orientée objet et dans la conception de logiciels en général. 
Il s'agit d'un principe qui consiste à définir des dépendances entre des classes ou des modules d'une application, 
afin de permettre une meilleure séparation des préoccupations et une meilleure modularité du code.
Concrètement, l'injection de dépendance permet de fournir à une classe ou à un module les dépendances dont il a besoin, 
plutôt que de les créer directement dans la classe elle-même. Cela peut être fait de plusieurs manières, telles que la 
création d'instances de classe à partir de constructeurs, de propriétés ou de méthodes.
L'utilisation de l'injection de dépendance peut faciliter la maintenance du code, améliorer la testabilité et permettre une plus grande flexibilité en termes de gestion des dépendances.
J'ai utilisé l'injection de dépendance dans plusieurs projets, notamment avec le framework ASP.NET Core qui utilise nativement l'injection de dépendance. Dans un projet ASP.NET Core, 
j'ai défini des services dans le conteneur d'injection de dépendance, qui étaient ensuite injectés dans les contrôleurs et les classes de services. Cela permettait une meilleure modularité du code, 
une meilleure séparation des préoccupations et une facilité de test.
J'ai également utilisé des bibliothèques tierces comme Autofac pour gérer l'injection de dépendance dans des projets de bureau et des applications mobiles. 
Cela m'a permis de gérer facilement les dépendances entre les différentes parties de l'application et de faciliter la maintenance du code.
 */


//Qu'est-ce que Linq ? L'utilisez-vous ?

/* LINQ (Language Integrated Query) est une extension du langage de programmation C# qui permet d'effectuer des requêtes sur 
des sources de données telles que des tableaux, des listes, des collections, des bases de données et des services web, à l'aide d'une syntaxe familière et expressive.
LINQ permet de manipuler des données en utilisant des opérations de requête telles que Select, Where, OrderBy, GroupBy, Join, etc., 
qui sont similaires à celles utilisées dans les requêtes SQL. La syntaxe LINQ utilise des expressions lambda et des méthodes d'extension 
pour fournir une syntaxe fluide et expressive pour manipuler les données.
Personnellement, j'ai utilisé LINQ dans plusieurs projets C# pour effectuer des opérations de requête sur des collections de données en mémoire. 
Cela m'a permis d'écrire du code plus expressif et plus lisible, et d'effectuer des requêtes complexes de manière plus simple et plus efficace.
Par exemple, dans un projet de traitement de données financières, j'ai utilisé LINQ pour filtrer les 
transactions financières en fonction de divers critères tels que la date, le montant, le type de transaction, etc. J'ai également utilisé LINQ 
pour effectuer des opérations de regroupement et d'agrégation pour calculer les statistiques financières.
Dans l'ensemble, LINQ est un outil très utile pour manipuler des données en C# et peut rendre le code plus lisible et plus facile à comprendre.
 */


 //Quelle est la différence entre un graphique et un arbre ?

/* Un graphique et un arbre sont deux structures de données couramment utilisées en informatique, mais ils diffèrent dans leur organisation et leur utilisation.
Un graphique est une structure de données qui représente un ensemble d'objets (appelés nœuds ou sommets) reliés par des liens (appelés arêtes ou arcs). 
Les graphes peuvent être utilisés pour représenter une variété de relations, telles que les réseaux sociaux, les chemins de navigation sur un site web, 
les relations de dépendance entre les modules d'un programme, etc. Les graphes peuvent être orientés ou non orientés, pondérés ou non pondérés.
Un arbre est une structure de données qui représente une hiérarchie de données. Les arbres sont constitués de nœuds reliés entre eux par 
des liens orientés (appelés branches) de telle sorte qu'il n'y ait pas de cycle dans la structure. Les arbres sont couramment utilisés 
pour organiser des données de manière hiérarchique, telle que l'organisation d'un système de fichiers, la hiérarchie des menus dans une application, etc.
La principale différence entre les graphes et les arbres est que les graphes peuvent avoir des cycles 
(c'est-à-dire qu'un nœud peut être atteint à partir d'un autre en suivant un chemin qui revient à un nœud déjà visité), 
tandis que les arbres ne peuvent pas en avoir. Les arbres sont donc une sous-catégorie de graphes qui ont des propriétés spécifiques.
En résumé, les graphes et les arbres sont deux structures de données différentes utilisées pour représenter des relations entre des objets, 
mais les arbres sont une sous-catégorie spécifique de graphes qui ont des propriétés particulières, notamment l'absence de cycles.
 */


//A quels jeux vidéo joues-tu ?

//Call of Duty
//Zelda
//Metroid
//Resident evil
//Cross the Ages (Bien sure)
//......ect la liste est long

// Avez-vous déjà contribué à des projets open source ou à des projets communautaires (y compris des logiciels tiers autour des jeux vidéo) ? Si oui, lesquelles ?

//Non Jamais


















using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
