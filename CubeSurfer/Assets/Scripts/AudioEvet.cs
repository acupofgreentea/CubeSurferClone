using UnityEngine;
using UnityEngine.Audio;

public abstract class AudioEvent : ScriptableObject
{
    [SerializeField] protected float volume;

    public AudioClip[] clips;

    [Range(-3,3)]
    [SerializeField] protected float pitch;

    [SerializeField] protected AudioMixerGroup mixer;
    public abstract void PlayAudio(AudioSource source, int clipIndex);
}
