using System;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float viteza = 200f;
    public float pozitieFinalaX = 650f;
    private bool saOprit = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (saOprit)
            return;

        if (transform.position.x > pozitieFinalaX)
        {
            float pas = viteza * Time.deltaTime;
            transform.position += new Vector3(-1f * pas, 0f, 0f);
        }
        else
        {
            Debug.Log("New client.");
            saOprit = true;

            if (animator != null)
                animator.enabled = false;

            // Reset the rotations
            transform.rotation = Quaternion.identity;

            foreach (Transform body in transform)
            {
                body.localRotation = Quaternion.identity;

                foreach (Transform child in body)
                {
                    child.localRotation = Quaternion.identity;

                    foreach (Transform grandchild in child)
                    {
                        grandchild.localRotation = Quaternion.identity;
                    }
                }
            }
        }
    }
}
