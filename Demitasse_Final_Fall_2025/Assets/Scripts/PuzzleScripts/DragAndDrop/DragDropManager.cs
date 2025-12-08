using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DragDropManager : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public PPiece currentPiece;
    //public GameObject displayPiece;
    public Transform lastPosition;
    public Image icon;

    public GameObject displayObj;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public Texture2D cursorTexture;

    public bool whileDragging = false;

    public int activePuzzleCanvas;

    public void Update()
    {
        icon = GetComponent<Image>();
        
        cursorTexture = currentPiece.cursorIcon;
        //Debug.Log(cursorTexture);
    }

    public void itemClick()
    {
        // logic/flavor/sfx here for clicking puzzle pieces
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        lastPosition = transform.parent;
        transform.SetParent(lastPosition.root);
        transform.SetAsLastSibling();
        //displayObj.GetComponent<TextMeshProUGUI>().text = currentPiece.lootDescription;
        icon.raycastTarget = false;

        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.position = lastPosition.position;
        transform.SetParent(lastPosition);
        icon.raycastTarget = true;

        Cursor.SetCursor(null, hotSpot, cursorMode);
    }

    public void OnDrag(PointerEventData eventData)
    {
        whileDragging = true;

        //Debug.Log(eventData);

        Vector2 mousePos = Mouse.current.position.ReadValue();
        //Debug.Log("Mouse x: " + mousePos.x + ", Mouse y: " + mousePos.y);

        GameObject activeCanvasPos = GameObject.Find(transform.parent.name);

        Vector3 mouseFollow = new Vector3(mousePos.x, mousePos.y, activeCanvasPos.transform.position.z + 1);
        // maintain x and y position of the cursor

        transform.position = mouseFollow;
    }
}