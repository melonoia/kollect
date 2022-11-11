using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{

	 public float horizontalInput;
    public float speed = 10.0f;
 
  	private void Awake()
    {

    }

 	private void Update()
    {
       
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }  
}
