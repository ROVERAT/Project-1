using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaryad : MonoBehaviour
{
    public float speed = 500;
    private void FixedUpdate()
    {
        transform.position -= transform.up * speed * Time.fixedDeltaTime;
    }
}
