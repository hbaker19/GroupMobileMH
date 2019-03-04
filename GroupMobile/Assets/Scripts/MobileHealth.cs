using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MobileHealth : MonoBehaviour
{
//If player collides w/object tagged Enemy, active scene will reload
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Will save active scene's name in PlayerPrefs
            Scene scene = SceneManager.GetActiveScene();
            PlayerPrefs.SetString("Scene", scene.name);
            SceneManager.LoadScene("Lose");
        }
    }
}
