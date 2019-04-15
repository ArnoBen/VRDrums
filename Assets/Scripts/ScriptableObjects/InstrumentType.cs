using UnityEngine;

[CreateAssetMenu(menuName="InstrumentType")]
public class InstrumentType : ScriptableObject
{
    [Tooltip("It's the name of the desired folder located at Resource/Sounds/Samples")]
    [SerializeField] string FolderName;
    public AudioClip[] InstrumentAudioClips;

    [Header("Sound selection")]
    [Tooltip("Plays any sound of the target folder when disabled, or a sound from the specified list selectedSound when enabled.")]
    [SerializeField] bool ManuallySelectSounds = false;
    [SerializeField] AudioClip[] selectedSound;

    void OnValidate()
    {
        LoadSounds();
    }

    void LoadSounds()
    {
        string path = "Sounds/Samples/" + FolderName;
        if (FolderName == "") return;

        //LoadAll fetches all the files of type AudioClip in the folder selected by the variable path.
        InstrumentAudioClips = Resources.LoadAll<AudioClip>(path);
        InstrumentAudioClips = ManuallySelectSounds ? selectedSound : InstrumentAudioClips;
    }
    
}