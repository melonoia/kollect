using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

	public GameObject[] fruitPrefabs;
	
	private float spawnLimitX = .4f;
    private float spawnPosY = 4f;
	
	private float startDelay = 2;
    private float spawnInterval;
    
    // Start is called before the first frame update
    void Start()
    {
    	// Spawn between 3 - 5 seconds
    	spawnInterval = Random.Range(3,6);
        // Spawn random fruits after a given time
        InvokeRepeating("SpawnRandomFruit", startDelay, spawnInterval);
    }

    void SpawnRandomFruit()
    {

		// Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(
       // Random.Range(-spawnLimitX, 
        spawnLimitX
        //)
        , spawnPosY, 0);

        int fruitIndex = Random.Range(0, fruitPrefabs.Length);
        
        /*
        Vector3[] angles = new Vector3[3];
        angles[0] = new Vector3(0, 180, 0);
        angles[1] = new Vector3(0, 90, 0);
        angles[2] = new Vector3(0, 270, 0);
        
        int angleIndex = Random.Range(0, angles.Length);

        transform.eulerAngles = angles[angleIndex];
        transform.rotation = Quaternion.Euler(transform.eulerAngles);
        
        animalPrefabs[animalIndex].transform.rotation = transform.rotation;
        
        */

        Instantiate(fruitPrefabs[fruitIndex], spawnPos,/* fruitPrefabs[fruitIndex].*/transform.rotation);
        
    }
}
