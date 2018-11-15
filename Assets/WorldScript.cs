using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScript : MonoBehaviour
{

	public GameObject playerSphereParent;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.eulerAngles = new Vector3(playerSphereParent.transform.eulerAngles.x, 0, playerSphereParent.transform.eulerAngles.z);
	}
}
