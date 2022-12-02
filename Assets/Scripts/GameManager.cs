using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class GameManager : MonoBehaviour
{
	public static bool isGameStarted;
	public static bool isGameOver;
	
	public GameObject[] lives;
	
	private int livesLeft;
	public static int fruitsScore;
	
	public static bool mute = false;
	
	public static TextMeshProUGUI highscoreText;
	public static TextMeshProUGUI fruitsText;
	
    // Start is called before the first frame update
    void Start()
    {
    	Time.timeScale = 1;
    	
        isGameStarted = isGameOver = false;
        
        livesLeft = 5;
        
        highscoreText = GetComponent<MenuManager>().highscoreText;
        fruitsText = GetComponent<MenuManager>().fruitsText;
        
        highscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
 		
        if(
        //Input.GetMouseButtonDown(0) && !isGameStarted
     //   ||
       Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began 
        )
        {
    		if(
   EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId) 
    		// ||
    //		 EventSystem.current.IsPointerOverGameObject()
    		)
    			return;
    		isGameStarted = true;
    		
    	}
    	
   		if(!GameManager.isGameStarted)
        	return;
    		
    	fruitsScore = BasketController.fruitScore;
    	fruitsText.text = fruitsScore.ToString();
    	
        if(fruitsScore > PlayerPrefs.GetInt("HighScore") )
        {
           	PlayerPrefs.SetInt("HighScore", fruitsScore);
        }
    	
        for(int i = lives.Length-1; i >= 0; i--)
        {
        	if(BasketController.isStoned && lives[i].activeSelf)
        	{
        			lives[i].SetActive(false);
        			livesLeft--;
	       			BasketController.isStoned = false;
        	}
        		
        	if(livesLeft == 0)
        	{
        		isGameOver = true;
        	}
    	}
    	
    	if(isGameOver)
    	{
          Time.timeScale = 0;
    	}
    	
	}    
}
