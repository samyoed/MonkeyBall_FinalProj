using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCameraTween : MonoBehaviour {

    public Transform sphere, cube;
    int GameStart;

	public bool atTarget = false;
	public GameObject mainCam;

    void Start()
    {
        GameStart = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameStart += 1;

        if (GameStart <= 270)
        {
            //Debug.Log"Floor Number";
        }
        if (GameStart <= 360 && GameStart >= 271)
        {
            //Debug.Log"Ready";
        }

        if (GameStart >= 360)
        { 
        // x += (target - x) * 0.1
        // every frame, move 10% of the remaining distance;
        sphere.position += (cube.position - sphere.position) * 0.1f;
        }

		if (Vector3.Distance (this.transform.position, cube.transform.position) < .2f) {
			mainCam.SetActive (true);
			//this.gameObject.SetActive (false);
		}
    }
}
