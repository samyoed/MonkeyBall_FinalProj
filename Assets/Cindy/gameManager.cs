using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

	public static int lifeCounter;
	public static int floorCounter;

	public float timer = 60;

	public Text floorText;
	public Text timerText;
	
	
	// Use this for initialization
	void Start () {
				
		lifeCounter = 3;
		floorCounter = 1;
		floorText.text = "Floor: 1";
		StartCountdownTimer();

		DontDestroyOnLoad(this.gameObject);
	}

	void StartCountdownTimer()
	{
		if (timerText != null)
		{
			timer = 60;
			timerText.text = "060:00";
			InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
		}
	}

	void UpdateTimer()
	{
		if (timerText != null)
		{
			timer -= Time.deltaTime;
			string seconds = (timer % 60).ToString("000");
			string fraction = ((timer * 100) % 100).ToString("00");
			timerText.text = seconds + ":" + fraction;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.U))
		{
			floorCounter++;
			floorText.text = "Floor: " + floorCounter;
		}

	
		if (Input.GetKeyDown(KeyCode.T))
		{
			lifeCounter--;
		}
		if (lifeCounter < 0)
		{
			GetComponent<PlayerController>().bananaCount = 0;
			//GetComponent<PlayerController>().scoreCount = 0;

			SceneManager.LoadScene("Main Menu");
		}

	}

}
