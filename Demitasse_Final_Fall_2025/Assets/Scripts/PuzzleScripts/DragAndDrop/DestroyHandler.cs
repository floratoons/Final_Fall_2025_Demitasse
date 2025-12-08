using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.UI.VirtualMouseInput;
using UnityEngine.UI;

public class DestroyHandler : MonoBehaviour, IBeginDragHandler, IDropHandler
{
    public bool dragging = false;
    public Image destroySpace;

    public int activePuzzleCanvas;

    void Awake()
    {
        destroySpace = gameObject.GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // register that you're dragging
        dragging = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        // register that you're not dragging
        dragging = false;

        // get a temp "droppedObj" GameObject
        GameObject droppedObj = eventData.pointerDrag;

        // place the item in the destroy space
        droppedObj.GetComponent<DragDropManager>().lastPosition = transform;

        // destroy it
        Destroy(droppedObj, 3f);
        Debug.Log("Destroyed piece");
    }
    public void Update()
    {
        // turn on destroy space's raycast target only while dragging
        if (dragging)
        {
            destroySpace.raycastTarget = true;
        }
    }
}
