using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //if it is pressed, stop stuff from moving
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                //make the pause menu visible
                GetComponent<Canvas>().enabled = true;
            }
            else if (Time.timeScale == 0)
            {
                //unpause
                Resume();
            }
        }
    }
    public void Resume()
    {
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }
}

    
