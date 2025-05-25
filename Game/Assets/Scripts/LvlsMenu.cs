using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlsMenu : MonoBehaviour
{
    public int levelUnLock, sceneNumber;
    public float yourTimer, bestTimer1, bestTimer2, bestTimer3, bestTimer4, bestTimer5;
    public Button[] buttons;

    void Start()
    {
        levelUnLock = PlayerPrefs.GetInt("levels", 1);
        sceneNumber = PlayerPrefs.GetInt("scene");
        yourTimer = PlayerPrefs.GetFloat("YourTimer");
        bestTimer1 = PlayerPrefs.GetFloat("BestTimer1");
        bestTimer2 = PlayerPrefs.GetFloat("BestTimer2");
        bestTimer3 = PlayerPrefs.GetFloat("BestTimer3");
        bestTimer4 = PlayerPrefs.GetFloat("BestTimer4");
        bestTimer5 = PlayerPrefs.GetFloat("BestTimer5");

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelUnLock; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
