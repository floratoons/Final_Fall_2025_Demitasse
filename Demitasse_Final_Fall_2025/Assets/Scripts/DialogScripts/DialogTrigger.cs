using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class DialogTrigger : MonoBehaviour
{
    public UnityEvent dialogTrigger;

    public void Update()
    {
        if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
            dialogTrigger.Invoke();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //if(Input.GetKeyDown(KeyCode.E))
        }
    }
}
