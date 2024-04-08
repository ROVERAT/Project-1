using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Aura : MonoBehaviour
{
    public int lvl;
    public int num;
    public static Aura rid { get; set; }

    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
}
