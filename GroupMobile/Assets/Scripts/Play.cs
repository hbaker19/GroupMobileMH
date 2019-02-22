using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour { 

    public void Difficulty()
{
    SceneManager.LoadScene("DifficultyScreen");
}

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
