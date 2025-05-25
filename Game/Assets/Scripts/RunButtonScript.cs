using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunButtonScript : MonoBehaviour
{
    public GameObject Handle;
    public Joystick joystick;
    private RectTransform rt_js, rt_handle;
    private float joystickWidth = 300, joystickHeight = 200, HandleWidth = 200, HandleHeight = 150, joystickPositionX = 250, joystickPositionY = 200;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("SizeButtons"))
        {
            rt_js = joystick.GetComponent<RectTransform>();
            rt_handle = Handle.GetComponent<RectTransform>();
            rt_js.anchoredPosition = new Vector2(joystickPositionX, joystickPositionY);
            rt_js.sizeDelta = new Vector2(joystickWidth, joystickHeight);
            rt_handle.sizeDelta = new Vector2(HandleWidth, HandleHeight);
        }

    }

    private void Update()
    {
        rt_js = joystick.GetComponent<RectTransform>();
        rt_handle = Handle.GetComponent<RectTransform>();
        rt_js.anchoredPosition = new Vector2(joystickPositionX * PlayerPrefs.GetFloat("SizeButtons"), joystickPositionY * PlayerPrefs.GetFloat("SizeButtons"));
        rt_js.sizeDelta = new Vector2(joystickWidth * PlayerPrefs.GetFloat("SizeButtons"), joystickHeight * PlayerPrefs.GetFloat("SizeButtons"));
        rt_handle.sizeDelta = new Vector2(HandleWidth * PlayerPrefs.GetFloat("SizeButtons"), HandleHeight * PlayerPrefs.GetFloat("SizeButtons"));
    }
}
