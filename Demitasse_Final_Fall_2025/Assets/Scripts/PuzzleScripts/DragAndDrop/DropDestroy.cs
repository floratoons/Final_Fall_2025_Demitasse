using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DropDestroy : MonoBehaviour, IEndDragHandler

    // This script is trying to destroy the puzzle pieces when they are dragged off of the puzzle box

{
    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(gameObject);
    }
}
