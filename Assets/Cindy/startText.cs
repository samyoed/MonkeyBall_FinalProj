using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startText : MonoBehaviour
{

	public float timer;
	public Text floor;
	public Text ready;
	public Text go;
	
	// Use this for initialization
	void Start ()
	{
		timer = 3;
		floor.color = new Color(0f, 0f, 0f, 0f);
		ready.color = new Color(0f, 0f, 0f, 0f);
		go.color = new Color(0f, 0f, 0f, 0f);


	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer > 2 && timer < 3)
		{
			floor.color = Color.yellow;
		}
		else
		{
			floor.color = new Color(0f, 0f, 0f, 0f);
		}

		if (timer > 1 && timer < 2)
		{
			ready.color = Color.red;
		}
		else
		{
			ready.color = new Color(0f, 0f, 0f, 0f);

		}

		if (timer > 0 && timer < 1)
		{
			go.color = Color.blue;
		}
		else
		{
			go.color = new Color(0f, 0f, 0f, 0f);

		}
		
	}
}
