using UnityEngine;
using Yarn.Unity;

public class DemitasseZoom : MonoBehaviour
{
    public static Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isActive", false);
    }

    [YarnCommand("LoadDemitasseZoom")]
    public static void LoadDemitasseZoom(string animName)
    {
        animator.SetBool("isActive", true);
        //animator.Play(animName);
    }
}
