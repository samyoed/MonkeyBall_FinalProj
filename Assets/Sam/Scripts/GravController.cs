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

		//transform.rotation = new Quaternion(transform.rotation.x, Camera.main.transform.rotation.y, transform.rotation.z, transform.rotation.w);
		//transform.rotation = new Quaternion(0, Camera.main.transform.rotation.y,0,0);

		
		
		
		
		
	}
}
