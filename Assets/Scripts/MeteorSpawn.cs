using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public GameObject []Item;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 5f;
    public float spawnXLimit = 18f;

    void Start()
    {
         Spawn();
    }

    void Spawn()
    {
        float random = Random.Range(-spawnXLimit, spawnXLimit);
        Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
        int i = Random.Range(0, Item.Length);
        Instantiate(Item[i], spawnPos, Quaternion.identity);


        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
