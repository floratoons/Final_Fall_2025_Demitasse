using UnityEditor;
//using UnityEditor.SearchService;
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

}
