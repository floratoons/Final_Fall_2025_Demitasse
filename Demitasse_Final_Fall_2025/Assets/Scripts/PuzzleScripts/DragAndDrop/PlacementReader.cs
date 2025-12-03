using TMPro;
using UnityEngine;

public class PlacementReader : MonoBehaviour
{

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

    public void PuzzleOnSolve()
    {

    }

}
