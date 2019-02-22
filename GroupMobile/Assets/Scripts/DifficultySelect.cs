using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelect : MonoBehaviour
{
    public void StandardLevels()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void HardLevels()
    {
        SceneManager.LoadScene("Level1Hard");
    }
}
