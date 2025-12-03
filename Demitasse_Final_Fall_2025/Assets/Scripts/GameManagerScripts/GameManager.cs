using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject letterGroup;
    public UnityEvent dialogTrigger;

    public void Update()
    {
        // temporary key to move to the puzzle scene
        if (Keyboard.current[Key.P].wasPressedThisFrame)
        {
            SceneManager.LoadScene("2");
            Debug.Log("P button clicked");
        }

        if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
            letterGroup.SetActive(false);
        }

        if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
            dialogTrigger.Invoke();
        }
    }


}
