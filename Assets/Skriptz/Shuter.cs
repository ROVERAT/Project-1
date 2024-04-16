using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Shuter : MonoBehaviour
{
    public int damag = 10;
    public float speed = 0.2f;
    public GameObject bullet;
    public Animator anim;
    public void Shut() 
    {
        Transform bulet = Instantiate(bullet).transform;
        bulet.position = transform.position;
        bulet.rotation = transform.rotation;
        bulet.parent = transform;
        bulet.GetComponent<Snaryad>().damag = damag;
    }
    private void FixedUpdate()
    {
        anim.SetFloat("Speed", speed);
        if (Spavner.rid.enemies.Count > 0)
        {
            anim.SetBool("Kik", true);
        }
        else 
        {
            anim.SetBool("Kik", false);
        }
    }
}
