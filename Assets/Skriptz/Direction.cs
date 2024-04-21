using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{

    public float speed;
    public Vector3 direction;

    private void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
