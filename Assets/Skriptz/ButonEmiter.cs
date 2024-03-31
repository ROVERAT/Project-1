using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonEmiter : MonoBehaviour
{
    public Image image;
    public Sprite[] sprite;
    public int num;
    private bool ismuwe;

    public void Resed() 
    {
        transform.localPosition = Vector2.zero;
        ismuwe = false;
    }

    public void Muve() 
    {
        ismuwe = true;
    }
    private void Update()
    {
        if (ismuwe)
        {
            transform.position = Input.mousePosition;
        }
        else 
        {

        }
    }
}
