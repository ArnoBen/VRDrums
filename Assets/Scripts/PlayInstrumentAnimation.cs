using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayInstrumentAnimation : MonoBehaviour
{
    private Animator animator;
    Instrument instrument;
    void Start()
    {
        animator = GetComponent<Animator>();
        instrument = transform.GetTopLevelParent().GetComponentInChildren<Instrument>();
        instrument.onInteraction += PlayAnimation;
    }

    public void PlayAnimation()
    {
        if (animator != null) //Security just in case
            animator.SetTrigger("Hit");
    }

    void OnDestroy()
    {
        instrument.onInteraction -= PlayAnimation;
    }
}
