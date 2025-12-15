using JetBrains.Annotations;
using System.Diagnostics.Contracts;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject letterGroup;
    public UnityEvent dialogTrigger;

    private bool startVisited = false;

    public bool introDialogueStarted = false;

    public GameObject cameraToAdjust;
    public bool camMovementLock;

    public ButtonManager buttonManagerScript;
    public GameObject buttonCounterObject;

    public GameObject investigationInstructions;

    private void Start()
    {
        introDialogueStarted = false;
        camMovementLock = true;

        investigationInstructions.SetActive(false);

        if (startVisited == true)
        {
            letterGroup.SetActive(false);
            // next dialogue for after tutorial
        }

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            cameraToAdjust.GetComponent<CinemachineInputAxisController>().enabled = false;
        }

        buttonManagerScript = buttonCounterObject.GetComponent<ButtonManager>();
    }

    public void Update()
    {
        // temporary key to move to the puzzle scene
        /*if (Keyboard.current[Key.P].wasPressedThisFrame)
        {
            SceneManager.LoadScene(2);
            Debug.Log("P button clicked");
        }*/

        if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
            if (letterGroup != null)
            {
                letterGroup.SetActive(false);
                // this makes sure the script is only looking to turn off the letter if there is a letter TO turn off ^_^
            }
                startVisited = true;
        }

        if (Keyboard.current[Key.Escape].wasPressedThisFrame && introDialogueStarted == false)
        {
            dialogTrigger.Invoke();
            introDialogueStarted = true;
        }
    }

    public void cameraUnlock()
    {
        Debug.Log("Would be starting the investigation");

        cameraToAdjust.GetComponent<CinemachineInputAxisController>().enabled = true;
        
        if(buttonManagerScript.buttonClicks == 0)
        {
            investigationInstructions.SetActive(true);
        }
        else if(buttonManagerScript.buttonClicks > 0)
        {
            investigationInstructions.SetActive(false);
        }
            
    }
}
