using System.Collections.Generic;
using UnityEngine;


//Ce code est un script en C# pour un échange de cadeaux entre des participants. Le script contient une classe principale "GiftExchangeScript" et une classe secondaire "Participant".
//La classe principale initialise une liste de participants, chacun étant défini par un identifiant unique, un e-mail et un nom et prénom. 
//Le script utilise également une méthode pour générer des indices aléatoires, qui sont utilisés pour assigner à chaque participant un autre participant aléatoire à qui offrir un cadeau.
//Enfin, le script imprime le nom de chaque participant et le nom de la personne à qui il ou elle doit offrir un cadeau.

//Cet algorithme utilise une approche simple de tirage au sort aléatoire. Nous stockons les données des participants dans une classe Participant, 
//puis nous les stockons dans une liste. Nous avons également un dictionnaire assignments pour stocker l'assignation des cadeaux.
//Nous commençons par créer une liste d'indices de participants, puis nous itérons sur chaque participant et sélectionnons un index aléatoire dans la liste d'indices restants. 
//Nous supprimons ensuite cet index de la liste pour éviter qu'un participant ne reçoive plus d'un cadeau. 
//Nous assignons ensuite le participant sélectionné à l'index aléatoire au participant actuel dans le dictionnaire assignments.

//La complexité de cet algorithme est O(n) pour la génération des assignations, 
//car nous devons itérer sur chaque participant. Cependant, comme nous effectuons un tirage aléatoire pour chaque participant, 
//il est possible que cet algorithme prenne plus de temps pour générer des assignations dans certains cas. Dans l'ensemble, 
//cela devrait fonctionner assez bien pour un petit nombre de participants, comme dans ce cas avec seulement 47 participants. 
//Si vous aviez besoin d'optimiser les performances pour un grand nombre de participants, vous pourriez envisager une autre approche.


//Pour réaliser ce test, je me suis aidé de ChatGPT3. Sans cela, je n'y serais jamais arrivé.


public class GiftExchangeScript : MonoBehaviour
{
    private List<Participant> participants;

    void Start()
    {
        participants = new List<Participant>()
        {
            new Participant("1", "email1@test.com", "John", "Doe"),
            new Participant("2", "email2@test.com", "Jane", "Doe"),
            new Participant("3", "email3@test.com", "Bob", "Smith"),            
            new Participant("4", "email4@test.com", "Alice", "Johnson"),
            new Participant("5", "email5@test.com", "Mike", "Williams"),
            new Participant("6", "email6@test.com", "Laura", "Lee"),
            new Participant("7", "email7@test.com", "David", "Brown"),
            new Participant("8", "email8@test.com", "Emily", "Davis"),
            new Participant("9", "email9@test.com", "Tom", "Wilson"),
            new Participant("10", "email10@test.com", "Amy", "Anderson"),
            new Participant("11", "email11@test.com", "Jason", "Taylor"),
            new Participant("12", "email12@test.com", "Karen", "Clark"),
            new Participant("13", "email13@test.com", "Brian", "Young"),
            new Participant("14", "email14@test.com", "Melissa", "Hall"),
            new Participant("15", "email15@test.com", "Scott", "Allen"),
            new Participant("16", "email16@test.com", "Jennifer", "Green"),
            new Participant("17", "email17@test.com", "Alex", "Evans"),
            new Participant("18", "email18@test.com", "Samantha", "Carter"),
            new Participant("19", "email19@test.com", "Kevin", "Brown"),
            new Participant("20", "email20@test.com", "Linda", "White"),
            new Participant("21", "email21@test.com", "Steve", "King"),
            new Participant("22", "email22@test.com", "Hannah", "Baker"),
            new Participant("23", "email23@test.com", "Eric", "Garcia"),
            new Participant("24", "email24@test.com", "Michelle", "Lopez"),
            new Participant("25", "email25@test.com", "Tony", "Rivera"),
            new Participant("26", "email26@test.com", "Rachel", "Morgan"),
            new Participant("27", "email27@test.com", "Mark", "Rossi"),
            new Participant("28", "email28@test.com", "Katie", "Moore"),
            new Participant("29", "email29@test.com", "Tim", "Cook"),
            new Participant("30", "email30@test.com", "Cindy", "Jones"),
            new Participant("31", "email31@test.com", "Ben", "Nelson"),
            new Participant("32", "email32@test.com", "Tina", "Nguyen"),
            new Participant("33", "email33@test.com", "Erik", "Peterson"),
            new Participant("34", "email34@test.com", "Andrea", "Sanchez"),
            new Participant("35", "email35@test.com", "Marcus", "Stewart"),
            new Participant("36", "email36@test.com", "Carla", "Ramirez"),
            new Participant("37", "email37@test.com", "Billy", "TheKid"),
            new Participant("38", "email38@test.com", "Mahmoud", "PassPass"),
            new Participant("39", "email39@test.com", "Marie", "CoucheToiLa"),
            new Participant("40", "email40@test.com", "Donald", "Trump"),
            new Participant("41", "email41@test.com", "Vladimir", "Poutine"),
            new Participant("42", "email42@test.com", "Bouroucha", "TapTap"),
            new Participant("43", "email43@test.com", "Lila", "Melila"),
            new Participant("44", "email44@test.com", "Jack", "Bauer"),
            new Participant("45", "email45@test.com", "Houssama", "Benladen"),
            new Participant("46", "email46@test.com", "Trump", "TuTesTrumper"),
            new Participant("47", "email47@test.com", "Vazy", "Francky"),
        };

        int[] randomIndices = GetRandomIndices(participants.Count);

        for (int i = 0; i < participants.Count; i++)
        {
            participants[i].giftReceiver = participants[randomIndices[i]].firstName + " " + participants[randomIndices[i]].lastName;
        }

        // Print participants and their gift receivers
        foreach (var participant in participants)
        {
            Debug.Log(participant.firstName + " " + participant.lastName + " has to offer a gift to " + participant.giftReceiver);
        }
    }

    private int[] GetRandomIndices(int length)
    {
        int[] indices = new int[length];

        for (int i = 0; i < length; i++)
        {
            indices[i] = i;
        }

        for (int i = 0; i < length; i++)
        {
            int temp = indices[i];
            int randomIndex = Random.Range(i, length);
            indices[i] = indices[randomIndex];
            indices[randomIndex] = temp;
        }

        return indices;
    }
}

public class Participant
{
    public string uuid;
    public string email;
    public string firstName;
    public string lastName;
    public string giftReceiver;

    public Participant(string uuid, string email, string firstName, string lastName)
    {
        this.uuid = uuid;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
    }
}

 
 


