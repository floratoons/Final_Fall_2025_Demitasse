using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PlacementManager : MonoBehaviour, IDropHandler
{
    public GameObject placementGroup;

    public placement saleInteraction;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObj = eventData.pointerDrag;
        ItemInfo droppedItem = droppedObj.GetComponent<ItemInfo>();

        //placementGroup.GetComponent<WalletManager>().calcCash(droppedItem.currentPiece.cost);
        //saleInteraction.Invoke(droppedItem.currentPiece.cost);

        // talk to placementreader script to do logic for placed object?

        saleInteraction.Invoke(droppedItem.currentPiece);

        Destroy(droppedObj);
    }
}

[System.Serializable]
public class placement : UnityEvent<bool>
{ }