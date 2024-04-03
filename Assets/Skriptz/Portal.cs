using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            Spavner.rid.enemies.Remove(collision.transform);
            Destroy(collision.gameObject);
        }
    }
}
