using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PlacementManager : MonoBehaviour, IDropHandler
{
    public GameObject placementGroup;

    public placement doThePlacement;

    public PPiece pPieceDataSource_;

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

        /*if (pPieceDataSource_ != null)
        {
            Debug.Log("Accessed piece name: " + pPieceDataSource_.pieceName);
        }
        else
        {
            Debug.LogError("No piece name got");
        }*/
    }
}

[System.Serializable]
public class placement : UnityEvent<string>
{ }