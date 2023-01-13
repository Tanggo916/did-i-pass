using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    public AudioSource audioSource;

    [Header("Pitch")]
    public float minPitchValue;
    public float maxPitchValue;

    [Header("Volume")]
    public float minVolumeValue;
    public float maxVolumeValue;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }
        DontDestroyOnLoad(this);
    }

    public void PlayClip(AudioClip clip)
    {
        RandomizeSound();
        audioSource.PlayOneShot(clip);
    }

    private void RandomizeSound()
    {
        audioSource.pitch = Random.Range(minPitchValue,maxPitchValue);
        audioSource.volume = Random.Range(minVolumeValue, maxVolumeValue);
    }
}
