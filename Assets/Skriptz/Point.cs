using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Vector2 direction;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster") 
        {
            collision.GetComponent<Direction>().direction = direction;
        }
    }
}
