using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Instrument : MonoBehaviour
{
    [SerializeField] SoundList soundList;
    [SerializeField] GameEvent gameEvent;
    float volume;

    void OnTriggerEnter(Collider other)
    {
        volume = other.attachedRigidbody.angularVelocity.magnitude / 7; //Max rotation speed is 7 (at least on my computer !).
        gameEvent.Raise();
    }

    void OnCollisionEnter(Collision other)
    {
        volume = other.rigidbody.angularVelocity.magnitude / 7; //See OnTriggerEnter.
        gameEvent.Raise();
    }

    public void PlaySound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        int soundListSize = soundList.InstrumentAudioClips.Length;
        audioSource.clip = (AudioClip)soundList.InstrumentAudioClips[Random.Range(0, soundListSize)];
        audioSource.volume = volume;
        audioSource.Play();
    }
}
