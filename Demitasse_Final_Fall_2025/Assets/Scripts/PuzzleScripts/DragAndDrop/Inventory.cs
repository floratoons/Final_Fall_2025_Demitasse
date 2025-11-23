using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour, IDropHandler
{
    public int inventorySize;

    public bool placedRightPiece = false;
    public string goalPiece = "";

    private PPiece pPieceDataSource;

    public GameObject placedPiece;

    void Update()
    {
        /*if (Keyboard.current[Key.L].wasPressedThisFrame)
        {
            if (pPieceDataSource != null)
            {
                Debug.Log("Accessed piece name: " + pPieceDataSource.pieceName);
            }
            else
            {
                Debug.LogError("No piece name got");
            }
        }*/
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Dropped Item");
        GameObject droppedItem = eventData.pointerDrag;

        if (transform.childCount < inventorySize)
        {
            droppedItem.GetComponent<DragDropManager>().lastPosition = transform;
        }

        // logic to register whether the right piece is placed there

        //pPieceDataSource = placedPiece.GetComponent<PPiece>;

        //if (gameObject.GetComponentInChildren<PPiece.pieceName> == )

    }

}

