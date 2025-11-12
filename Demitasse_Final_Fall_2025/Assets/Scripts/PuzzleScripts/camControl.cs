using JetBrains.Annotations;
using NUnit.Framework;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity.Cinemachine;
using UnityEditorInternal;
using UnityEngine;

public class camControl : MonoBehaviour, IGameStateManager
{
    public CinemachineCamera cam;
    public int priority;
    public int camID;

    public puzzleButtonManager buttonManager;

    public void Start()
    {
        cam = GetComponent<CinemachineCamera>();
    }

    public void GetStateString(string state)
    {
        switch (state)
        {
            case "Menu":
                puzzleCamSwitch(0);
                break;
            case "Puzzle1":
                Debug.Log("Puzzle 1 button clicked");
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

    // switch state above is functional, GetState isn't doing anything now
    public void GetState(gameState state)
    {
        // switching cameras depending on different states
        if (state.state == gameState.STATE.MENU)
        {
            puzzleCamSwitch(0);
        }
        else if (state.state == gameState.STATE.PUZZLE1)
        {
            puzzleCamSwitch(1);
        }
        else if (state.state == gameState.STATE.PUZZLE2)
        {
            puzzleCamSwitch(2);
        }
        else if (state.state == gameState.STATE.PUZZLE3)
        {
            puzzleCamSwitch(3);
        }
    }

    public void puzzleCamSwitch(int camID_)
    {
        // cycle down list of active camera movements
        
        for (int i = 0; i < 3; i++)
        {
            // depending on target camera's id#
            if (i == camID_)
            {
                // move cam up priority
                priority = 15;
                cam.Priority = priority;
            }
            // move all other cameras down priority
            else if (i != camID_)
            {
                priority = 0;
            }
        }
    }
}