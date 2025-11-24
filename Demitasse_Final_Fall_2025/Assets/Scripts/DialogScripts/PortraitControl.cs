using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class PortraitControl : MonoBehaviour, IGameStateManager
{
    public Sprite placeHolder_Pasha;
    public Sprite placeHolder_Henri;
    public Sprite placeHolder_Jacque;
    public Image portrait;
    public CanvasGroup cvGroup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cvGroup = GetComponent<CanvasGroup>();
    }

    public void showPortrait()
    {
        cvGroup.alpha = 1;
    }

    public void hidePortrait()
    {
        cvGroup.alpha = 0;
    }

    //need to change this to make it longer and separate by character!
    [YarnCommand("changeNPCPortrait")]
    public void changePortrait(string mood)
    {
        if (mood == "neutral_pasha")
        {
            portrait.sprite = placeHolder_Pasha;
        }
        else if (mood == "neutral_henri")
        {
            portrait.sprite = placeHolder_Henri;
        }
        else
        {
            portrait.sprite = placeHolder_Jacque;
        }
    }

    public void GetState(gameState state)
    {
        if (state.state == gameState.STATE.TALKING)
        {
            showPortrait();
        }
        if (state.state == gameState.STATE.MENU)
        {
            hidePortrait();
        }
    }
}
