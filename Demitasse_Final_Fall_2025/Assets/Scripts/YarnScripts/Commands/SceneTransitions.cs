using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SceneTransitions : MonoBehaviour
{
    [YarnCommand("LoadScene")]
    public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
