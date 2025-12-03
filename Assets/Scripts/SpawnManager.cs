using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float RandomXPositon = 10f;
    private float ZPositon = 20f;
    private float SpawnDelay = 2f;
    private float SpawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", SpawnDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-RandomXPositon, RandomXPositon), 0, ZPositon);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
