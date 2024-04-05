using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Sprites;
using UnityEngine;
using UnityEngine.UI;

public class ButonEmiter : MonoBehaviour
{
    public Color[] collor;
    public GameObject[] tipePeshka;
    public RectTransform looker;
    public Image figure;
    public Sprite[] sprite;
    public Collider2D other;
    public LayerMask mask;
    public int lvl;
    private bool ismuwe;
    private Transform parent;

    private void Start()
    {
        RandoMaiser();
    }
    public void Resed() 
    {
        transform.localPosition = Vector2.zero;
        ismuwe = false;
    }

    public void RandoMaiser() 
    {
        int num = Random.Range(0, collor.Length);
        figure.color = collor[num];
        for (int i = 0; i < tipePeshka.Length; i++) 
        {
            if (i == num)
            {
                tipePeshka[i].SetActive(true);
            }
            else 
            {
                tipePeshka[i].SetActive(false);
            }
        }
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
                if (other.GetComponent<ButonEmiter>().lvl == lvl)
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
