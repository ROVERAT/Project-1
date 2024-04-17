using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Shuter : MonoBehaviour
{
    public Parameters parameters;
    public ButonEmiter emiter;
    public int damag, identificator;
    public float speed = 0.2f;
    public GameObject bullet;
    public Animator anim;
    private void Start()
    {
        emiter = GetComponentInParent<ButonEmiter>();
    }
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
        speed = (emiter.lvl+1) * 0.2f;
        damag = parameters.lvls[identificator] * 10;
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
