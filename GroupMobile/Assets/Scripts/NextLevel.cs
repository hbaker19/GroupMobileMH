using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string LeveltoLoad;
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject[] Hearts = GameObject.FindGameObjectsWithTag("Heart");
        if(collision.gameObject.tag == "Portal" && Hearts.Length == 0)
        {
            //Load next active scene
            SceneManager.LoadScene(LeveltoLoad);
            
        }
    }
}
