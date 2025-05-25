using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timeStart = 0;
    public float BestTimer;
    public Text timerText;
    public Text bestTimerText;

    void Awake()
    {
        int currentLvl = SceneManager.GetActiveScene().buildIndex;
        BestTimer = PlayerPrefs.GetFloat("BestTimer" + currentLvl);
        bestTimerText.text = "Best: " + BestTimer.ToString("F2");
    }

    void Start()
    {
        timerText.text = timeStart.ToString("F2");
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        timerText.text = timeStart.ToString("F2");
    }

}
