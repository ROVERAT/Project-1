using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public Animator anim;
    public int hp = 100;

    public void Damag(int damag) 
    {
        if (hp > damag)
        {
            anim.SetTrigger("Play");
            hp -= damag;
        }
        else 
        {
            Ded();
        }
    }
    void Ded() 
    {
        Spavner.rid.enemies.Remove(transform);
        Destroy(gameObject);
    }
}