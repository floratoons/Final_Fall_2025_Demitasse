using Unity.Cinemachine;
using UnityEngine;

public class camControl : MonoBehaviour, IGameStateManager
{
    public CinemachineCamera cam;
    public int priority;
    public int camID;

    public void Start()
    {
        cam = GetComponent<CinemachineCamera>();
    }

    /*public void puzzleCamSwitch(int camID_)
    {
    }*/

    public void GetState(gameState state)
    {
        // when the state is _# puzzle
        if (state.state == gameState.STATE.PUZZLE1)
        {
            // try switch state thing later
            /*switch (camID_)
            {
                case 1:
                    priority = 15;
                    break;
            }*/

            // depending on the camera's id #
            if (camID == 1)
            {
                // move cam up priority
                cam.Priority = priority;
                priority = 15;
            }
            // doesn't move cam up priority
            else
            {
                priority = 0;
            }
        }
        // on other states
        else if (state.state == gameState.STATE.MENU)
        {
            // go to menu
            cam.Priority = 0;
        }
    }

}