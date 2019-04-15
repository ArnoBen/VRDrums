using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayInstrumentAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (animator != null) //Security just in case
            animator.SetTrigger("Hit");
    }
}
