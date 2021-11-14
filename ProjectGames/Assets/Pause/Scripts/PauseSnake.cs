using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSnake : MonoBehaviour
{
    public static bool GamesIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject snake;
    public GameObject food;

    // Update is called once per frame
    void Update()
    {
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
        snake.SetActive(true);
        food.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamesIsPaused = true;
        snake.SetActive(false);
        food.SetActive(false);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

}
