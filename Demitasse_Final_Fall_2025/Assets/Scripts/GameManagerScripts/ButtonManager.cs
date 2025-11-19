using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Overworld_1");
    }
}
