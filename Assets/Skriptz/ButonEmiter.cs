using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonEmiter : MonoBehaviour
{
    public Image image;
    public Sprite[] sprite;
    public int num;

    public void UpLevel() 
    {
        if (num == 0) 
        {
            num = 1;
        }
    }
    public void MuweLevel() 
    {
        if (num > 0) 
        {
            if (CursorPosition.rid.names != gameObject.name)
            {
                if (num == CursorPosition.rid.num)
                {
                    num += 1;
                    CursorPosition.rid.be.num = 0;
                }
                else
                {
                    num = CursorPosition.rid.num;
                    CursorPosition.rid.Resed();
                }
            }
            else
            {
                num = CursorPosition.rid.num;
                CursorPosition.rid.Resed();
            }
        }
    }
    public void Muve() 
    {
        if (num >= 1)
        {
            CursorPosition.rid.be = this;
            CursorPosition.rid.num = num;
            CursorPosition.rid.img.sprite = image.sprite;
            CursorPosition.rid.names = gameObject.name;
            num = 0;
        }
    }
    private void FixedUpdate()
    {
        image.sprite = sprite[num];
    }
}
