using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camTargetScript : MonoBehaviour
{

	public GameObject playerSphere;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position = playerSphere.transform.position;
		//this.transform.position = playerSphere.transform.position + Vector3.up * 1.88f;

		this.transform.eulerAngles = new Vector3(0, this.transform.eulerAngles.y, 0);
	}
}
