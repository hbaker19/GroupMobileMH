using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePlatforms : MonoBehaviour
{
    //Will set any object in the array to active state
    public GameObject[] platforms;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlatformAppear")
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                (platforms[i]).SetActive(true);
            }
        }
    }
}
