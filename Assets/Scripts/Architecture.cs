// pas eux assez de temps mais voici la méthode pour réaliser ce projet (source Chat GPT3)


//Classe Board : Cette classe sera responsable de la création et de la gestion du plateau de jeu. Elle aura des méthodes pour initialiser le plateau de jeu, générer un GUID pour chaque cellule, accéder à une cellule en fonction de ses coordonnées ou de son GUID, et pour changer la couleur et l'échelle de chaque cellule.

//Classe Cell : Cette classe représentera chaque cellule du plateau de jeu. Elle aura des propriétés pour stocker les coordonnées et le GUID de la cellule, ainsi que sa couleur et son échelle actuelles. Elle aura également des méthodes pour mettre à jour la couleur et l'échelle de la cellule en réponse à des événements (par exemple, le survol ou le clic de la souris).

//Classe Game : Cette classe sera responsable de la logique du jeu. Elle aura des méthodes pour initialiser le jeu, gérer les tours des joueurs, vérifier les conditions de victoire, etc.

//Classe Player : Cette classe représentera chaque joueur du jeu. Elle aura des propriétés pour stocker le nom et la couleur du joueur, ainsi que son score actuel. Elle aura également des méthodes pour effectuer des actions en jeu, telles que placer un pion sur le plateau.

//En utilisant cette structure de code, vous pourriez créer un jeu de société dans Unity avec des interactions basiques, où les joueurs peuvent changer la couleur et l'échelle des cellules du plateau de jeu en cliquant dessus.



//voici les Scripts


//Script pour la classe Board :


/* using UnityEngine;
using System.Collections.Generic;

public class Board : MonoBehaviour
{
    public int boardSize = 10;
    public GameObject cellPrefab;
    public List<Cell> cells = new List<Cell>();

    private void Start()
    {
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        // Création des cellules du plateau
        for (int x = 0; x < boardSize; x++)
        {
            for (int y = 0; y < boardSize; y++)
            {
                // Création de la cellule
                GameObject cellObject = Instantiate(cellPrefab, new Vector3(x, y, 0), Quaternion.identity);
                Cell cell = cellObject.GetComponent<Cell>();
                cell.coordinates = new Vector2Int(x, y);

                // Ajout de la cellule à la liste
                cells.Add(cell);
            }
        }
    }

    public Cell GetCell(Vector2Int coordinates)
    {
        // Recherche de la cellule en fonction des coordonnées
        foreach (Cell cell in cells)
        {
            if (cell.coordinates == coordinates)
            {
                return cell;
            }
        }
        return null;
    }

    public Cell GetCell(string guid)
    {
        // Recherche de la cellule en fonction du GUID
        foreach (Cell cell in cells)
        {
            if (cell.guid == guid)
            {
                return cell;
            }
        }
        return null;
    }
}
 */



//Script pour la classe Cell :


/* using UnityEngine;

public class Cell : MonoBehaviour
{
    public Vector2Int coordinates;
    public string guid = System.Guid.NewGuid().ToString();

    private Color baseColor = Color.white;
    private Color highlightColor = Color.yellow;
    private Color clickedColor = Color.red;

    private void OnMouseEnter()
    {
        // Changement de couleur au survol
        GetComponent<Renderer>().material.color = highlightColor;
    }

    private void OnMouseExit()
    {
        // Retour à la couleur de base
        GetComponent<Renderer>().material.color = baseColor;
    }

    private void OnMouseDown()
    {
        // Changement de couleur au clic
        GetComponent<Renderer>().material.color = clickedColor;
    }

    public void SetColor(Color color)
    {
        // Changement de couleur
        GetComponent<Renderer>().material.color = color;
    }

    public void SetScale(Vector3 scale)
    {
        // Changement d'échelle
        transform.localScale = scale;
    }
} */




//Script pour la classe Game :


/* using UnityEngine;

public class Game : MonoBehaviour
{
    public Board board;

    private void Start()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Initialisation du plateau
        board.InitializeBoard();
    }

    public void EndTurn()
    {
        // Fin du tour en cours
    }

    public void CheckVictory()
    {
        // Vérification des conditions de victoire
    }
}
 */



//Script pour la classe Player :


/* using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public Color playerColor;
    public int score;

    public void PlacePiece(Cell cell)
    {
        // Placement d'un pion sur la cellule spécifiée
    }
}
 */


 
 //ces scripts constituent une structure de base pour créer un jeu de société simple dans Unity. 
 //Bien sûr, il faudrait ajouter plus de fonctionnalités et de logique pour en faire un vrai jeu de société,
 // comme des règles de jeu, des joueurs, des pions, etc.
















using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Architecture : MonoBehaviour
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
