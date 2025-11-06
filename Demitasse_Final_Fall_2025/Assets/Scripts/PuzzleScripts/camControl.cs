using Unity.Cinemachine;
using UnityEngine;

public class camControl : MonoBehaviour, IGameStateManager
{
    public CinemachineCamera cam;
    public int priority;

    public void Start()
    {
        cam = GetComponent<CinemachineCamera>();
    }

    public void GetState(gameState state)
    {
        if (state.state == gameState.STATE.PUZZLE1)
        {
            // go to puzzle 1
            cam.Priority = priority;
        }
        else if (state.state == gameState.STATE.MENU)
        {
            // go to menu
            cam.Priority = 0;
        }
    }
}