using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int maxPlatform = 0;
    bool isPaused = false;
    public GameObject PausePanel;
    public bool GameAktif = true;
    public GameObject GameWinPanel;
    public AudioSource suaraMenang;
    
    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            PausePanel.SetActive(true);
        }
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        isPaused = false;
        PausePanel.SetActive(false);
    }

    public void RestartButtonlvl1()
    {
        Time.timeScale = 1;
        isPaused = false;
        SceneManager.LoadScene("level1");

    }
    
    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Update()
    {
        if(GameAktif && Kunci.hitungKunci == 5)
        {
            {
                Debug.Log("Game Menang");
                GameWinPanel.SetActive(true);
                GameAktif = false;
                Time.timeScale = 0;
                isPaused = true;
                suaraMenang.Play();
            }   
        }
    }
}
