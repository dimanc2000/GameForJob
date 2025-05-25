using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerseVolumeValue : MonoBehaviour
{
    public AudioSource audioSrcVerse;
    private float oldVolumeVerse;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("volumeVerse")) audioSrcVerse.volume = 1f;
        oldVolumeVerse = audioSrcVerse.volume;
    }

    private void Update()
    {
        if (oldVolumeVerse != PlayerPrefs.GetFloat("volumeVerse"))
        {
            audioSrcVerse.volume = PlayerPrefs.GetFloat("volumeVerse");
            oldVolumeVerse = audioSrcVerse.volume;
        }
    }
}
