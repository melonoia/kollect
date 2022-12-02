using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    private AudioManager audioManager;
    private ParticleSystem objectParticle;

    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        objectParticle = GetComponentInChildren<ParticleSystem>();
        StartCoroutine(DestroySpawnObject());

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            if (gameObject.CompareTag("Fruit"))
            {
                audioManager.Play("squish");
                //objectParticle.Play();
            }

            if (gameObject.CompareTag("Stone"))
            {
                audioManager.Play("fall");
                objectParticle.Play();
               // Destroy(gameObject, 1);

            }
        }
    }

    IEnumerator DestroySpawnObject()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

}
