using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string LeveltoLoad;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject[] Hearts = gameObject.FindGameObjectsWithTag("Heart");
        if(collision.gameObject.tag == "Portal" && Hearts.length == 0)
        {
            //Load next active scene
            SceneManager.LoadScene(LeveltoLoad);
            
        }
    }
}
