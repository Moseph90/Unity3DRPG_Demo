using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;

    public bool loop;

    [Range(0f, 1f)]
    public float volume;
    [Range(0.5f, 1f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
