using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IDropHandler
{
    public int inventorySize;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Dropped Item");
        GameObject droppedItem = eventData.pointerDrag;

        if (transform.childCount < inventorySize)
        {
            droppedItem.GetComponent<ItemInfo>().lastPosition = transform;
        }

    }

}

