using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

	public static int lifeCounter;
	public static int floorCounter;

	public float timer = 60;

	public Text floorText;
	public Text timerSecText;
	public Text timerFracText;

	public bool startManager = false, GO = false;
	public GameObject player;
	
	// Use this for initialization
	void Start () {
				
		lifeCounter = 3;
		floorCounter = 1;
		floorText.text = "Floor 1";
<<<<<<< HEAD
		StartCountdownTimer();
		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;
		
		if (sceneName == "Player 2")
		{
			floorCounter = 2;
			floorText.text = "Floor " + floorCounter;
		}
=======

		StartCountdownTimer ();
		
>>>>>>> 71ea0190014a6d8a7cea03170d63f22102d4e7b3
	}

	void StartCountdownTimer()
	{
		if (timerSecText != null)
		{
			timer = 60;
			timerSecText.text = "060";
			InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
		}

		if (timerFracText != null)
		{
			timerFracText.text = ":00";
		}
	}

	void UpdateTimer()
	{
		if (player.GetComponent<PlayerController>().GO) {
			if (timerSecText != null) {
				timer -= Time.deltaTime;
				string seconds = (timer % 60).ToString ("000");
				timerSecText.text = seconds;
			
			}

			if (timerFracText != null) {
				string fraction = ((timer * 100) % 100).ToString ("00");
				timerFracText.text = ":" + fraction;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.T))
		{
			lifeCounter--;
		}
		if (lifeCounter < 0)
		{
			SceneManager.LoadScene("Main Menu");
		}

		if (timer <= 0)
		{
			SceneManager.LoadScene("Player");
		}

	}

}
