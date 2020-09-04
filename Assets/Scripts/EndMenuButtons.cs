using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuButtons : MonoBehaviour
{
    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenuButton(string mainMenuScene)
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
