using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puzzleSceneManager : MonoBehaviour
{
    public GameObject puzzleManager;
    
    public GameObject puzzleCanvas1;
    public GameObject puzzleCanvas2;
    public GameObject puzzleCanvas3;

    public Image puzzleButton1;
    public Image puzzleButton2;
    public Image puzzleButton3;

    private PlacementReader placementReaderScript;

    private void Awake()
    {
        placementReaderScript = PlacementReader.Instance;
    }

    private void Update()
    {
        buttonGrey(puzzleButton1, true);
        buttonGrey(puzzleButton2, false);
        buttonGrey(puzzleButton3, false);
    }

    void buttonGrey(Image refButton, bool solvedCheck)
    {
        Color greyedColor = refButton.color;
        Color fullColor = refButton.color;

        greyedColor.a = 0.5f;
        fullColor.a = 1f;

        if (solvedCheck == true)
        {
            refButton.GetComponent<Button>().enabled = true;
            refButton.color = fullColor;
        }
        else
        {
            refButton.GetComponent<Button>().enabled = false;
            refButton.color = greyedColor;
        }
    }
}
