using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialEnd : MonoBehaviour
{
    // moving "back" to perfumery scene after tutorial puzzle is over
    void Start()
    {
        SceneManager.LoadScene(3);
    }
}
