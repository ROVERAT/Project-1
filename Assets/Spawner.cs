using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Cube;

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
        yield return new WaitForSeconds(1f);
        Instantiate(Cube, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
