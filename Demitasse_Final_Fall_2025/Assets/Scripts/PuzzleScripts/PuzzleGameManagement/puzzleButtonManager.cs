using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class puzzleButtonManager : MonoBehaviour, IGameStateManager
{

    public int camLocationCount;

    public camControl camcontrol;

    public void GetState(gameState state)
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
            string sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneName);

            //camcontrol.GetStateString("Menu");
            Debug.Log("Esc button clicked");
        }
    }
}
