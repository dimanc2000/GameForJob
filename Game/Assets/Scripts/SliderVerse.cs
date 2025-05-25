using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVerse : MonoBehaviour
{
    public Slider sliderVerse;
    private float oldVolumeVerse;

    void Awake()
    {
        oldVolumeVerse = sliderVerse.value;
        if (!PlayerPrefs.HasKey("volumeVerse"))
        {
            sliderVerse.value = 1f;
            PlayerPrefs.SetFloat("volumeVerse", sliderVerse.value);
            PlayerPrefs.Save();
        }
        else sliderVerse.value = PlayerPrefs.GetFloat("volumeVerse");
    }

    void Update()
    {
        if (oldVolumeVerse != sliderVerse.value)
        {
            PlayerPrefs.SetFloat("volumeVerse", sliderVerse.value);
            PlayerPrefs.Save();
            oldVolumeVerse = sliderVerse.value;
        }
    }
}
