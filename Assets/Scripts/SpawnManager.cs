using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

	public GameObject[] objectPrefabs;
	
	private float spawnLimitX1 = 1f;
	private float spawnLimitX2 = -1f;
    private float spawnPosY = 10.0f;
	
	private float startDelay = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Spawn random objects after a given time
        if(LevelManager.currentLevelIndex < 4)
        {
		    InvokeRepeating("SpawnFruit", startDelay, Random.Range(.8f, 1.5f));
		    InvokeRepeating("SpawnStone", startDelay, Random.Range(1f,5f));
        }
        
        if(LevelManager.currentLevelIndex >= 4)
        {
        	 InvokeRepeating("SpawnFruit", startDelay, Random.Range(0.1f,1f));
        	 InvokeRepeating("SpawnStone", startDelay, Random.Range(.5f,3f));
        }
        
    }
    
    Vector3 SpawnPos()
    {
		// Generate random object index and random spawn position
        Vector3 spawnPos = new Vector3( Random.Range(spawnLimitX2, 
        spawnLimitX1) , spawnPosY, 0);
        
        return spawnPos;
    }

    void SpawnFruit()
    {

        int objectIndex = 0;
      
      	if(GameManager.isGameStarted)
      	{ 	
        	Instantiate(objectPrefabs[objectIndex], SpawnPos(), Quaternion.identity);     
      	}
    }
    
     void SpawnStone()
    {

        int objectIndex = Random.Range(1,3);
      
      	if(GameManager.isGameStarted)
      	{ 	
        	
        	if(LevelManager.currentLevelIndex <= 3)
        	{
        		Instantiate(objectPrefabs[1], SpawnPos(), Quaternion.identity);  
        	}
        	
        	if(LevelManager.currentLevelIndex >= 4)
        	{
        	    Instantiate(objectPrefabs[objectIndex], SpawnPos(), Quaternion.identity);  
        	}
      	}
    }

}
