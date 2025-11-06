using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateController : MonoBehaviour
{
    public static StateController instance { get; private set; }

    public gameState gState;
    public List<IGameStateManager> gStateObjs;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("There is already an instance of the StateController in this scene. Removing duplicate instance.");
        }
        instance = this;

        gState = new gameState();
    }

    public void Start()
    {
        gStateObjs = getAllStateObjects();
    }

    public void switchState(string currentState)
    {
        switch (currentState)
        {
            case "Menu":
                gState.state = gameState.STATE.MENU;
                break;
            case "Puzzle1":
                gState.state = gameState.STATE.PUZZLE1;
                break;
            case "Puzzle2":
                gState.state = gameState.STATE.PUZZLE2;
                break;
            case "Puzzle3":
                gState.state = gameState.STATE.PUZZLE3;
                break;
        }
        Debug.Log("The current gameState is " + gState.state);


        // loops through the gStateObjs list created in the Start()
        // calls the GetState method in each of those IGameStateManager interface objects
        // the GetState() method is made in the interface script
        foreach (IGameStateManager sManager in gStateObjs)
        {
            sManager.GetState(gState);
        }
    }

    public List<IGameStateManager> getAllStateObjects()
    {
        IEnumerable<IGameStateManager> stateManagers = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<IGameStateManager>();
        return new List<IGameStateManager>(stateManagers);
    }
}
