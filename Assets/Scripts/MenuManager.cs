using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
	public GameObject settingsPanel;
	public GameObject startPanel;
	public GameObject levelsPanel;
	public GameObject resumePanel;
	public GameObject gameWinPanel;
	public GameObject gameOverPanel;

	public TextMeshProUGUI highscoreText;
	public TextMeshProUGUI coinText;
	public TextMeshProUGUI fruitsText;
	
	public Button settingsButton;
	//public Button shopButton;
	public Button soundsButton;
	public Button musicButton;
	public Button femaleButton;	
	public Button maleButton;
	public Button backButton;
	public Button homeButton;
	public Button pauseButton;
	public Button resumeButton;
	public Button replayButton;
	public Button quitButton;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*
        if(GameManager.isGameOver){
        	// Debug.Log("Game Over");
        	gameOverPanel.SetActive(true);
        }
        
        if(GameManager.isGameCompleted){
        	gameWinPanel.SetActive(true);
        }
*/
        
    }
    
    public void GetSettings(){
        settingsPanel.SetActive(true);
    } 
    
     public void GetShop(){

    }
    
    public void ResumeGame(){
        resumePanel.SetActive(true);
    }
    
    public void GetStartMenu(){
        startPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
    
    public void GetLevels(){
    	levelsPanel.SetActive(true);
    	startPanel.SetActive(false);
    }
    
     public void QuitGame(){
    	Application.Quit();
    }
    
}
