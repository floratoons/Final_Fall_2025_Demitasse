using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlacementReader : MonoBehaviour
{
    // ------------------------

    // temporary version:
    // get the PPlacementGroup and keep track of how many children,
    // change counter based on amount,
    // do an event when the puzzle is solved

    public GameObject pPlacementGroup;
    public int placedPiecesCount = 0;
    public TMP_Text pieceCountText;
    public TMP_Text solvedText;

    public bool solvedPuzzle1 = false;

    public void Update()
    {
        placedPiecesCount = pPlacementGroup.transform.childCount;

        pieceCountText.text = ("Pieces: " + placedPiecesCount + "/4");

        if (placedPiecesCount == 4)
        {
            solvedPuzzle1 = true;
        }

        if (solvedPuzzle1 == true)
        {
            solvedText.text = "Puzzle 1 solved!";
        }
        else if (solvedPuzzle1 == false)
        {
            solvedText.text = "Puzzle 1 not solved yet...";
        }
    }

    // here we need to:

    // get the stats on the puzzlepiece scriptable objs
    // when a piece is placed,
    // register whether the piece is in its right place

    // if it is:
    // make it not a raycast target (?)
    // register that 1/4 pieces is placed right
    // tell gamemanager 1/4 to puzzle complete
    // take that piece off the list of items to spawn

    // if it isn't:
    // let it snap back to its place on the PItemGroup




    public void PuzzleOnSolve()
    {
        Timer(2);

        // sfx for puzzle solve feedback

        Debug.Log("Puzzle 1 solved.");
        // go back to main screen with "solved"

        Timer(3);
        // return to cafe
        SceneManager.LoadScene(1);

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
