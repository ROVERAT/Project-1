using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorPosition : MonoBehaviour
{
    public ButonEmiter be;
    public Sprite nulSprite;
    public int num;
    public string names;
    public Vector2 cPos;
    public Image img;
    public static CursorPosition rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Resed() 
    {
        img.sprite = nulSprite;
    }
    void Update()
    {
        cPos.y = Input.mousePosition.y/Screen.height*5;
        cPos.x = Input.mousePosition.x / Screen.width*9;
        img.transform.localPosition = cPos;
    }
}
