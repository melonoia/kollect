using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
	public GameObject settingsPanel;
	public GameObject startPanel;
	public GameObject resumePanel;
	public GameObject gamePlayPanel;
	public GameObject gameOverPanel;

	public TextMeshProUGUI highscoreText;
	public TextMeshProUGUI fruitsText;
	public TextMeshProUGUI gameOverHighscoreText;
	public TextMeshProUGUI musicText;	
	public TextMeshProUGUI soundsText;	
	
	public Button settingsButton;
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
	
	private AudioSource cameraMusic;
	private AudioSource gameSounds;
	
	public static bool sounds;
	private bool music;
	
	private Scene scene;
	
    // Start is called before the first frame update
    void Awake()
    {
    	scene = SceneManager.GetActiveScene(); 
    	
    	cameraMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();	
    	gameSounds = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    	
    	sounds = music = true;
     }

    // Update is called once per frame
    void Update()
    {
    	 	
 		if(GameManager.isGameStarted)
 		{
 			gamePlayPanel.SetActive(true);
    		startPanel.SetActive(false);
 		}
        
        if(GameManager.isGameOver){
        	gameOverHighscoreText.text = GameManager.fruitsText.text;
        	gamePlayPanel.SetActive(false);
        	gameOverPanel.SetActive(true);
        }         
    }
    
    public void GetSettings(){
        startPanel.SetActive(false);
        settingsPanel.SetActive(true);
    } 
    
      public void PauseGame(){
		Time.timeScale = 0;
        resumePanel.SetActive(true);   	
    }
    
    public void ResumeGame(){
    	Time.timeScale = 1;
    	resumePanel.SetActive(false);
    }
    
    public void StartMenu()
    {
    	startPanel.SetActive(true);
    	settingsPanel.SetActive(false);
    }
    
	 public void muteMusic()
	 {
	 	if(music)
	 	{
	   		cameraMusic.Stop();
	   		musicText.text = "MUSIC: OFF";
	   		music = false;
	 	}
	 	else
	 	{
	 		cameraMusic.Play();
	   		musicText.text = "MUSIC: ON";
	   		music = true;
	 	}
	 	
	 }
	 
	 public void muteSounds()
	 {
	 	if(sounds)
	 	{
	   		soundsText.text = "SOUNDS: OFF";
	   		sounds = false;
	 	}
	 	else
	 	{
	   		soundsText.text = "SOUNDS: ON";
	   		sounds = true;
	 	}
	   	
	 }
   
     public void ReplayGame(){
 		SceneManager.LoadScene(scene.name);
    }
    
     public void QuitGame(){
    	Application.Quit();
    }
    
}
