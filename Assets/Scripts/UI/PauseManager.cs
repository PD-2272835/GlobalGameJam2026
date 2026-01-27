using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject background;
    public GameObject mainMenu;
    public GameObject settingsMenu;

    public void TogglePause()
    {
        if (isPaused)
        {
            Unpause();
        }
        else
        {
            Pause();
        }
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        background.SetActive(true);
        mainMenu.SetActive(true);
    }

    public void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1f;
        background.SetActive(false);
        mainMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }

    public void OpenMainMenu()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OpenSettingsMenu()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void Restart()
    {
        Unpause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MusicOn()
    {
        ///enable music
    }

    public void MusicOff()
    {
        ///disable music
    }
}
