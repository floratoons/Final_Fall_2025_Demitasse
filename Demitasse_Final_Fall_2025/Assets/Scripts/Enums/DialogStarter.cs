using UnityEngine;
using Yarn.Unity;

public class DialogStarter : MonoBehaviour, IGameStateManager
{
    public DialogueRunner dialogRunner;
    public string startNode;

    void Start()
    {
        dialogRunner = GetComponent<DialogueRunner>();
    }

    public void GetState(gameState state)
    {
        if (state.state == gameState.STATE.TALKING)
        {
            dialogRunner.StartDialogue(startNode);
        }
    }
}
