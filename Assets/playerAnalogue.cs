using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnalogue : MonoBehaviour
{

	public GameObject playerSphere;
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position = playerSphere.transform.position;
		this.transform.eulerAngles = new Vector3(0, playerSphere.transform.localEulerAngles.y, 0);
	}
}
