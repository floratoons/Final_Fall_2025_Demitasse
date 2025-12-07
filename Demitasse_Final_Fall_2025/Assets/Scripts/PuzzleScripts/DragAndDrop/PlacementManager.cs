using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Collections;

public class PlacementManager : MonoBehaviour, IDropHandler
{
    public GameObject placementGroup;

    public placement doThePlacement;

    public PPiece pPieceDataSource_;

    public string droppedPieceName;

    public bool correctPiecePlaced = false;

    DragDropManager dragDropManagerScript;
    PlacementReader placementReaderScript;

    public void OnDrop(PointerEventData eventData)
    {
        //
        GameObject droppedObj = eventData.pointerDrag;
        
        //
        DragDropManager droppedItem = droppedObj.GetComponent<DragDropManager>();

        //placementGroup.GetComponent<WalletManager>().calcCash(droppedItem.currentPiece.cost);


        //doThePlacement.Invoke(droppedItem.currentPiece.cost);

        // talk to placementreader script to do logic for placed object?

        //doThePlacement.Invoke(droppedItem.currentPiece);

        doThePlacement.Invoke(droppedItem.currentPiece.pieceName);
        Debug.Log("Got " + droppedItem.currentPiece.pieceName);

        droppedPieceName = droppedItem.currentPiece.pieceName;

        placementReaderScript.CorrectPlacementCounter();

        if (droppedItem.currentPiece.pieceName == placementGroup.GetComponent<Inventory>().goalPiece)
        {
            Debug.Log("Correct piece placed");
            correctPiecePlaced = true;
        }
        else
        {
            Debug.Log("Incorrect placement");
            correctPiecePlaced = false;

            StartCoroutine (Timer(4, droppedObj));
        }

    }

    private IEnumerator Timer(int time, GameObject droppedObj_)
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
    }

}



[System.Serializable]
public class placement : UnityEvent<string>
{ }

