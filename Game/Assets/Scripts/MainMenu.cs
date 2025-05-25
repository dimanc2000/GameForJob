using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int awakening;

    private void Awake()
    {
        awakening = PlayerPrefs.GetInt("awaken", 0);
        if (PlayerPrefs.GetInt("awaken") < 1)
        {
            PlayerPrefs.SetInt("awaken", 1);
            SceneManager.LoadScene("FirstScene");
        } 
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("levels", 1);
        PlayerPrefs.SetFloat("YourTimer", 0);
        PlayerPrefs.SetFloat("BestTimer1", 0);
        PlayerPrefs.SetFloat("BestTimer2", 0);
        PlayerPrefs.SetFloat("BestTimer3", 0);
        PlayerPrefs.SetFloat("BestTimer4", 0);
        PlayerPrefs.SetFloat("BestTimer5", 0);
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
