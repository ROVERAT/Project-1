using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Peshka") 
        {
            collision.transform.parent = transform;
        }
    }
}
