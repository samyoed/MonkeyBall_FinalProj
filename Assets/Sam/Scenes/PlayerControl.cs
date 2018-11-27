

using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed;

	public GameObject camera;

	void FixedUpdate()
	{
		float movementHorizontal = Input.GetAxis("Horizontal");
		float movementVertical = Input.GetAxis("Vertical");

		Vector3 movementVector = new Vector3(movementHorizontal, 0.0f, movementVertical);
		movementVector = camera.transform.TransformDirection(movementVector);

		GetComponent<Rigidbody>().AddForce(movementVector * speed * Time.deltaTime);
	}
}