using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject letterGroup;
    public UnityEvent dialogTrigger;

    private bool startVisited = false;

    public void Update()
    {
        // temporary key to move to the puzzle scene
        if (Keyboard.current[Key.P].wasPressedThisFrame)
        {
            SceneManager.LoadScene(2);
            Debug.Log("P button clicked");
        }

        if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
            letterGroup.SetActive(false);
            startVisited = true;
        }

        if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
            dialogTrigger.Invoke();
        }
    }

    private void Start()
    {
        if (startVisited == true)
        {
            letterGroup.SetActive(false);
            // next dialogue for after tutorial
        }
    }
}
