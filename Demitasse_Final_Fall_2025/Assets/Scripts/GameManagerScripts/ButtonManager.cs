using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button button;
    public int buttonClicks;

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void clickOnce()
    {
        button.interactable = false;
    }

    public void clickCount()
    {
        buttonClicks++;

        if(buttonClicks > 9)
        {
            SceneManager.LoadScene(2);
        }
    }
}
