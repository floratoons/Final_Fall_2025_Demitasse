using JetBrains.Annotations;
using NUnit.Framework;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity.Cinemachine;
using UnityEditorInternal;
using UnityEngine;
using System.Collections;

public class camControl : MonoBehaviour, IGameStateManager
{
    public CinemachineCamera cam;
    public int priority;
    public int camID;

    public Canvas puzzleCanvas;

    public puzzleButtonManager buttonManager;

    public void Start()
    {
        cam = GetComponent<CinemachineCamera>();
    }

    // activates puzzleCamSwitch based on active state (got by clicking the buttons)
    public void GetStateString(string state)
    {
        switch (state)
        {
            case "Menu":
                puzzleCamSwitch(0);
                break;
            case "Puzzle1":
                puzzleCamSwitch(1);
                break;
            case "Puzzle2":
                puzzleCamSwitch(2);
                break;
            case "Puzzle3":
                puzzleCamSwitch(3);
                break;
        }
    }

    public void puzzleCamSwitch(int camID_)
    {
        // cycle down list of active camera movements

        Debug.Log("Cam " + camID_ + " clicked.");

        for (int i = 0; i < 4; i++)
        {
            // i increments through all canvasses and will only ever set one of them correctly
            // as "i" increments, it will undo the correct canvassses being turned on

            // depending on target camera's id#
            if (i == camID_)
            {
                // move cam up priority
                priority = 15;
                cam.Priority = priority;
                StartCoroutine(CountToPuzzleCanvas());
            }
            // move all other cameras down priority
            else if (i != camID_)
            {
                priority = 0;
                // remember to turn canvas off when puzzle is complete
                //puzzleCanvas.enabled = false;
            }
        }
    }

    public void GetState(gameState state)
    {
        throw new System.NotImplementedException();
    }

    // counts down briefly before activating the canvas with the puzzle stuff on it so that the camera has a chance to move beforehand
    private IEnumerator CountToPuzzleCanvas()
    {
        while (true)
        {
            Debug.Log("Puzzle canvas counter activated");
            yield return new WaitForSeconds(2);

            if (puzzleCanvas.enabled == false)
            {
                Debug.Log(puzzleCanvas + " set active");
                puzzleCanvas.enabled = true;
            }
            else
            {
                break;
            }
        }
    }
}