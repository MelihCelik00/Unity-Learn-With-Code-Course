using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(0,0,20),animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
