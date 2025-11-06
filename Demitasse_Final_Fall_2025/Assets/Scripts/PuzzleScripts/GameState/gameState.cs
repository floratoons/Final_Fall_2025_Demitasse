using UnityEngine;

public class gameState
{
    public enum STATE 
    { 
        MENU,
        PUZZLE1,
        PUZZLE2,
        PUZZLE3
    }

    // local variable holding the gamestate
    public STATE state;

    // constructor of the non-monobehavior class
    // resets the default variables and/or behaviors
    public gameState()
    {
        state = STATE.MENU;
    }
}
