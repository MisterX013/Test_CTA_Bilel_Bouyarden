using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;




//Ce code définit une classe "Person" qui représente une personne, 
//et une classe "PersonList" qui gère la liste des personnes. 
//La méthode "AddPerson" de la classe "PersonList" crée un nouvel objet à partir du prefab "personPrefab", 
//qui représente une personne, et affiche les informations de la personne dans le texte de l'objet.
//Pour ajouter un effet d'animation lorsque l'utilisateur supprime une personne de la liste, nous pouvons utiliser la fonction "Destroy" de Unity.



public class Person {
    public string id;
    public string firstName;
    public string lastName;
    public string email;
}

public class PersonList : MonoBehaviour {
    public GameObject personPrefab;
    public Transform content;

    public void AddPerson(Person person) {
        GameObject obj = Instantiate(personPrefab, content);
        obj.GetComponentInChildren<Text>().text = person.id + " " + person.firstName + " " + person.lastName + " " + person.email;
        
 
/* void DestroyObject(GameObject obj)
{
    // Joue l'animation pour enlever l'objet
    obj.GetComponent<Animator>().Play("RemoveAnimation");

    // Détruit l'objet après que l'animation ait joué
    Destroy(obj, 1f);
} */

    }
}


