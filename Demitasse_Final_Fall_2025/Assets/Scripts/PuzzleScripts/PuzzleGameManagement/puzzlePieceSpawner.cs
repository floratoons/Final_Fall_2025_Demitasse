using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class puzzlePieceSpawner : MonoBehaviour, IGameStateManager
{

    // here we need to:

    // spawn puzzle piece objects based on a timer, but only if there are free spaces in the PItemGroup

    public List<PPiece> allItems;
    public GameObject itemGroupContainer;
    public int itemSize;

    public int currentPuzzle = 0;

    public void GetStateString(string state)
    {
        // getting the current state
        switch (state)
        {
            case "Menu":
                currentPuzzle = 0;
                break;
            case "Puzzle1":
                currentPuzzle = 1;
                break;
            case "Puzzle2":
                currentPuzzle = 2;
                break;
            case "Puzzle3":
                currentPuzzle = 3;
                break;
        }
    }

    public void PieceClickSpawner()
    {
        // spawner:

        // first if registers what puzzle we're on
        if (currentPuzzle == 1)
        {
            // second if registers if there's empty spots in the PItemGroup
            if (itemGroupContainer.transform.childCount < itemSize)
            {
                //StartCoroutine(CountToPieceSpawn());
                // spawn logic

                // temporary key to spawn puzzle pieces
                if (Keyboard.current[Key.O].wasPressedThisFrame)
                {
                    Debug.Log("Piece spawner clicked");

                    for (int i = 0; i < itemGroupContainer.transform.childCount; i++)
                    {
                        Destroy(itemGroupContainer.transform.GetChild(i).gameObject);
                    }

                    for (int i = 0; i < itemSize; i++)
                    {
                        // creating a new gameobj in the scene
                        // selecting random piece from the list within the list of scriptable obj data

                        var randomItem = new GameObject();
                        var itemIcon = randomItem.AddComponent<Image>();
                        var itemData = randomItem.AddComponent<ItemInfo>();

                        // add a button and listener to the button calling 'lootClick' function in the lootData class 
                        var randomItemBtn = randomItem.AddComponent<Button>();
                        randomItemBtn.onClick.AddListener(itemData.itemClick);

                        // assigning the randomly selected piece from the scripobj to the new gameobj
                        randomItem.GetComponent<ItemInfo>().currentPiece = allItems[Random.Range(0, allItems.Count)];
                        itemIcon.sprite = itemData.currentPiece.icon;

                        // assign the item to the PPlacementGroup
                        randomItem.transform.SetParent(itemGroupContainer.transform);
                    }
                }

                
            }
        }
    }

    private IEnumerator CountToPieceSpawn()
    {
        while (true)
        {
            Debug.Log("Puzzle piece spawn timer activated");
            yield return new WaitForSeconds(5);

            Debug.Log("New piece spawned (if there's space)");
            break;
        }
    }

    public void GetState(gameState state)
    {
        throw new System.NotImplementedException();
    }
}
