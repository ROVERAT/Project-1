using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float interval;
    public GameObject cube;
    public Vector2 direction;
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
        monster.transform.position = transform.position;
        monster.transform.parent = transform;
        monster.speed = 100;
        monster.direction = direction;
        Repeat();
    }
}
