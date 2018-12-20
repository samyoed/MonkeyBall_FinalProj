using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombFuseScript : MonoBehaviour {

	public float minSize = 0f, maxSize = 0f;
	public bool growing = false;

	public int currentWaypointTarget = 0;
	public float[] turnTime = new float[2];
	public GameObject gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		sizeShift ();

		if (gameManager.GetComponent<gameManager> ().timer < 42f) {
			moveTowardsWaypoint ();
		}
	}

	void sizeShift ()	{
		if (growing) {
			this.GetComponent<RectTransform>().localScale *= (Time.deltaTime * 2) + 1f;

			if (this.GetComponent<RectTransform>().localScale.magnitude > maxSize) {
				growing = false;
			}
		}
		if (!growing) {
			this.GetComponent<RectTransform>().localScale /= (Time.deltaTime * 2) + 1f;

			if (this.GetComponent<RectTransform>().localScale.magnitude < minSize) {
				growing = true;
			}
		}
	}

	void moveTowardsWaypoint ()	{
		if (gameManager.GetComponent<gameManager> ().timer > turnTime [1]) {
			this.GetComponent<RectTransform> ().localPosition -= Vector3.right * Time.deltaTime * 9.3f;
		}
		else if (gameManager.GetComponent<gameManager> ().timer > turnTime [0]) {
			this.GetComponent<RectTransform> ().localPosition -= Vector3.right * Time.deltaTime * 8.7f;
			this.GetComponent<RectTransform> ().localPosition += Vector3.up * Time.deltaTime * 7.5f;
			currentWaypointTarget = 1;
		}
		else if (gameManager.GetComponent<gameManager> ().timer < turnTime [0]) {
			this.GetComponent<RectTransform> ().localPosition -= Vector3.right * Time.deltaTime * 8.8f;
			this.GetComponent<RectTransform> ().localPosition -= Vector3.up * Time.deltaTime * 8;
			currentWaypointTarget = 2;
		}
	}
}
