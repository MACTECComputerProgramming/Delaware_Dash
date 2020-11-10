using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScripts : MonoBehaviour
{
    private bool paused = false;

    
    public void Update()
    {
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void PauseGame()
    {
        paused = true;
    }

    public void ResumeGame()
    {
        paused = false;
    }

    public void LoseGame()
    {
        SceneManager.LoadScene(3);
    }

}
