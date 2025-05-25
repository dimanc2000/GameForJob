using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneScript : MonoBehaviour
{
    public void goMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
