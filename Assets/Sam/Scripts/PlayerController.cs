using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizDegrees = 45;
	public float vertDegrees = 45;
	
	

	public float vertAccel = 1;
	public float horizAccel = 1;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
		float h = horizDegrees * horizAccel *Input.GetAxis("Horizontal");
		float v = vertDegrees * vertAccel *Input.GetAxis("Vertical");

		transform.eulerAngles = new Vector3(-v, 0, h);
		//transform.RotateAround(Vector3.zero, new Vector3(v, 0f, h), vertDegrees *Time.deltaTime );
/*
		if (!Input.GetButtonDown("Vertical"))
		{
			if(transform.eulerAngles.z > 0f)
			transform.RotateAround(Vector3.zero, new Vector3(-1, 0, 0), vertDegrees);
			else if(transform.eulerAngles.z < 0f)
			transform.RotateAround(Vector3.zero, new Vector3(1, 0, 0), vertDegrees);

		}
		if (!Input.GetButtonDown("Horizontal"))
		{
			if(transform.eulerAngles.x > 0f)
				transform.RotateAround(Vector3.zero, new Vector3(-1, 0, 0), vertDegrees);
			else if(transform.eulerAngles.x < 0f)
				transform.RotateAround(Vector3.zero, new Vector3(1, 0, 0), vertDegrees);

		}*/

		//Physics.gravity = new Vector3(0f, Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));


	}


	/*void AccelInput()
	{
		
		//Right
		if (Input.GetAxis("Horizontal") > 0 && horizAccel < horizDegrees)
		{
			horizAccel += Time.deltaTime;
		}
		else if (horizAccel > 0)
		{

			horizAccel -= Time.deltaTime;
		}
		
		//Left
		if (Input.GetAxis("Horizontal") < 0 && horizAccel > horizDegrees)
		{
			horizAccel -= Time.deltaTime;
		}
		else if (horizAccel < 0)
		{

			horizAccel += Time.deltaTime;
		}
		
		//Forward
		if (Input.GetAxis("Vertical") > 0 && vertAccel < vertDegrees)
		{
			vertAccel += Time.deltaTime;
		}
		else if (vertAccel > 0)
		{

			vertAccel -= Time.deltaTime;
		}
		
		//Back
		if (Input.GetAxis("Vertical") < 0 && vertAccel < vertDegrees)
		{
			vertAccel -= Time.deltaTime;
		}
		else if (vertAccel < 0)
		{

			vertAccel += Time.deltaTime;
		}
	}   */
}
