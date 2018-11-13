using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float horizDegrees = 0;
	public float vertDegrees = 0;
	
	public int bananaCount = 0;
	public int scoreCount = 0;

	private float vertAccelI = 0;
	public float vertMax = 0;
	private float horizAccelI = 0;
	public float horizMax = 0;

	public Text bananaText;
	public Text scoreText;
	public Text speedText;
	
	Vector3 PrevPos; 
	Vector3 NewPos; 
	Vector3 ObjVelocity;
	
	// Use this for initialization
	void Start ()
	{
		bananaText.text = "BANANA: 0/100";
		scoreText.text = "SCORE: 0";
		PrevPos = transform.position;
		NewPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		speedText.text = Mathf.RoundToInt(Mathf.Abs(ObjVelocity.x + ObjVelocity.z)) + " MPH";
		
		NewPos = transform.position; 
		ObjVelocity = (NewPos - PrevPos) / Time.fixedDeltaTime;  
		PrevPos = NewPos;  
		
		if (Input.GetAxis("Vertical") != 0 && Mathf.Abs(vertAccelI) < vertMax)
		{
			vertAccelI += Input.GetAxis("Vertical") * Time.deltaTime * 20;
		}
		else vertAccelI = Mathf.MoveTowards(vertAccelI, 0, Time.deltaTime * 8);

		if (Input.GetAxis("Horizontal") != 0 && Mathf.Abs(horizAccelI) < horizMax)
		{
			horizAccelI += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
		}
		else horizAccelI = Mathf.MoveTowards(horizAccelI, 0, Time.deltaTime * 8);

		//float horiz = horizDegrees * horizAccel * Input.GetAxis("Horizontal");
		//float vert = vertDegrees * vertAccel * Input.GetAxis("Vertical");

		transform.eulerAngles = new Vector3(-vertAccelI, 0, horizAccelI);
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
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Banana")
		{
			Destroy(other.gameObject);
			bananaCount++;
			scoreCount += 100;
			bananaText.text = "BANANA: " + bananaCount + "/100";
			scoreText.text = "SCORE: " + scoreCount;
		}
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
