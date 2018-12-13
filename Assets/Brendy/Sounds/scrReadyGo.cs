using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Net.Mime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrReadyGo : MonoBehaviour
{

	public float timer;
	public GameObject readyObj;
	public GameObject goObj;
	
	// Use this for initialization
	void Start ()
	{
		timer = 3;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer > 2 && timer < 3)
		{
			
		}
		else
		{
			
		}

		if (timer > 1 && timer < 2)
		{
			Instantiate(readyObj, 1, 1);
		}
		else
		{
			
		}

		if (timer > 0 && timer < 1)
		{
			Instantiate(goObj, 1, 1);
		}
		else
		{
			
		}
		
	}
}
