using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int xLocation = 15;
    private int zLocation = 20;
    private float startTime = 2f;
    private float internalTime = 1.5f;

    void Start()
    {
        InvokeRepeating("RandomHorizontalSpawn", startTime, internalTime);
        InvokeRepeating("RandomVerticalSpawn", startTime, internalTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    } 


    void RandomHorizontalSpawn()
    {
        int randomAnimal = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-xLocation,xLocation) , 0, zLocation);

        var rotationVector = animalPrefabs[randomAnimal].transform.rotation.eulerAngles;
        rotationVector.y = 180;

        Instantiate(animalPrefabs[randomAnimal], spawnPosition, animalPrefabs[randomAnimal].transform.rotation = Quaternion.Euler(rotationVector));
        
    }

    void RandomVerticalSpawn()
    {
        int randomAnimal = Random.Range(0, animalPrefabs.Length);
        int randomLeftRight = Random.Range(0, 2);

        Vector3 verticalSpawn = new Vector3(xLocation, 0, Random.Range(5, 15));

        var rotationVector = animalPrefabs[randomAnimal].transform.rotation.eulerAngles;

        if (randomLeftRight == 0)
        {
            rotationVector.y = 90;

            verticalSpawn.x = -xLocation;

            Instantiate(animalPrefabs[randomAnimal], verticalSpawn, animalPrefabs[randomAnimal].transform.rotation = Quaternion.Euler(rotationVector));

        }
        if (randomLeftRight == 1)
        {
            rotationVector.y = 270;

            verticalSpawn.x = xLocation;

            Instantiate(animalPrefabs[randomAnimal], verticalSpawn, animalPrefabs[randomAnimal].transform.rotation = Quaternion.Euler(rotationVector));
        }
    }
}
