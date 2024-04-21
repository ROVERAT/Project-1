using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int nagrada = 10;
    public Parameters parameters;
    public GameObject blood;
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
        Destroyer des = Instantiate(blood).GetComponent<Destroyer>();
        des.transform.SetParent(Spawner.rid.transform, false);
        des.transform.localPosition = transform.localPosition;
        parameters.manna += nagrada;
        Destroy(gameObject);
    }
}
