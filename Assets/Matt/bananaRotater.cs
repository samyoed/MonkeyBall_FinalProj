using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananaRotater : MonoBehaviour {

	public float rotSpeed = 0;
	
	// Update is called once per frame
	void Update () {
		
		RotateInPlace();
		
	}

	void RotateInPlace()
	{
		transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
		}
	}
}
