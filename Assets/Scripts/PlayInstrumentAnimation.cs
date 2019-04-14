using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayInstrumentAnimation : MonoBehaviour
{
    public void PlayAnimation()
    {
        if (GetComponent<Animator>() != null) //Security just in case
            GetComponent<Animator>().SetTrigger("Hit");
    }
}
