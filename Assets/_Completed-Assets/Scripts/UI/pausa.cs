using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{
    public bool pause;

    public GameObject pauseMenu;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Pause()
    {
        pause = !pause;
        pauseMenu.SetActive(!pause);
        if (pause)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
