using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLvlScript : MonoBehaviour
{
    public int levelUnLock;
    public Button[] buttons;
    public int lvlNumber;
    public float record, yourTime;
    public Text lvlNumberText, recordText, yourTimeText;
    public GameObject endButton;

    void Start()
    {
        levelUnLock = PlayerPrefs.GetInt("levels");

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelUnLock; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void Awake()
    {
        lvlNumber = PlayerPrefs.GetInt("scene");
        lvlNumberText.text = lvlNumber.ToString("F0");
        record = PlayerPrefs.GetFloat("BestTimer" + lvlNumber);
        recordText.text = record.ToString("F2");
        yourTime = PlayerPrefs.GetFloat("YourTimer");
        yourTimeText.text = yourTime.ToString("F2");
        if (lvlNumber == 5)
        {
            endButton.SetActive(true);
        }
    }

    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void GoMenuFromEndLvl()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoFinalScene()
    {
        SceneManager.LoadScene("FinalScene");
    }
}
