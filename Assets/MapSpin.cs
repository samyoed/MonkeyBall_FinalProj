using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpin : MonoBehaviour
{
	public float rotSpeed = 0;
	//public Vector3 mapCenter;
	
	// Update is called once per frame
	void Update ()
	{

	
		RotateInPlace();
		
		
	}
	
	void RotateInPlace()
	{
		transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);
	}
	
}
