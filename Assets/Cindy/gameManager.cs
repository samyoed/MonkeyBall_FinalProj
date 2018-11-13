using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

	public static int lifeCounter;
	public static int floorCounter;

	public Text floorText;
	
	// Use this for initialization
	void Start () {
				
		lifeCounter = 3;
		floorCounter = 1;
		floorText.text = "Floor: 1";

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
			GetComponent<PlayerController>().scoreCount = 0;

			SceneManager.LoadScene("Main Menu");
		}
		
	}

}
