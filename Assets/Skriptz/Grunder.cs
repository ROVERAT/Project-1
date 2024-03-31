using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunder : MonoBehaviour
{
    public bool isPeshka;
    private void Awake()
    {
        Spavner.rid.poses.Add(transform);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Peshka") 
        {
            collision.transform.parent = transform;
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
}
