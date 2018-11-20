using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

	private static Component gameManager;
	
	public Text paused;
	public Text restart;
	public Text gotoMenu;
	
	public bool isPaused;
	
	// Use this for initialization
	void Awake()
	{
		if (gameManager == null)
		{
			gameManager = this;
		}
		else
		{
			DestroyObject(gameObject);
		}
	}
	
	void Start ()
	{
		isPaused = false;
		
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
			SceneManager.LoadScene("Player");
		}
		if (Input.GetKey(KeyCode.Escape) && isPaused != false)
		{
			Time.timeScale = 1;
			SceneManager.LoadScene("Main Menu");
		}

		
	}
}
