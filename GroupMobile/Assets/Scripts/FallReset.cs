using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallReset : MonoBehaviour
{
    //Will reload scene if the player falls too far
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FallStop")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
