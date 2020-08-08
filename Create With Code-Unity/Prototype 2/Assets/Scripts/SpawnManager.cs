using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    private float spawnRangeX = 17;
    private float spawnRangeZ = 20;

    private float startDelay = 2;
    private float repeatRate = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatRate);
    }

    private void Update()
    {
    }
    
    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos ,animalPrefabs[animalIndex].transform.rotation);
    }
}