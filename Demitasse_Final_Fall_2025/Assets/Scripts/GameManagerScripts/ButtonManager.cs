using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class ButtonManager : MonoBehaviour
{
    public Button button;
    public int buttonClicks = 0;

    public GameObject continueOption;
    public GameObject playerInstructions;

    public void startGame()
    {
        SceneManager.LoadScene(1);
        continueOption.SetActive(false);
    }

    public void clickOnce()
    {
        // Turns off button function after one click
        button.interactable = false;
    }

    public void clickCount()
    {
        buttonClicks++;

        
        if (buttonClicks > 4)
        {
            continueOption.SetActive(true);
        }

        if(buttonClicks > 9)
        {
            SceneManager.LoadScene(2);
        }

        Debug.Log("Count: " + buttonClicks);
    }

    public void continueForward()
    {
        SceneManager.LoadScene(2);
    }
}
