using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
	private int fruitAcc;
	
	public static int currentLevelIndex;
    
    public static bool isLevelComplete;

    public GameObject dialogPanel;
    
    public TextMeshProUGUI levelBoxText;
    public TextMeshProUGUI dialogBoxText;
    
    private Animator anim;
    
	void Awake()
    {
        currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex", 1);
        fruitAcc = PlayerPrefs.GetInt("FruitAcc", 5);  	
		levelBoxText.text = "LEVEL " + currentLevelIndex;
    }
    
    void Start()
    {
		anim = dialogPanel.GetComponent<Animator>();
		dialogBoxText.text = levelBoxText.text;
    }

    void Update()
    {
                   
    	if(GameManager.isGameStarted)
    	{	
		    
			if(GameManager.fruitsScore == fruitAcc)
			{
    	 		isLevelComplete = true;
				
				currentLevelIndex += 1;
				
   				PlayerPrefs.SetInt("CurrentLevelIndex", currentLevelIndex);
   				
   				
	   			if(isLevelComplete)
	   			{
					levelBoxText.text = "LEVEL " + currentLevelIndex;
					dialogBoxText.text = levelBoxText.text;
					anim.SetTrigger("showLevel");

	   				int levAcc = currentLevelIndex;
	   				
	   				fruitAcc = (10*levAcc) + 5 * (levAcc+1);
	   				//fruitAcc += 5;

					PlayerPrefs.SetInt("FruitAcc", fruitAcc);
					
					isLevelComplete = false;
	   			}  
			}   
			    	  		 		
   		}  		
   
    }
}
