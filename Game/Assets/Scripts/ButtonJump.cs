using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonJump : MonoBehaviour, IPointerDownHandler
{
    public Men men1;
    public Button buttonJump;
    private RectTransform rt_bj;

    private float buttonJumpWidth = 200, buttonJumpHeight = 200, buttonPositionX = -200, buttonPositionY = 200;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (men1.isGrounded && (men1.doubleJump < men1.doubleJumpValue))
        {
            men1.doubleJump++;
            men1.rb.AddForce(men1.transform.up * men1.jumpForce, ForceMode2D.Impulse);

        }
        else if (!men1.isGrounded && (men1.doubleJump < men1.doubleJumpValue))
        {
            men1.doubleJump++;
            men1.rb.AddForce(men1.transform.up * men1.doubleJumpForce, ForceMode2D.Impulse);

        }
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("SizeButtons"))
        {
            rt_bj = buttonJump.GetComponent<RectTransform>();
            rt_bj.sizeDelta = new Vector2(buttonJumpWidth, buttonJumpHeight);
            rt_bj.anchoredPosition = new Vector2(buttonPositionX, buttonPositionY);
        }
            
    }

    private void Update()
    {
        rt_bj = buttonJump.GetComponent<RectTransform>();
        rt_bj.anchoredPosition = new Vector2(buttonPositionX * PlayerPrefs.GetFloat("SizeButtons"), buttonPositionY * PlayerPrefs.GetFloat("SizeButtons"));
        rt_bj.sizeDelta = new Vector2(buttonJumpWidth * PlayerPrefs.GetFloat("SizeButtons"), buttonJumpHeight * PlayerPrefs.GetFloat("SizeButtons"));
    }
}
