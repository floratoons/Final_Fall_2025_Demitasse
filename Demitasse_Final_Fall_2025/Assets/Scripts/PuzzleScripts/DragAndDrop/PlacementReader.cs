using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlacementReader : MonoBehaviour, IGameStateManager
{
    public static PlacementReader Instance { get; private set; }

    public GameObject[] pPlacementGroups;
    public int correctPlacedPiecesCount = 0;

    PlacementManager placementManagerScript;

    public bool solvedPuzzle1 = false;
    public bool solvedPuzzle2 = false;
    public bool solvedPuzzle3 = false;
    public int correctPlacementCountup = 0;
    public camControl camControlScript;

    public UnityEvent winEvent = new UnityEvent();
    public GameObject winCanvas;

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

    void Start()
    {
        winEvent.AddListener(solveTest);
        solvedPuzzle1 = false;
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            if (Keyboard.current[Key.Digit0].wasPressedThisFrame)
            {
                SceneManager.LoadScene(5);
            }
        }
    }

    public void CorrectPlacementCounter()
    {
        Debug.Log("CorrectPlacementCounter called");
        
        if (pPlacementGroups[0].GetComponent<PlacementManager>().correctPiecePlaced == true &&
            pPlacementGroups[1].GetComponent<PlacementManager>().correctPiecePlaced == true &&
            pPlacementGroups[2].GetComponent<PlacementManager>().correctPiecePlaced == true &&
            pPlacementGroups[3].GetComponent<PlacementManager>().correctPiecePlaced == true)
        {
            PuzzleSolveTrigger();
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
    }


    public void PuzzleSolveTrigger()
    {
        StartCoroutine(Timer());

        // sfx for puzzle solve feedback

        solvedPuzzle1 = true;
        Debug.Log("Puzzle 1 solved.");
        PuzzleSolveFeedback();
    }

    public void solveTest()
    {
        Debug.Log("Event functions, do the solve logic");
    }

    public void PuzzleSolveFeedback()
    {
        // go back to main screen with "solved"

        StartCoroutine(Timer());
        

        // return to perfumery

        // logic for moving back to the other canvas/"zooming out"
        // i think we'd also 
        //camControlScript.GetStateString("Complete");
        winCanvas.SetActive(true);
    }

    private IEnumerator Timer()
    {
        while (true)
        {
            Debug.Log("This PlacementReader timer");
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

    public void GetState(gameState state)
    {
        throw new System.NotImplementedException();
    }

}
