using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
public class ButonEmiter : MonoBehaviour
{
    public Image aura;
    public Color[] collor;
    public Parameters parameters;
    public RectTransform looker;
    public Image figure;
    public Sprite[] sprite;
    public Collider2D other;
    public LayerMask mask;
    public int lvl, num;
    public bool ismuwe;
    private Transform parent;
    public List <GameObject> peshki;
    private void Start()
    {
       RandoMaiser();
    }
    
    private void FixedUpdate()
    {
        if (peshki.Count > 1) 
        {
            Destroy(peshki[0]);
            peshki.RemoveAt(0);
        }
        if (!ismuwe) 
        {
            if (Aura.rid.lvl == lvl && Aura.rid.num == num)
            {
                aura.enabled = true;
            }
            else
            {
                aura.enabled = false;
            }
        }
        else
        {
            aura.enabled = false;
        }
    }
    public void Resed() 
    {
        Aura.rid.lvl = 100;
        Aura.rid.num = 100;
        transform.localPosition = Vector2.zero;
        ismuwe = false;
    }

    public void RandoMaiser() 
    {
        num = Random.Range(0, collor.Length);
        figure.color = collor[num];
        GameObject p = Instantiate(parameters.peshki[num]);
        p.transform.SetParent(looker, false);
        //p.transform.parent = looker;
        p.transform.localPosition = Vector3.zero;
        p.transform.localEulerAngles = new Vector3(0, 90, -90);
        peshki.Add(p);
    }
    public void Muve() 
    {
        ismuwe = true;
        Aura.rid.lvl = lvl;
        Aura.rid.num = num;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Peshka" && (ismuwe)) 
        {
            other = collision;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Peshka" && (ismuwe))
        {
            other = null;
        }
    }

    private void Update()
    {
        if (!ismuwe) 
        {
            aura.transform.Rotate(transform.forward * 70 * Time.deltaTime);
        }
        figure.sprite = sprite[lvl];
        if (Spavner.rid.enemies.Count > 0) 
        {
            looker.LookAt(Spavner.rid.enemies[0].position);
        }
        if (ismuwe)
        {
            transform.position = Input.mousePosition;
        }
        else 
        {
            if (other != null)
            {
                if (other.GetComponent<ButonEmiter>().lvl == lvl&& other.GetComponent<ButonEmiter>().num == num)
                {
                    if (lvl < sprite.Length - 1)
                    {
                        Destroy(gameObject);
                        other.GetComponent<ButonEmiter>().lvl += 1;
                        other.GetComponent<ButonEmiter>().RandoMaiser();
                        Spavner.rid.poses.Add(parent);
                    }
                    else {
                        transform.parent = parent;
                        Resed();
                    }
                }
                else 
                {
                    transform.parent = parent;
                    Resed();
                }
            }
            else 
            {
                parent = transform.parent;
            }
        }
    }
}
