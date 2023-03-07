//Je n'ai pas eu assez de temps pour le réaliser mais voici la marche a suivre pour réaliser ce projet (Source Chat GPT3)



/* Créez un nouveau projet Unity et nommez-le en fonction de vos besoins.

Créez un objet vide dans la hiérarchie et nommez-le "Circle".

Ajoutez un composant "Sprite Renderer" à l'objet "Circle".

Dans la fenêtre "Sprite Renderer", cliquez sur "Sprite" et sélectionnez un cercle dans la bibliothèque d'images. Ajustez la taille du cercle pour qu'il soit au centre de l'écran.

Créez un autre objet vide dans la hiérarchie et nommez-le "Point".

Ajoutez un composant "Sprite Renderer" à l'objet "Point".

Dans la fenêtre "Sprite Renderer", cliquez sur "Sprite" et sélectionnez un point dans la bibliothèque d'images. Ajustez la taille du point pour qu'il soit visible sur l'écran.

Ajoutez un script C# au "Point" et nommez-le "PointMovement".

Dans le script "PointMovement", créez une variable publique pour la vitesse de déplacement. */


//public float speed = 5f;



//Dans la fonction "Update", ajoutez du code pour déplacer le point vers la position de la souris. 
//Utilisez la fonction "Input.mousePosition" pour obtenir la position de la souris en pixels.
// Utilisez ensuite la fonction "Camera.ScreenToWorldPoint" pour convertir la position de la souris en une position dans l'espace 3D de Unity. 
//Enfin, utilisez la fonction "Vector3.MoveTowards" pour déplacer le point vers la position de la souris, mais en restant dans le cercle.


//Ajoutez un script C# au "Circle" et nommez-le "CircleCollision".
//Dans le script "CircleCollision", créez une variable privée pour le rayon du cercle.

//private float radius;

//Dans la fonction "Start", initialisez la variable "radius" en fonction de la taille du cercle.

//radius = GetComponent<SpriteRenderer>().bounds.size.x / 2f;

//Dans la fonction "Update", ajoutez du code pour vérifier si le point est en dehors du cercle. Si c'est le cas, déplacez le point vers le bord du cercle en utilisant la fonction "Vector3.ClampMagnitude".

//Vector3 direction = transform.position - transform.parent.position;
/* float distance = direction.magnitude;
if (distance > radius)
{
    direction = Vector3.ClampMagnitude(direction, radius);
    transform.position = transform.parent.position + direction;
} */



//Enfin, attachez les scripts "PointMovement" et "CircleCollision" aux objets "Point" et "Circle", respectivement.
//Voilà, votre projet est terminé. Vous pouvez maintenant tester le mouvement du point en bougeant la souris et en vérifiant qu'il reste à l'intérieur du cercle.





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoMathTrois : MonoBehaviour
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
