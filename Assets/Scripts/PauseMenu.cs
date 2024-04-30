using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameManager GameManager;
    public GameObject PauseMenuUi;
    public static bool IsPaused;

    private void Awake()
    {
        PauseMenuUi.SetActive(false);
        IsPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused) Resume();
            else Pause();
        }
    }
    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    private void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        PauseMenuUi.SetActive(false);
        GameManager.ResetScore();
        GameManager.ResetRound();
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        PauseMenuUi.SetActive(false);
        GameManager.ResetScore();
        SceneManager.LoadScene("Menu");
    }
}
