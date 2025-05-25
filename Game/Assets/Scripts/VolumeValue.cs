using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    public AudioSource audioSrc;
    private float oldVolume;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("volume")) audioSrc.volume = 1f;
        oldVolume = audioSrc.volume;
    }

    private void Update()
    {
        if (oldVolume != PlayerPrefs.GetFloat("volume"))
        {
            audioSrc.volume = PlayerPrefs.GetFloat("volume");
            oldVolume = audioSrc.volume;
        }
    }
}