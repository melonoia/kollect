using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
	public static int fruitScore;
	public static bool isStoned;
	
	private ParticleSystem objectParticle;
    // Start is called before the first frame update
    void Start()
    {
		fruitScore = 0;
		isStoned = false;
		objectParticle =     		GetComponentInChildren<ParticleSystem>();
    }

    void OnTriggerEnter(Collider collider)
    {
    	if(collider.gameObject.CompareTag("Fruit"))
    	{
    		fruitScore++;
    		objectParticle.Play();
    		Destroy(collider.gameObject);
    	}
    	
    	if(collider.gameObject.CompareTag("Stone"))
    	{
    		isStoned = true;
    		objectParticle.Play();
    		Destroy(collider.gameObject);
    	}
    	   	
    }
}
