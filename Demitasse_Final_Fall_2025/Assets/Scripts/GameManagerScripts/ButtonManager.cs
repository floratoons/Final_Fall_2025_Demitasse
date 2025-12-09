using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button button;
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void clickOnce()
    {
        button.interactable = false;
    }
}
