using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public PPiece currentPiece;
    public GameObject displayPiece;
    public Transform lastPosition;
    public Image icon;

    private void Start()
    {
        //displayPiece = GameObject.FindGameObjectWithTag("displayText");
        icon = GetComponent<Image>();
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
        icon.raycastTarget = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.position = lastPosition.position;
        transform.SetParent(lastPosition);
        icon.raycastTarget = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Mouse.current.position.ReadValue();
    }
}