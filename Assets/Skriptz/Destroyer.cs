using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float desTime;
    void Start()
    {
        transform.parent = Aura.rid.transform;
        Destroy(gameObject, desTime);
    }
}
