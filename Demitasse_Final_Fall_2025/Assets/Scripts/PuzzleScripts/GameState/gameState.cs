using UnityEngine;

public class gameState
{
    public enum STATE 
    { 
        NORMAL,
        TALKING,
        MENU
    }

    // local variable holding the gamestate
    public STATE state;

    // constructor of the non-monobehavior class
    // resets the default variables and/or behaviors
    public gameState()
    {
        state = STATE.NORMAL;
    }
}
