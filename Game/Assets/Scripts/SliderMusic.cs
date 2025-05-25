using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMusic : MonoBehaviour
{
    public Slider slider;
    private float oldVolume;

    void Awake()
    {
        oldVolume = slider.value;
        if (!PlayerPrefs.HasKey("volume"))
        {
            slider.value = 1f;
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
        } 
        else slider.value = PlayerPrefs.GetFloat("volume");
    }

    void Update()
    {
        if (oldVolume != slider.value)
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
            oldVolume = slider.value;
        }
    }
}
