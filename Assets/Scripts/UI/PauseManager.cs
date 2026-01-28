using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public static bool isPaused;

    public GameObject background;
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
        settingsMenu.SetActive(true);
    }

    public void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1f;
        background.SetActive(false);
        settingsMenu.SetActive(false);
    }

    public void Menu()
    {
        ///return to title screen
        //SceneManager.LoadScene();
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

    private void Awake()
    {
        isPaused = false;
        background.SetActive(false);
        settingsMenu.SetActive(false);
    }
}
