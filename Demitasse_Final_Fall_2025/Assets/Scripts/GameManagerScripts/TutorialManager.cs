using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialGroup;

    public GameObject tutorialText1;
    public GameObject tutorialText2;
    public GameObject tutorialText3;

    public Button continueButton;
    public int buttonClicks = 0;

 
    public void onClick()
    {
        buttonClicks++;

        // Begin on tutorial text 1
        if(buttonClicks == 1)
        {
            // Switch to tutorial text 2
            tutorialText1.SetActive(false);
            tutorialText2.SetActive(true);
            tutorialText3.SetActive(false);
        }
        else if(buttonClicks == 2)
        {
            // Switch to tutorial text 3
            tutorialText1.SetActive(false);
            tutorialText2.SetActive(false);
            tutorialText3.SetActive(true);
        }
        else if(buttonClicks == 3)
        {
            // Close tutorial tab
            tutorialGroup.SetActive(false);
        }
    }
}
