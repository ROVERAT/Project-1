using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaryad : MonoBehaviour
{
    public int damag;
    public float speed = 500;
    private void FixedUpdate()
    {
        Destroy(gameObject, 5);
        transform.position -= transform.up * speed * Time.fixedDeltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            collision.GetComponent<HP>().Damag(damag);
            Destroy(gameObject);
        }
    }
}
