using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizDegrees = 0;
	public float vertDegrees = 0;
	
	public int bananaCount = 0;

	private float vertAccelI = 0;
	public float vertMax = 0;
	private float horizAccelI = 0;
	public float horizMax = 0;

	private Rigidbody thisRB;
	public GameObject camTarget;
	private float yAngleDir = 0;
	
	// Use this for initialization
	void Start ()
	{
		thisRB = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		SetYRotation();
		
		if (Input.GetAxis("Vertical") != 0 && Mathf.Abs(vertAccelI) < vertMax)
		{
			vertAccelI += Input.GetAxis("Vertical") * Time.deltaTime * 20;
		}
		else vertAccelI = Mathf.MoveTowards(vertAccelI, 0, Time.deltaTime * 8);

		if (Input.GetAxis("Horizontal") != 0 && Mathf.Abs(horizAccelI) < horizMax)
		{
			horizAccelI += Input.GetAxis("Horizontal") * Time.deltaTime * 8;
		}
		else horizAccelI = Mathf.MoveTowards(horizAccelI, 0, Time.deltaTime * 8);

		
		transform.eulerAngles = new Vector3(-vertAccelI, yAngleDir, horizAccelI);
		
		
		
		
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
		}
	}

	private void SetYRotation()		//Determines direction facing of yRot and adjusts appropriately
	{
		float xVelo = thisRB.velocity.x;
		float zVelo = thisRB.velocity.z;

		if (zVelo != 0)		//Avoid NaN Errors
		{
			float currentVeloDir = (Mathf.Atan(xVelo / zVelo) * Mathf.Rad2Deg) - 90f;

			if (zVelo > 0)
			{
				currentVeloDir = Mathf.Abs(currentVeloDir);
			}

			else
			{
				currentVeloDir = (Mathf.Atan(-xVelo / zVelo) * Mathf.Rad2Deg) - 90f;
			}
				//Debug.Log("angle = " + currentVeloDir);
			
			yAngleDir =  -currentVeloDir + 90;
			camTarget.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, yAngleDir, this.transform.eulerAngles.z);
			
			/*this.transform.eulerAngles = Vector3.MoveTowards(
					this.transform.eulerAngles,
					new Vector3(this.transform.eulerAngles.x, currentVeloDir, this.transform.eulerAngles.z), 
					Time.deltaTime * 18
				);*/
		}
	}
}
