using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Shuter : MonoBehaviour
{
    public GameObject bullet;
    public Animator anim;
    public int damag = 10;
    public float interval = 1;
    private float timer;
    private void Start()
    {
        timer = Time.time + interval;
        if (Spavner.rid.enemies.Count > 0)
        {
            Shut();
        }
    }
    void Shut() 
    {
        anim.SetBool("Kik", true);
    }
    public void Reload() 
    {
        anim.SetBool("Kik", false);
        if (Spavner.rid.enemies.Count > 0)
        {
            Transform monster = Instantiate(bullet).transform;
            monster.position = transform.position;
            monster.rotation = transform.rotation;
            monster.parent = transform;
            Spavner.rid.enemies[0].GetComponent<HP>().Damag(damag);
        }
    }
    private void FixedUpdate()
    {
        if (Spavner.rid.enemies.Count > 0)
        {
            if (Time.time > timer) 
            {
                Shut();
                timer = Time.time + interval;
            }
        }
    }
}
