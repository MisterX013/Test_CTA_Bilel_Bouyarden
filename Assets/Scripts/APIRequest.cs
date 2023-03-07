using UnityEngine;
using UnityEngine.Networking;
using System.Collections;



//Ce code envoie une requête au site internet, attend la réponse et affiche les données dans la console de Unity. 
//Il faut l'adapter pour récupérer les informations sur les personnes et les afficher dans la liste que nous avons créée.



public class APIRequest : MonoBehaviour {

    IEnumerator Start() {
        UnityWebRequest www = UnityWebRequest.Get("https://random-data-api.com/api/users/random_user?size=5");
        yield return www.SendWebRequest();

        if(www.result == UnityWebRequest.Result.Success) {
            string data = www.downloadHandler.text;
            Debug.Log(data);
        }
        else {
            Debug.Log("Error: " + www.error);
        }
    }
}
