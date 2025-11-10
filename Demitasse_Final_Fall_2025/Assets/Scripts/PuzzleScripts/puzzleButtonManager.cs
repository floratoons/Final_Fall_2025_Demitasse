using JetBrains.Annotations;
using UnityEngine;

public class puzzleButtonManager : MonoBehaviour
{
    StateController statecontroller;

    public void PuzzleNavigation()
    {
        statecontroller = StateController.instance;

        string puzzleDestination = gameObject.tag;
        // switches the current state to the attached button's tag (sets the puzzle destination)
        statecontroller.switchState(puzzleDestination);
        Debug.Log("Button clicked, tag=" + gameObject.tag);
    }
}
