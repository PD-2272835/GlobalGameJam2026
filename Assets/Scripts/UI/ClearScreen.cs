using UnityEngine;
using UnityEngine.UI;

public class ClearScreen : MonoBehaviour
{
    public GameObject clearMenu;
    public Sprite[] clearSprites;
    public GameObject restartButton; //Uses Restart() from PauseManager.cs


    public void ShowClear(int stars)
    {
        Time.timeScale = 0f;
        clearMenu.SetActive(true);
        ClearScore(stars);
        restartButton.SetActive(true);
    }

    private void ClearScore(int stars)
    {
        clearMenu.GetComponent<Image>().sprite = clearSprites[stars];
    }

    private void Awake()
    {
        clearMenu.SetActive(false);
        restartButton.SetActive(false);
    }
}
