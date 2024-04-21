using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spavner : MonoBehaviour
{
    public Color first, dan;
    public Text manna, keshManna;
    public Text[] lvles;
    public GameObject peshka;
    public Parameters parameters;
    public List<Transform> poses, enemies;
    public static Spavner rid { get; set; }
    private int tcena;
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
    private void FixedUpdate()
    {
        for (int i = 0; i < lvles.Length; i++) 
        {
            lvles[i].text = "" + parameters.lvls[i]*100;
        }
        if (parameters.manna >= tcena)
        {
            keshManna.color = first;
        }
        else 
        {
            keshManna.color = dan;
        }
        tcena = 40 + (parameters.tcena * 10);
        keshManna.text = "" + tcena;
        manna.text = "" + parameters.manna;
    }
    public void LvlUp(int num) 
    {
        int tcena = parameters.lvls[num] * 100;
        if (parameters.manna >= tcena) 
        {
            parameters.lvls[num] += 1;
            parameters.manna -= tcena;
        }
    }
    public void Spawn() 
    {
        if (parameters.manna >= tcena) 
        {
            if (poses.Count > 0)
            {
                int num = Random.Range(0, poses.Count);
                Transform pos = Instantiate(peshka).transform;
                pos.SetParent(poses[num].transform, false);
               // pos.parent = poses[num].transform;
               pos.localPosition = Vector2.zero;
                parameters.manna -= tcena;
                parameters.tcena += 1;
            }
        } 
    }
}
