using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

	private Scene currentScene;
	private Scene mainMenu;
	private Scene game;
		
	// Use this for initialization
	void Start () {
		
		DontDestroyOnLoad(this.gameObject);
		
		currentScene = SceneManager.GetActiveScene();
		mainMenu = SceneManager.GetSceneByName("Main Menu");
		game = SceneManager.GetSceneByName("Game");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space) && currentScene == mainMenu)
		{
			SceneManager.LoadScene("Game");
		}		
		
		
		
	}
}
