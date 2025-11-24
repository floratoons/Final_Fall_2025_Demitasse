using UnityEngine;
using UnityEngine.Events;

public class DialogTrigger : MonoBehaviour
{
    public UnityEvent dialogTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //if(Input.GetKeyDown(KeyCode.E))
            dialogTrigger.Invoke();
        }
    }
}
