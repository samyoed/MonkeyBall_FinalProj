using UnityEngine;
using System.Collections;

public class scrCameraSpin : MonoBehaviour {

	int spin = 360;
	
	// Use this for initialization
	void Start () {
		transform.Translate(0f, Time.deltaTime * 860, 0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		spin += -1;
		if (spin >= 0)
		{
		transform.Rotate(0f, 2f, 0f);
        transform.Translate(0f, Time.deltaTime * -3, 0f);
		}
	}
}


//Person that follows Claw and watches his buying habbits