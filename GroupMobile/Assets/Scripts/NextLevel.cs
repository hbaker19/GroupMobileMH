using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string LeveltoLoad;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Portal")
        {
            //Load next active scene
            SceneManager.LoadScene(LeveltoLoad);
            
        }
    }
}
