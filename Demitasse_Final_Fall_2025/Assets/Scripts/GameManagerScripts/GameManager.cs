using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Update()
    {
        // temporary key to move to the puzzle scene
        if (Keyboard.current[Key.P].wasPressedThisFrame)
        {
            SceneManager.LoadScene("Puzzle_2");
            Debug.Log("P button clicked");
        }
    }


}
