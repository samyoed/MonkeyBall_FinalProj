using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
	public GameObject player;
	
	public GameObject camTarget;
	private Transform tarTransform;
	private Vector3 tarPosition = new Vector3(0, 0, 0);
	private Vector3 newDir = new Vector3(0, 0, 0);
	public float turnSpeed = 0;

	private Rigidbody playerRB;
	
	// Use this for initialization
	void Start ()
	{
		playerRB = player.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		lookAtTarget();
		followPlayer();
	}

	void lookAtTarget()
	{
		tarTransform = camTarget.transform;
		Vector3 targetDir = tarTransform.position - this.transform.position;
		float step = turnSpeed * Time.deltaTime;

		newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0f);


		this.transform.rotation = Quaternion.LookRotation(newDir);
	}

	void followPlayer()
	{
			tarPosition = (player.transform.position - (playerRB.velocity * .25f)) + (Vector3.up * 2) -
			              (player.transform.forward * 2);
		
		//Debug.Log("targetPosition = " + tarPosition);

        this.transform.position += (tarPosition - transform.position) * Time.deltaTime * 4;

		//this.transform.position = Vector3.MoveTowards(transform.position, tarPosition, 1);
		
		//tarPosition = (player.transform.position + ((player.transform.up * 2) - (player.transform.forward * 6)));
		//this.transform.position = Vector3.MoveTowards(transform.position, tarPosition, 1);
	}
}
