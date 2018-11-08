﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	private Scene currentScene;
	private Scene startMenu;
	private Scene game;
	
	// Use this for initialization
	void Start () {
		currentScene = SceneManager.GetActiveScene();
		startMenu = SceneManager.GetSceneByName("Main Menu");
		game = SceneManager.GetSceneByName("Game");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && currentScene == startMenu)
		{
			SceneManager.LoadScene("Game");
		}		

	}
}
