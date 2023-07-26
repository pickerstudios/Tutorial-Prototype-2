using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefeb;
    //public int animalIndex ;
    public float SpawnX = 20;
    public float SpawnZ = 20;

    private float StartDelay    = 1f;
    private float SpawnInterval = 0.5f;

    void Start()
    {
        InvokeRepeating("SpawnAnimal", StartDelay, SpawnInterval);
    }
    void Update()
    {
      /*  if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnAnimal();
        }*/
    }

    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, AnimalPrefeb.Length);
        Vector3 Spawn = new Vector3(Random.Range(-SpawnX, SpawnX), 0, SpawnZ);
        Instantiate(AnimalPrefeb[animalIndex], Spawn, AnimalPrefeb[animalIndex].transform.rotation);
    }
    
}
