using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectClickandHover : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    // This script is attempting to cause hovering over objects to show outline --
    // Then on click -- dialogue for each object is invoked.
    
    public UnityEvent OnClick;
    public bool canClick;

    // UI Elements
    public Outline itemOutline;
    public float outlineX = 0;
    public float outlineY = 0;

    public void Start()
    {
        itemOutline = GetComponent<Outline>();
        canClick = true;
    }

    // Click
    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    // Hovering
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (canClick)
        {
            itemOutline.effectDistance = new Vector2(outlineX, outlineY);
            Debug.Log("Cursor Entered Obj");
        }
        else
        {
            
        }
    }

    // Leave Hovering
    public void OnPointerExit(PointerEventData eventData)
    {
        itemOutline.effectDistance = new Vector2(0f,0f);
        Debug.Log("Cursor Exited Obj");
    }
}
