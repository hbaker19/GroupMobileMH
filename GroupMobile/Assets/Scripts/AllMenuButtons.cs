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
        //Calls the scene from PlayerPrefs and sends player to that scene.
        PlayerPrefs.GetString("Scene");

        SceneManager.LoadScene(scene.name);
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
