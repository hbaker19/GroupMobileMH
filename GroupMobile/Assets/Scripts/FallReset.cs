using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallReset : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FallStop")
        {
            //Will save active scene's name in PlayerPrefs
            Scene scene = SceneManager.GetActiveScene();
            PlayerPrefs.SetString("Scene", scene.name);
            SceneManager.LoadScene("Lose");
        }
    }
}
