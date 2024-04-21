using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float interval;
    public GameObject cube;
    public Vector2 direction;
    public static Spawner rid { get; set; }
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
    void Start()
    {
        StartCoroutine(SpawnCD());
    }


    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(interval);
        Direction monster = Instantiate(cube).GetComponent<Direction>();
        monster.transform.localPosition = Vector3.zero;
        monster.transform.SetParent(transform, false);
        monster.speed = 100;
        monster.direction = direction;
        Spavner.rid.enemies.Add(monster.transform);
        Repeat();
    }
    private void FixedUpdate()
    {
        if (interval > 0.5f) 
        {
            interval -= 0.01f * Time.fixedDeltaTime;
        }
    }
}
