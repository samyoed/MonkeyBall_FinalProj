using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	public int score;
	public int bananaCounter;
	public int lifeCounter;
	public int floorCounter;
	public int speedCounter;
	
	public Text scoreText;
	public Text bananaText;
	public Text floorText;
	public Text speedText;
	
	public Text paused;
	public Text restart;
	public Text gotoMenu;
	
	public bool isPaused;
	
	// Use this for initialization
	void Start ()
	{
		DontDestroyOnLoad(this.gameObject);
		isPaused = false;
		lifeCounter = 3;
		floorCounter = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (isPaused == true)
		{
			Time.timeScale = 0;
			paused.color = new Color(1, 1, 1, 1);
			restart.color = new Color(1, 1, 1, 1);
			gotoMenu.color = new Color(1, 1, 1, 1);
		}
		else if (isPaused == false)
		{
			Time.timeScale = 1;
			paused.color = new Color(1, 1, 1, 0);
			restart.color = new Color(1, 1, 1, 0);
			gotoMenu.color = new Color(1, 1, 1, 0);
		}
		
		
		if (Input.GetKeyDown(KeyCode.P) && isPaused != true)
		{
			isPaused = true;
		}
		else if (Input.GetKeyDown(KeyCode.P) && isPaused != false)
		{
			isPaused = false;
		}
		

		if (Input.GetKey(KeyCode.E) && isPaused != false)
		{
			isPaused = false;
			SceneManager.LoadScene("Game");
		}
		if (Input.GetKey(KeyCode.Escape) && isPaused != false)
		{
			bananaCounter = 0;
			score = 0;
			Time.timeScale = 1;
			SceneManager.LoadScene("Main Menu");
		}
		
		if (Input.GetKeyDown(KeyCode.Q))
		{
			score++;
			scoreText.text = "SCORE: " + score;
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			bananaCounter++;
			bananaText.text = "BANANAS: " + bananaCounter;
		}

		if (Input.GetKeyDown(KeyCode.U))
		{
			floorCounter++;
			floorText.text = "Floor: " + floorCounter;
		}

		if (Input.GetKey(KeyCode.Y))
		{
			speedCounter++;
		}
		if (!Input.GetKey(KeyCode.Y) && speedCounter > 0)
		{
			speedCounter--;
		}
		speedText.text = speedCounter + " MPH";

	
		if (Input.GetKeyDown(KeyCode.T))
		{
			lifeCounter--;
		}
		if (lifeCounter < 0)
		{
			bananaCounter = 0;
			score = 0;

			SceneManager.LoadScene("Main Menu");
		}

	}
}
