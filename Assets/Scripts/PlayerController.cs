using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator anim;

    private void Start() => anim = GetComponent<Animator>();    

    private void Update()
    {
    	 if(Swipe.isMoving)
        {
			anim.Play("handsUp");
        }
    	
    }
        	
 }
