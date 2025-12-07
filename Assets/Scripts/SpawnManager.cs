using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float RandomXPositon = 10f;
    private float MinZ = -3f;
    private float MaxZ = 20f;
    private float ZPositon = 20f;
    private float XPosition = 23.5f;
    private float SpawnDelay = 3f;
    private float SpawnInterval = 3.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", SpawnDelay, SpawnInterval);
        InvokeRepeating("SpawnLeft",SpawnDelay, SpawnInterval);
        InvokeRepeating("SpawnRight", SpawnDelay, SpawnInterval);
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
    public void SpawnLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-XPosition, 0, Random.Range(MinZ,MaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex],spawnPos,Quaternion.Euler(rotation));

    }
    public void SpawnRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(XPosition, 0, Random.Range(MinZ, MaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }
}
