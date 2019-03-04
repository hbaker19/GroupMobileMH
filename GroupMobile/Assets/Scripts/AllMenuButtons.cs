using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllMenuButtons : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryAgain()
    {
        //Calls the scene name from PlayerPrefs and sends player to that scene.
        string level = PlayerPrefs.GetString("Scene");
        SceneManager.LoadScene(level);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
