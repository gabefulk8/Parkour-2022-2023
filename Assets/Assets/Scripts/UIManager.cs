using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TogglePause();
        }
    }

    public void RestartLevel()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void ToMainMenu()
    {
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void TogglePause()
    {
        if (pauseMenu.activeSelf == true)
        {
            Cursor.visible = false;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        } else if (pauseMenu.activeSelf == false)
        {
            Cursor.visible = true;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }

    public void StartGame()
    {
        Cursor.visible = false;
        RestartLevel();    
    }
}
