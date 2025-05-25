using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderButtons : MonoBehaviour
{
    public Slider sliderButtons;
    private float oldSizeButtons;

    void Awake()
    {
        oldSizeButtons = sliderButtons.value;
        if (!PlayerPrefs.HasKey("SizeButtons"))
        {
            sliderButtons.value = 1f;
            PlayerPrefs.SetFloat("SizeButtons", sliderButtons.value);
            PlayerPrefs.Save();
        }
        else sliderButtons.value = PlayerPrefs.GetFloat("SizeButtons");
    }

    void Update()
    {
        if (oldSizeButtons != sliderButtons.value)
        {
            PlayerPrefs.SetFloat("SizeButtons", sliderButtons.value);
            PlayerPrefs.Save();
            oldSizeButtons = sliderButtons.value;
        }
    }
}
