using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{

    public float speed;
    public Vector2 direction;
    

    void FixedUpdate()
    {

    transform.Translate(speed * direction * Time.deltaTime, Space.World);
    
    }
}
