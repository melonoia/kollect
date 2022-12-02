using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 1.5f;
    
    public static bool isMoving;

    private void FixedUpdate()
    {
    	if(!GameManager.isGameStarted)
        	return;
        	
        if (Input.GetMouseButton(0))
        {

            isMoving = true;
            float mouseX = Input.GetAxisRaw("Mouse X");
            
            transform.Translate(mouseX * speed * Time.deltaTime, 0, 0);
            
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            float xDelta = Input.GetTouch(0).deltaPosition.x;
            
            transform.Translate(xDelta * 0.01f * Time.deltaTime, 0, 0);

        }

    }

}