using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlacementReader : MonoBehaviour, IGameStateManager
{
    public static PlacementReader instance { get; private set; }

    // ------------------------

    // temporary version:
    // get the PPlacementGroup and keep track of how many children,
    // change counter based on amount,
    // do an event when the puzzle is solved

    public GameObject[] pPlacementGroups;
    public int correctPlacedPiecesCount = 0;
    public TMP_Text pieceCountText;
    public TMP_Text solvedText;

    PlacementManager placementManagerScript;
    public bool placedTL;
    public bool placedTR;
    public bool placedBL;
    public bool placedBR;

    public bool solvedPuzzle1 = false;

    camControl camControlScript;

    public void Update()
    {
        //placedPiecesCount = pPlacementGroups.transform.childCount;

        /*if (correctPlacedPiecesCount == 4)
        {
            solvedPuzzle1 = true;
        }

        if (solvedPuzzle1 == true)
        {
            solvedText.text = "Puzzle 1 solved!";
            StartCoroutine(Timer(2));
            PuzzleOnSolve();

        }
        else if (solvedPuzzle1 == false)
        {
            solvedText.text = "Puzzle 1 not solved yet...";
            //PlacementReading();
        }*/

    }

    // here i would've liked to:

    // get the stats on the puzzlepiece scriptable objs
    // when a piece is placed,
    // register whether the piece is in its right place

    // if it is:
    // register that 1/4 pieces is placed right
    // tell gamemanager 1/4 to puzzle complete
    // take that piece off the list of items to spawn

    // if it isn't:
    // let it snap back to its place on the PItemGroup

    /*public void PlacementReading()
    {
        if (placementManagerScript.droppedPieceName == gameObject.GetComponent<Inventory>().goalPiece)
        {
            correctPlacedPiecesCount++;
            pieceCountText.text = "Pieces: " + correctPlacedPiecesCount + "/4";
        }
        else
        {
            Debug.Log("Incorrect piece placed");
            pieceCountText.text = "Pieces: " + correctPlacedPiecesCount + "/4";
        }
    }*/

    public void CorrectPlacementCounter()
    {
        

        
        if (pPlacementGroups[0].GetComponent<PlacementManager>().correctPiecePlaced == true &&
            pPlacementGroups[1].GetComponent<PlacementManager>().correctPiecePlaced == true &&
            pPlacementGroups[2].GetComponent<PlacementManager>().correctPiecePlaced == true &&
            pPlacementGroups[3].GetComponent<PlacementManager>().correctPiecePlaced == true)
        {
            PuzzleOnSolve();
        }
        else if(pPlacementGroups[0].GetComponent<PlacementManager>().correctPiecePlaced == true ||
            pPlacementGroups[1].GetComponent<PlacementManager>().correctPiecePlaced == true ||
            pPlacementGroups[2].GetComponent<PlacementManager>().correctPiecePlaced == true ||
            pPlacementGroups[3].GetComponent<PlacementManager>().correctPiecePlaced == true)
        {
            Debug.Log("Some correct placements");
        }
        else
        {
            Debug.Log("Puzzle not solved yet.");
        }
    }


    public void PuzzleOnSolve()
    {
        StartCoroutine(Timer(2));

        // sfx for puzzle solve feedback

        Debug.Log("Puzzle 1 solved.");

        // go back to main screen with "solved"

        StartCoroutine(Timer(3));
        camControlScript.GetStateString("Complete");

        // return to cafe
        SceneManager.LoadScene(1);

    }

    public void GetState(gameState state)
    {
        throw new System.NotImplementedException();
    }

    private IEnumerator Timer(int time)
    {
        while (true)
        {
            Debug.Log("Puzzle win state counter activated");
            yield return new WaitForSeconds(time);
            break;
        }
    }

}
