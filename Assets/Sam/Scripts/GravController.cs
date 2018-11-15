using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravController : MonoBehaviour
{
	
	public float gravMult = 1;

	public GameObject camTarget;
	
	// Update is called once per frame
	void Update () {
		
		//this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, camTarget.transform.eulerAngles.y, this.transform.eulerAngles.z);
		Physics.gravity = gravMult *- transform.up;
	}
}
