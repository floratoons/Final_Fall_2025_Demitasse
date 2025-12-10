using UnityEngine;

public class puzzleManagerTest : MonoBehaviour
{
    // get all 4 slots

    // get the correct piece placed bool from each slot

    // count up to 4 based on the bool

    // mark a different bool as finished puzzle if the counter == 4

    public GameObject pGroup1;
    public GameObject pGroup2;
    public GameObject pGroup3;
    public GameObject pGroup4;

    public bool placed1;
    public bool placed2;
    public bool placed3;
    public bool placed4;

    public int placedCounter = 0;

    public bool puzzleComplete = false;

    private void Update()
    {
        PlacementChecker(pGroup1, placed1);
        PlacementChecker(pGroup2, placed2);
        PlacementChecker(pGroup3, placed3);
        PlacementChecker(pGroup4, placed4);

        if (placedCounter == 4)
        {
            puzzleComplete = true;
        }

        if (puzzleComplete == true)
        {
            //Debug.Log("Puzzle complete");
        }
    }

    public void PlacementChecker(GameObject slot, bool placedBool)
    {
        
        if (slot.GetComponent<PlacementManager>().correctPiecePlaced == true)
        {
            placedCounter++;
            placedBool = true;
        }
    }
}
