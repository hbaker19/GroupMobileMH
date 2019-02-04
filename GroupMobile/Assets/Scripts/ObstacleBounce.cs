using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBounce : MonoBehaviour
{
    public int Health = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy")
        {
            Health -= 1;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 600));
        }
    }
}
