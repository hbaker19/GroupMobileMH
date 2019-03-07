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
                int r = Random.Range(0, 3);
                if (r == 0)
                {
                    (timedPlatforms[i]).SetActive(false);
                    break;
                }

                
            }
        }

        if (timer > 6f)
        {
            timer = 0;
        }
    }
}
