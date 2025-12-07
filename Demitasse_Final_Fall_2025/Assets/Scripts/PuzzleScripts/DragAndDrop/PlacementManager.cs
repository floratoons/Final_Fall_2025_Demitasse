using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Collections;
using UnityEditor.Experimental.GraphView;
using Unity.VisualScripting;

public class PlacementManager : MonoBehaviour, IDropHandler
{
    public GameObject placementGroup;

    public placement doThePlacement;

    public PPiece pPieceDataSource_;

    public string droppedPieceName;

    public bool correctPiecePlaced = false;

    public string placementGoalPiece = "";

    public DragDropManager dragDropManagerScript;
    private PlacementReader placementReaderScript;


    public int slotID;

    void Awake()
    {
        dragDropManagerScript = GetComponent<DragDropManager>();
        //here
        placementReaderScript = PlacementReader.Instance;
    }

    public void OnDrop(PointerEventData eventData)
    {
        //
        GameObject droppedObj = eventData.pointerDrag;
        Debug.Log("Dropped Item");

        if (transform.childCount < 1)
        {
            droppedObj.GetComponent<DragDropManager>().lastPosition = transform;
        }

        //
        DragDropManager droppedItem = droppedObj.GetComponent<DragDropManager>();

        //placementGroup.GetComponent<WalletManager>().calcCash(droppedItem.currentPiece.cost);
        //doThePlacement.Invoke(droppedItem.currentPiece.cost);

        // talk to placementreader script to do logic for placed object?

        //doThePlacement.Invoke(droppedItem.currentPiece);

        doThePlacement.Invoke(droppedItem.currentPiece.pieceName);
        Debug.Log("Got " + droppedItem.currentPiece.pieceName);

        droppedPieceName = droppedItem.currentPiece.pieceName;

        if (droppedItem.currentPiece.pieceName == placementGoalPiece)
        {
            Debug.Log("Correct piece placed");
            correctPiecePlaced = true;
        }
        else
        {
            Debug.Log("Incorrect placement");
            correctPiecePlaced = false;

            //StartCoroutine (Timer(4, droppedObj));
        }

        CheckPlacement();
    }

    void CheckPlacement()
    {
        StartCoroutine(Timer());
        Debug.Log("CheckPlacement ran");
        PlacementReader.Instance.CorrectPlacementCounter();

        /*if (correctPiecePlaced == true)
        {
            PlacementReader.Instance.PuzzleOnSolve();
        }
        else
        {
            Debug.Log("Checked placement, didn't run PuzzleOnSolve");
        }*/
    }

    /*private IEnumerator Timer(int time, GameObject droppedObj_)
    {
        while (true)
        {
            if (droppedObj_ == isActiveAndEnabled)
            {
                yield return new WaitForSeconds(time);
                Destroy(droppedObj_);
                dragDropManagerScript.whileDragging = false;
                Debug.Log("Destroyed incorrect placed piece");
            }
            else
            {
                break;
            }
        }
    }*/

    private IEnumerator Timer()
    {
        while (true)
        {
            Debug.Log("0");
            yield return new WaitForSeconds(1);
            Debug.Log("1");
            yield return new WaitForSeconds(1);
            Debug.Log("2");
            yield return new WaitForSeconds(1);
            Debug.Log("3");
            yield return new WaitForSeconds(1);
            break;
        }
    }
}



[System.Serializable]
public class placement : UnityEvent<string>
{ }

