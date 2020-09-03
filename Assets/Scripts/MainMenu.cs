using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

   [SerializeField] private GameObject allButtonsPanel;
   [SerializeField] private GameObject loadingPanel;
   [SerializeField] private GameObject optionPanel;
    [SerializeField] private GameObject tutoPanel;

    public void PlayButton(string nameMainScene)
    {
        allButtonsPanel.SetActive(false);
        loadingPanel.SetActive(true);
        SceneManager.LoadScene(nameMainScene);
    }

    public void OptionButtons()
    {
        allButtonsPanel.SetActive(false);
        optionPanel.SetActive(true);
    }

    public void TutoButtons()
    {
        allButtonsPanel.SetActive(false);
        tutoPanel.SetActive(true);
    }

    public void ReturnButtons()
    {
        allButtonsPanel.SetActive(true);
        optionPanel.SetActive(false);
        tutoPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
