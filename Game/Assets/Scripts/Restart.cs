using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartLevel()
    {
        Invoke("LoadScene", 0.5f);
    }
    void LoadScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("scene"));
    }
}
