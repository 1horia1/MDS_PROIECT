using UnityEngine;

public class PannelScript : MonoBehaviour
{
    public Animator animator;

    public void PannelAnimator()
    {
        animator.enabled = true;
        Invoke(nameof(DisableAnimatorComponent), 5);   
    }

    void DisableAnimatorComponent()
    {
        animator.enabled = false;   
    }
}
