using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunder : MonoBehaviour
{
    private void Start()
    {
        Spavner.rid.poses.Add(transform);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Peshka") 
        {
            Spavner.rid.poses.Remove(transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Peshka")
        {
            Spavner.rid.poses.Add(transform);
        }
    }
    private void FixedUpdate()
    {
        if (transform.childCount != 0) 
        {
            Spavner.rid.poses.Remove(transform);
        }
    }
}
