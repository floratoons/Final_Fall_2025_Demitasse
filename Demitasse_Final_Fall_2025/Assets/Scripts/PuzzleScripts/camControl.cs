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
        if (state.state == gameState.STATE.TALKING)
        {
            // do talking
            cam.Priority = priority;
        }
        else if (state.state == gameState.STATE.NORMAL)
        {
            // do not talking
            cam.Priority = 0;
        }
    }
}