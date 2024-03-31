using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonEmiter : MonoBehaviour
{
    public Collider2D other;
    public LayerMask mask;
    public int lvl;
    private bool ismuwe;
    private Transform parent;
    public void Resed() 
    {
        transform.localPosition = Vector2.zero;
        ismuwe = false;
    }

    public void Muve() 
    {
        ismuwe = true;
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
        if (ismuwe)
        {
            transform.position = Input.mousePosition;
        }
        else 
        {
            if (other != null)
            {
                if (other.GetComponent<ButonEmiter>().lvl == lvl)
                {
                    Destroy(other.gameObject);
                    lvl += 1;
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
