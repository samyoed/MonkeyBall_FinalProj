using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

	public static int score;
	public static int bananaCounter;
	public static int lifeCounter;
	public static int floorCounter;
	public int speedCounter;

	public Text scoreText;
	public Text bananaText;
	public Text floorText;
	public Text speedText;

	
	// Use this for initialization
	void Start () {
				
		lifeCounter = 3;
		floorCounter = 1;

	}
	
	// Update is called once per frame
	void Update () {

		
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
