using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnMe : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
    }
}
