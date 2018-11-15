using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(this.transform.position, transform.forward, Color.red);
	}
}
