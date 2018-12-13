using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSelfDestroy : MonoBehaviour {

	int spin = 100;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		spin += -1;
		if (spin <= 0)
		{
			Destroy(gameObject);		}
	}
}

