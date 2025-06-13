using UnityEngine;

public class DisableAnimatorAfterPlay : MonoBehaviour
{
    public GameObject musicButton;

    void Update()
    {
        DisableMusicAnimator();
    }

    public void DisableMusicAnimator()
    {
        Animator anim = musicButton.GetComponent<Animator>();
        if (anim != null)
            anim.enabled = false;
    }
}
