using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseTetris : MonoBehaviour
{
    public static bool GamesIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject border;
    public GameObject ghost;
    public GameObject ControlText;

    // Update is called once per frame
    void Update()
    {
        GamesIsPaused = false;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamesIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamesIsPaused = false;
        border.SetActive(true);
        ghost.SetActive(true);
        ControlText.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamesIsPaused = true;
        border.SetActive(false);
        ghost.SetActive(false);
        ControlText.SetActive(false);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
