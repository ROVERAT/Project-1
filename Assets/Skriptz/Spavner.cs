using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spavner : MonoBehaviour
{
    public GameObject peshka;
    public List<Transform> poses, enemies;
    public static Spavner rid { get; set; }

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
    public void Spawn() 
    {
        if (poses.Count > 0) 
        {
            int num = Random.Range(0, poses.Count);
            Transform pos = Instantiate(peshka).transform;
            pos.parent = poses[num].transform;
            pos.localPosition = Vector2.zero;
        }
    }
}
