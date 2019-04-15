using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayInstrumentSound : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySound(HitData hitData) 
    {
        AudioClip[] InstrumentAudioClips = hitData.InstrumentType.InstrumentAudioClips;
        int soundListSize = InstrumentAudioClips.Length;
        float volumeCoefficient = hitData.InstrumentType.VolumeCoefficient;
        
        // Pick a random sound from the list of sounds in InstrumentAudioClips
        // Use the velocity magnitude during the hit in hitData to control the volume (the max magnitude is 7 hence the / 7)
        audioSource.PlayOneShot(InstrumentAudioClips[Random.Range(0, soundListSize)], hitData.Magnitude * volumeCoefficient / 7);
    }
}
