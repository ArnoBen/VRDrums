using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayInstrumentAnimation : MonoBehaviour
{
    public void PlayAnimation()
    {
        if (GetComponent<Animator>() != null)
            GetComponent<Animator>().SetTrigger("Hit");
    }
}
