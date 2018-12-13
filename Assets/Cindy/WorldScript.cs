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

		if (playerSphereParent.GetComponent<PlayerController>().GO)
		{
			if (Mathf.Abs(this.transform.rotation.y) < .5f)
			{
				this.transform.rotation = new Quaternion(
					playerSphereParent.transform.rotation.x,
					0,
					playerSphereParent.transform.rotation.z * 2,
					playerSphereParent.transform.rotation.w
				);

				Debug.Log("rotX < 0");
			}
			else
			{
				this.transform.rotation = new Quaternion(
					playerSphereParent.transform.rotation.x,
					0,
					0,
					playerSphereParent.transform.rotation.w
				);

				Debug.Log("rotX >= 0");
			}
		}

/*this.transform.eulerAngles = new Vector3(
	playerSphereParent.transform.eulerAngles.x,
	0,
	playerSphereParent.transform.eulerAngles.z
	);
	*/

}
}
