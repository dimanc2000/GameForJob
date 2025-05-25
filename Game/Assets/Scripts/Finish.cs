using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public TimerScript Timer;
    private int sceneNumber;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            UndateBestTimerLevel();
            UnlockLevel();
            PlayerPrefs.SetInt("scene", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene("EndLevel");
        }
    }

    public void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel != 5)
        {
            if (currentLevel >= PlayerPrefs.GetInt("levels"))
            {
                PlayerPrefs.SetInt("levels", currentLevel + 1);
            }
        }
    }

    public void UndateBestTimerLevel()
    {
        int currentLvl = SceneManager.GetActiveScene().buildIndex;


        if (PlayerPrefs.GetFloat("BestTimer" + currentLvl) == 0)
        {
            PlayerPrefs.SetFloat("BestTimer" + currentLvl, Timer.timeStart);
        }
        else if (Timer.timeStart < PlayerPrefs.GetFloat("BestTimer" + currentLvl))
        {
            PlayerPrefs.SetFloat("BestTimer" + currentLvl, Timer.timeStart);
        }
        PlayerPrefs.SetFloat("YourTimer", Timer.timeStart);
    }
}
