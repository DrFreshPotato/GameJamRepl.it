using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public LevelLoader start;

    public void PlayGame()
    {
        start.LoadNextLevel();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Home()
    {
        start.RestartToHome();
    }
}
