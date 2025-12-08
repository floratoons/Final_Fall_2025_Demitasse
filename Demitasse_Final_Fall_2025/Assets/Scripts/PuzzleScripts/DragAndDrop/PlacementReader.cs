using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlacementReader : MonoBehaviour, IGameStateManager
{
    public static PlacementReader Instance { get; private set; }

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
    //public bool placedTL;
    //public bool placedTR;
    //public bool placedBL;
    //public bool placedBR;

    public bool solvedPuzzle1 = false;
    public int correctPlacementCountup = 0;
    public camControl camControlScript;


    public void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

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

    public void CorrectPlacementCounter()
    {
        Debug.Log("CorrectPlacementCounter called");
        


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
            correctPlacementCountup++;
            Debug.Log("Some correct placements");
        }
        else
        {
            Debug.Log("Puzzle not solved yet.");
        }

        /*int correctPlacementCountup = 0;
        int currentSlot = 0;

        for (int i = 0; i < 3; i++)
        {
            if (i == currentSlot)
            {
                if (pPlacementGroups[currentSlot].GetComponent<PlacementManager>().correctPiecePlaced == true)
                {
                    correctPlacementCountup++;
                    currentSlot++;
                    Debug.Log("Counting");
                }
            }
        }
        if (correctPlacementCountup == 4)
        {
            Debug.Log("(PlacementReader) Counted placementCountup " + correctPlacementCountup);
            Debug.Log("(PlacementReader) Counted currentslot " + currentSlot);
            PuzzleOnSolve();
        }*/

    }


    public void PuzzleOnSolve()
    {
        StartCoroutine(Timer());

        // sfx for puzzle solve feedback

        Debug.Log("Puzzle 1 solved.");

        // go back to main screen with "solved"

        StartCoroutine(Timer());
        //camControlScript.GetStateString("Complete");

        // return to perfumery
        Debug.Log("Finished puzzle");
        SceneManager.LoadScene(3);

    }

    public void GetState(gameState state)
    {
        throw new System.NotImplementedException();
    }

    private IEnumerator Timer()
    {
        while (true)
        {
            Debug.Log("0");
            yield return new WaitForSeconds(1);
            Debug.Log("1");
            yield return new WaitForSeconds(1);
            Debug.Log("2");
            yield return new WaitForSeconds(1);
            Debug.Log("3");
            break;
        }
    }

}
