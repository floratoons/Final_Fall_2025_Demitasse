using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectClickandHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // This script is attempting to cause hovering over objects to show outline --
    // Then on click -- dialogue for each object is invoked.
    
    public UnityEvent OnClick;
    public bool canClick;

    // UI Elements
    public Outline itemOutline;
    public float outlineX = 1;
    public float outlineY = 1;

    public GameManager gameManagerScript;
    public GameObject gameManagementObject;

    public void Start()
    {
        itemOutline = GetComponent<Outline>();
        canClick = true;

        gameManagerScript = gameManagementObject.GetComponent<GameManager>();
    }

    
    // Hovering
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (gameManagerScript.investigationActive == true)
        {
            itemOutline.effectDistance = new Vector2(outlineX, outlineY);
            Debug.Log("Cursor Entered Obj");
        }
        else
        {
            itemOutline.effectDistance = new Vector2(1f, 1f);
        }
    }

    // Leave Hovering
    public void OnPointerExit(PointerEventData eventData)
    {
        itemOutline.effectDistance = new Vector2(1f,1f);
        Debug.Log("Cursor Exited Obj");
    }
}
