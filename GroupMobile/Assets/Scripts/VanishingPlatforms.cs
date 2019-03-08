using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishingPlatforms : MonoBehaviour
{
    public GameObject[] timedPlatforms;
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer < 3f)
        {
            for (int i = 0; i < timedPlatforms.Length; i++)
            {
                (timedPlatforms[i]).SetActive(true);
            }
        }

        if (timer > 3f)
        {
            for (int i = 0; i < timedPlatforms.Length; i++)
            {
                (timedPlatforms[i]).SetActive(false);
            }
        }

        if (timer > 6f)
        {
            timer = 0;
        }
    }
}
