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

    public void GetState(gameState state)
    {
        throw new System.NotImplementedException();
    }
}